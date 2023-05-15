using System.ComponentModel.DataAnnotations;

namespace CodeFirst_Relation_Live.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        // Category tablosu Product tablosunu besleyen durumunda.

        public ICollection<Product> Products { get; set; }

    }
}
