using CrudAsp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CrudAsp.Context
{
    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
