using AvatarWebApi.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace AvatarWebApi
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Clan> Clan { get; set; }
        public DbSet<Avatar> Avatar { get; set; }
        public DbSet<Habilidades> Habilidades { get; set;}
        public DbSet<Especiales> Especiales { get; set; }
        public DbSet<Guardian> Guardian { get; set; }
        public DbSet<Elemento> Elemento { get; set; }
    }
}
