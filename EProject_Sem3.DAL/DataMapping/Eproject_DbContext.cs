using EProject_Sem3.DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProject_Sem3.DAL
{
    public class Eproject_DbContext : DbContext
    {
        public Eproject_DbContext() : base("name=EProject_Sem3")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Eproject_DbContext, Configuration>("EProject_Sem3"));
        }
        public virtual DbSet<AdminLogin> AdminLogins { get; set; }
        public virtual DbSet<CompanyDetails> CompanyDetails { get; set; }
        public virtual DbSet<Policies> Policies { get; set; }
    }
}
