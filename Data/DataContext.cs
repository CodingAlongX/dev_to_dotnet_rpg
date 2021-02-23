using dev_to_dotnet_rpg.Models;
using Microsoft.EntityFrameworkCore;

namespace dev_to_dotnet_rpg.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
    }
}