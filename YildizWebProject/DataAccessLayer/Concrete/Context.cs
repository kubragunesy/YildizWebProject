using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        public DbSet <Business> Businesses { get; set; }
        public DbSet <Contact> Contacts { get; set; }
        public DbSet <Media> Medias { get; set; }
        public DbSet <Project> Projects { get; set; }
        public DbSet <Admin> Admins { get; set; }
        public DbSet <About> Abouts { get; set; }
        public DbSet <CompanyInfo> CompanyInfos { get; set; }
    }
}
