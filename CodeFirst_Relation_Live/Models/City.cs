using System.ComponentModel.DataAnnotations;

namespace CodeFirst_Relation_Live.Models
{
    public class City
    {
        [Key]
        public int CityID { get; set; }

        public int CityName { get; set; }

        public ICollection<Personel> Personels { get; set; }
    }
}
