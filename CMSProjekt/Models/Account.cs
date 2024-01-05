using System.ComponentModel.DataAnnotations;

namespace CMSProjekt.Models
{
    public class Account
    {
        [Key]
        public string Login { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
