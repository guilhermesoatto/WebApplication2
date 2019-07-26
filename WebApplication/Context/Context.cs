using Microsoft.EntityFrameworkCore;
using WebApplication.Data.Models;

namespace WebApplication.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Player> PlayerDB { get; set; }
    }
}