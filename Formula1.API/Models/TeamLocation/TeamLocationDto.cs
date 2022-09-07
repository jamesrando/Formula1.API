namespace Formula1.API.Models.TeamLocation
{
    public class TeamLocationDto
    {
        public int Id { get; set; }
        public string Location { get; set; } = string.Empty;
        public string? Description { get; set; }

    }
}
