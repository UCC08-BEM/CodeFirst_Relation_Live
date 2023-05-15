using System.ComponentModel.DataAnnotations;

namespace CodeFirst_Relation_Live.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        // Burada da Product tablomun Category Tablusundan beslendiğini belirten tanımlar yapmam lazım

        public virtual Category Categories { get; set; }

        // Burada da Product tablomun Order tablosunu beslediğini belirten tanımlar yapmam lazım

        public ICollection<Order> Orders { get; set; }
    }
}
