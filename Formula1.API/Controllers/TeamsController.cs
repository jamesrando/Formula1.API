using Formula1.API.DataStore;
using Formula1.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Formula1.API.Controllers
{
    [ApiController]
    [Route("api/teams")]
    public class TeamsController : Controller
    {
        private readonly TeamsDataStore _teamsDataStore;

        public TeamsController(TeamsDataStore teamsDataStore)
        {
            _teamsDataStore = teamsDataStore ?? throw new ArgumentNullException(nameof(teamsDataStore));

        }

        [HttpGet]
        public ActionResult<IEnumerable<TeamsDto>> GetTeams()
        {
            return Ok(_teamsDataStore.Teams);
        }

        [HttpGet("{id}")]
        public ActionResult<TeamsDto> GetTeams(int id)
        {
            var teamToReturn = _teamsDataStore.Teams.FirstOrDefault(t => t.Id == id);

            if (teamToReturn == null)
            {
                return NotFound();
            }

            return Ok(teamToReturn);

        }
    }
}
