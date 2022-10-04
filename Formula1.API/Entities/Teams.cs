using Formula1.API.Models.TeamLocation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formula1.API.Entities
{
    public class Teams
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }


        public ICollection<TeamLocationDto> TeamLocations { get; set; }
            = new List<TeamLocationDto>();

        public Teams(string name)
        {
            Name = name;
        }
    }
}
