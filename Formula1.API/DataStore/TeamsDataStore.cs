using Formula1.API.Models;
using Formula1.API.Models.TeamLocation;

namespace Formula1.API.DataStore
{
    public class TeamsDataStore
    {
        public List<TeamsDto> Teams { get; set; }

        public static TeamsDataStore GetData { get; } = new TeamsDataStore();

        public TeamsDataStore()
        {
            Teams = new List<TeamsDto>()
            {
                new TeamsDto
                {
                    Id = 1,
                    Name = "Mercedes",
                    Description = "Merc Racing Team",
                    TeamLocations = new List<TeamLocationDto>()
                    {
                        new TeamLocationDto(){
                            Id = 1,
                            Location = "Germany",
                            Description = "Location is in Germany"
                        },
                        new TeamLocationDto(){
                            Id = 2,
                            Location = "Germany1",
                            Description = "Location is in Germany1" },
                    }
                },
                new TeamsDto
                {
                    Id = 2,
                    Name = "Red Bull",
                    Description = "Red Bull Racing Team",
                    TeamLocations = new List<TeamLocationDto>()
                    {
                        new TeamLocationDto(){
                            Id = 3,
                            Location = "Austria",
                            Description = "Location is in Austria"
                        },
                    }
                },
                new TeamsDto
                {
                    Id = 3,
                    Name = "Ferrari",
                    Description = "Ferrari Racing Team",
                    TeamLocations = new List<TeamLocationDto>()
                    {
                        new TeamLocationDto(){
                            Id = 4,
                            Location = "Ferrari",
                            Description = "Location is in Ferrari"
                        },
                    }
                }
            };
        }
    }
}