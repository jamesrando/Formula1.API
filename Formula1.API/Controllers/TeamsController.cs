using Formula1.API.DataStore;
using Formula1.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Formula1.API.Controllers
{
    [ApiController]
    [Route("api/teams")]
    public class TeamsController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<TeamsDto>> GetTeams()
        {
            return Ok(TeamsDataStore.GetData.Teams);
        }

        [HttpGet("{id}")]
        public ActionResult<TeamsDto> GetTeams(int id)
        {
            var teamToReturn = TeamsDataStore.GetData.Teams.FirstOrDefault(t => t.Id == id);

            if (teamToReturn == null)
            {
                return NotFound();
            }

            return Ok(teamToReturn);

        }
    }
}
