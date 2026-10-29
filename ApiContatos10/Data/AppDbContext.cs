using ApiContatos10.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiContatos10.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
