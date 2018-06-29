using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recettes.DTO;

namespace Recettes.DAL
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        {
            Database.SetInitializer<Context>(new ContextInitializer());
        }

        public DbSet<Recette> Recettes { get; set; }

        public class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
        {
            protected override void Seed(Context context)
            {
                base.Seed(context);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());
        }
    }
}
