using CMSProjekt.dbcontext;
using CMSProjekt.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Newtonsoft.Json;
using System.Security.Claims;
using System.Text;

namespace CMSProjekt.Auth
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        private ProtectedSessionStorage protectedSessionStorage;
        private AppDbContext dbContext;
        public AuthStateProvider(ProtectedSessionStorage _protectedSessionStorage, AppDbContext _dbContext) 
        {
            protectedSessionStorage = _protectedSessionStorage;
            dbContext = _dbContext;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var principal = new ClaimsPrincipal();

            try
            {
                var storedPrincipal = await protectedSessionStorage.GetAsync<string>("identity");

                if (storedPrincipal.Success)
                {
                    var user = JsonConvert.DeserializeObject<Account>(storedPrincipal.Value);
                    var (_, isLookUpSuccess) = LookUpUser(user.Login, user.Password);

                    if (isLookUpSuccess)
                    {
                        var identity = CreateIdentityFromUser(user);
                        principal = new(identity);
                    }
                }
            }
            catch
            {

            }

            return new AuthenticationState(principal);
        }

        public async Task<bool> LoginAsync(string login, string password)
        {
            var (userInDatabase, isSuccess) = LookUpUser(login, password);
            var principal = new ClaimsPrincipal();

            if (isSuccess)
            {
                var identity = CreateIdentityFromUser(userInDatabase);
                principal = new ClaimsPrincipal(identity);
                await protectedSessionStorage.SetAsync("identity", JsonConvert.SerializeObject(userInDatabase));
            }

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(principal)));
            return isSuccess;
        }

        public async Task LogoutAsync()
        {
            await protectedSessionStorage.DeleteAsync("identity");
            var principal = new ClaimsPrincipal();
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(principal)));
        }

        private static ClaimsIdentity CreateIdentityFromUser(Account user)
        {
            return new ClaimsIdentity(new Claim[]
            {
                new (ClaimTypes.Name, user.Login),
                new (ClaimTypes.Hash, user.Password)
            }, "Custom");
        }

        private (Account?, bool) LookUpUser(string login, string password)
        {
            Account? foundAccount = dbContext.Account.Where(a => a.Login == login).FirstOrDefault();
            if (foundAccount == null)
                return (null, false);

            string hashedData = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password!,
                salt: Encoding.UTF8.GetBytes(foundAccount.Salt),
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));
            
            var result = dbContext.Account.FirstOrDefault(u => login == u.Login && hashedData == u.Password);
            
            Account? resultAccount = null;
            if(result is not null)
                resultAccount = new Account() { Login = result.Login, Password = password };

            return (resultAccount, resultAccount is not null);
        }
    }
}
