namespace sampleAPI.Models
{
    using System.Data.Entity;
    public class ApplicationContext : DbContext

    {
        public ApplicationContext()
            : base("hrRecruiter")
        {

        }

        public DbSet<Admin> Admins { get; set; }
    }
}