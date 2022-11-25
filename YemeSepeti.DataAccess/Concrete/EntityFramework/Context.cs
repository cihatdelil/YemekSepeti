using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSepeti.Entities.Concrete;

namespace YemeSepeti.DataAccess.Concrete.EntityFramework
{
    public class Context : DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Common> commons { get; set; }
    }
}
