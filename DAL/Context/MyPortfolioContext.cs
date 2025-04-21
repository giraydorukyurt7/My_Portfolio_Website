using Microsoft.EntityFrameworkCore;
using My_Portfolio_Website.DAL.Entities;

namespace My_Portfolio_Website.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-LKRO50O\\SQLEXPRESS;" +
                "Initial Catalog=MyPortfolioDb;" +
                "Integrated Security=true;" +
                "Encrypt=True;" +
                "TrustServerCertificate=True;"
            );
        }
        public DbSet<About> Abouts {get; set;}
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
