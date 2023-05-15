using System.ComponentModel.DataAnnotations;

namespace CodeFirst_Relation_Live.Models
{
    public class Department
    {
        [Key]
        public int DepartmanID { get; set; }

        public string DepartmentName { get; set; }

        public ICollection<Personel> Personels { get; set; }

    }
}
