using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIGITALMENU.MODEL
{
    public class MigrationContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =LAPTOP-30KT0O04\SQLEXPRESS; Database = NS.RestroMenu;Trusted_Connection=True;");
        }
    }
}
