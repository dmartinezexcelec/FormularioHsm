using Microsoft.EntityFrameworkCore;


namespace Hsm
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor que recibe las opciones para la base de datos
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet que representa la tabla HsmEntities en la base de datos
        public DbSet<HsmModel> Hsm { get; set; }

        internal string? HSM ()
        {
            throw new NotImplementedException();
        }

        internal string? HsmModel()
        {
            throw new NotImplementedException();
        }
    }

    public class HsmModel
    {
    }
}
