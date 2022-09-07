using Formula1.API.Models.TeamLocation;

namespace Formula1.API.Models
{
    public class TeamsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public int NumberOfTeamLocations => TeamLocations.Count;

        public ICollection<TeamLocationDto> TeamLocations { get; set; }
            = new List<TeamLocationDto>();

    }
}
