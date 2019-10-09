using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ITBeep.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        : base("DefaultConnection")
        {
        }

        public DbSet<ITBeep.Data.Services.Services> Services { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}