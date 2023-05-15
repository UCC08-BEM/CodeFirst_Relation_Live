using System.ComponentModel.DataAnnotations;

namespace CodeFirst_Relation_Live.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        //Besleyen tablolar...

        public virtual Personel Personels { get; set; }

        public virtual Product Products { get; set; }

    }
}
