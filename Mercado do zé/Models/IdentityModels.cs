using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Mercado_do_zé.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        //!TODO

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}