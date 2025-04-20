using Microsoft.EntityFrameworkCore;

namespace My_Portfolio_Website.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = ") 
                //TODO download Microsoft SQL Server Management Studio
        }
    }
}
