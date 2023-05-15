using System.ComponentModel.DataAnnotations;

namespace CodeFirst_Relation_Live.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }

        public string Name { get; set; }

        public virtual Department Departments { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
