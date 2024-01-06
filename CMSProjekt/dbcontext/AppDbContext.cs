using CMSProjekt.Models;
using Microsoft.EntityFrameworkCore;

namespace CMSProjekt.dbcontext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Page> Pages { get; set; }
    public DbSet<PageElement> PageElements { get; set; }
    public DbSet<Text> Texts { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Models.File> Files { get; set; }
    public DbSet<Table> Tables { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Settings> Settings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Page>().HasMany(e => e.PageElements).WithOne(e => e.Page).IsRequired();
        modelBuilder.Entity<Page>().Property(e => e.ParentPageId).HasDefaultValue(-1);
        modelBuilder.Entity<PageElement>().HasOne(a => a.Text).WithOne(a => a.Element).HasForeignKey<Text>(a => a.ElementId).IsRequired();
        modelBuilder.Entity<PageElement>().HasOne(a => a.Image).WithOne(a => a.Element).HasForeignKey<Image>(a => a.ElementId).IsRequired();
        modelBuilder.Entity<PageElement>().HasOne(a => a.File).WithOne(a => a.Element).HasForeignKey<Models.File>(a => a.ElementId).IsRequired();
        modelBuilder.Entity<PageElement>().HasOne(a => a.Table).WithOne(a => a.Element).HasForeignKey<Table>(a => a.ElementId).IsRequired();
        modelBuilder.Entity<Image>().Property(a => a.Caption).HasDefaultValue(string.Empty);
        modelBuilder.Entity<Models.File>().Property(a => a.Caption).HasDefaultValue(string.Empty);
        modelBuilder.Entity<Table>().Property(a => a.Caption).HasDefaultValue(string.Empty);
        base.OnModelCreating(modelBuilder);
    }
}
