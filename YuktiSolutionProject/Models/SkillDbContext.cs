using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace YuktiSolutionProject.Models
{
    public class SkillDbContext: DbContext
    {
        public DbSet<Interview> interviews { get; set; }
        public DbSet<SkillGroup> SkillGroups { get; set; }

        public SkillDbContext()
        {
            Database.SetInitializer<SkillDbContext>(new DropCreateDatabaseIfModelChanges<SkillDbContext>());
        }
       
    }
}