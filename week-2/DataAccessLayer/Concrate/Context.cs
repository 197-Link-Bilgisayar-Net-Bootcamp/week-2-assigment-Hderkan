using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
    public  class Context : DbContext
    {
        //ms sql bağlantısı optionsBuilder ile yaptım. sql server için nuget mannagerdan son sürüm entityframe workcore paketleri indirdim. (sqlserver,tools vb..)

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LR34O1R\\SQLEXPRESS; database=HDerkangDb; integrated security=true;");

        }

        // context kullanılabilmesi için DbSet yapısı oluşturdum.
        public DbSet<Product> Products { get; set; }


    }
}
