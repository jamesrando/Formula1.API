using System.ComponentModel.DataAnnotations;

namespace Formula1.API.Models.TeamLocation
{
    public class TeamLocationPutDto
    {
        [Required]
        [MaxLength(50)]
        public string Location { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? Description { get; set; }
    }
}
