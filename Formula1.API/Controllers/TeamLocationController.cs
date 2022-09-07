using Formula1.API.DataStore;
using Formula1.API.Models.TeamLocation;
using Microsoft.AspNetCore.Mvc;

namespace Formula1.API.Controllers
{
    [Route("api/teams/{teamId}/location")]
    [ApiController]
    public class TeamLocationController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<TeamLocationDto>> GetTeamLocations(int teamId)
        {
            var teams = TeamsDataStore.GetData.Teams.FirstOrDefault(t => t.Id == teamId);

            if (teams == null)
            {
                return NotFound();
            }

            return Ok(teams.TeamLocations);
        }

        [HttpGet("{locationId}")]
        public ActionResult<IEnumerable<TeamLocationDto>> GetTeamLocation(int teamId, int locationId)
        {
            var teams = TeamsDataStore.GetData.Teams.FirstOrDefault(t => t.Id == teamId);

            if (teams == null)
            {
                return NotFound();
            }

            var teamLocation = TeamsDataStore.GetData.Teams.FirstOrDefault(c => c.Id == locationId);

            if (teamLocation == null)
            {
                return NotFound();
            }

            return Ok(teamLocation);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(TeamLocationDto))]

        public ActionResult<TeamLocationDto> CreateTeamLocation(
            int teamId, TeamLocationCreationDto teamLocationCreationDto)
        {

            var team = TeamsDataStore.GetData.Teams.FirstOrDefault(t => t.Id == teamId);
            if (team == null)
            {
                return NotFound();
            }

            var maxTeamLocationsId = TeamsDataStore.GetData.Teams.SelectMany(
                t => t.TeamLocations).Max(t => t.Id);

            // will be using automapper instead of this
            var newTeamLocation = new TeamLocationDto()
            {
                Id = maxTeamLocationsId,
                Description = teamLocationCreationDto.Description,
                Location = teamLocationCreationDto.Location

            };

            team.TeamLocations.Add(newTeamLocation);

            return newTeamLocation;
        }
    }
}