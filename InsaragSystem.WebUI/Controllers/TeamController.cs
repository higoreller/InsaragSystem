using InsaragSystem.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InsaragSystem.Dashboard.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var teams = await _teamService.GetTeams();
            return View(teams);
        }
    }
}
