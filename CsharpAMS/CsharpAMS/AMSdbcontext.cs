using System;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAMS
{
    public class AMSdbcontext : DbContext
    {
        private string _connectionString;
        private string _assemblyName;
        public DbSet<user> users { get; set; }


        public AMSdbcontext()
        {
            _connectionString = "Server =USER-PC\\SQLEXPRESS; Database = csharpb10; User Id = csharpb10; Password = 999111bdctg;";
            _assemblyName = Assembly.GetExecutingAssembly().FullName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString,
                    m => m.MigrationsAssembly(_assemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<user>().ToTable("users");

        }
    }
}
