using Formula1.API.Models;
using System.Net.NetworkInformation;

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
                new TeamsDto { Id = 1, Name = "Mercedes", Description = "Merc Racing Team" },
                new TeamsDto { Id = 2, Name = "Red Bull", Description = "Red Bull Racing Team" },
                new TeamsDto { Id = 3, Name = "Ferrari", Description = "Ferrari Racing Team" },
            };
        }
    }
}