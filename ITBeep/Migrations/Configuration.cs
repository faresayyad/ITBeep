namespace ITBeep.Migrations
{
    using ITBeep.Data.Services;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ITBeep.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ITBeep.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Services.AddOrUpdate(r => r.Id, new Services()
            {
                ServiceName="Offer1"
            });

            context.Services.AddOrUpdate(r => r.Id, new Services()
            {
                ServiceName = "Offer2"
            });

            context.Services.AddOrUpdate(r => r.Id, new Services()
            {
                ServiceName = "Offer3"
            });
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
