using DotNetFloripa.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFloripa.Data
{
    class DotNetFloripaContext : DbContext
    {
        public DotNetFloripaContext() : base("DotNetFloripa"){}

        public DbSet<Company> Companies { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Talk> Talks { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SetupConventions(modelBuilder);
        }

        private static void SetupConventions(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
