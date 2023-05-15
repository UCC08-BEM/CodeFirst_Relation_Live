using Microsoft.EntityFrameworkCore;

namespace CodeFirst_Relation_Live.Models
{
    public class CFRelationContext : DbContext
    {
        public CFRelationContext()
        {
            
        }

        public CFRelationContext(DbContextOptions<CFRelationContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Category> Categories { get; set; } // Category sınıfından Categories isimli bir tabloyu ifade ediyor
        public virtual DbSet<Product> Products { get; set; } // Category sınıfından Categories isimli bir tabloyu ifade ediyor
        public virtual DbSet<Order> Orders { get; set; } // Category sınıfından Categories isimli bir tabloyu ifade ediyor
        public virtual DbSet<Personel> Personels { get; set; } // Category sınıfından Categories isimli bir tabloyu ifade ediyor
        public virtual DbSet<Department> Departments { get; set; } // Category sınıfından Categories isimli bir tabloyu ifade ediyor

        public virtual DbSet<City> Cities { get; set; }



    }
}
