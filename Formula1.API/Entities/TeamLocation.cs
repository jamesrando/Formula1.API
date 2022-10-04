using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formula1.API.Entities
{
    public class TeamLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Location { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }


        [ForeignKey("TeamsId")]
        public Teams? Teams { get; set; }

        public int TeamsId { get; set; }


        public TeamLocation(string location)
        {
            Location = location;
        }
    }
}
