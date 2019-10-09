using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ITBeepAngular.Data
{
    public class ApplicationDbContext : DbContext
    {
        public IConfiguration Configuration { get; }
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }


        public DbSet<ITBeepAngular.Data.Services.Services> services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<ITBeepAngular.Data.Services.Services>().HasData(
            //    new ITBeepAngular.Data.Services.Services { Id=1,ServiceName = "Offer 1" },
            //    new ITBeepAngular.Data.Services.Services { Id=2,ServiceName = "Offer 2" },
            //    new ITBeepAngular.Data.Services.Services { Id=3,ServiceName = "Offer " });
        }

    }
}
