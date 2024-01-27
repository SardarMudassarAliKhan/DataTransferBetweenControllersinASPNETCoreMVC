using DataTransferBetweenControllersinASPNETCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DataTransferBetweenControllersinASPNETCoreMVC.DatbaseContext
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}