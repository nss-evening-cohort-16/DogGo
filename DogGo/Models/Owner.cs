using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DogGo.Models
{
    public class Owner
    {
        public int Id { get; set; }
        
        [StringLength(10)]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }

        [DisplayName("Neighborhood ID")]
        [Range(2,5)]
        public int NeighborhoodId { get; set; }
        public Neighborhood Neighborhood { get; set; }
        public string Phone { get; set; }
        public List<Dog> Dogs { get; set; } = new List<Dog>();
    }
}
