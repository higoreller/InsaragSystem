using InsaragSystem.Application.DTOs.TeamDTOs;
using InsaragSystem.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InsaragSystem.WebUI.Controllers
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create (TeamDTO teamDto)
        {
            if(ModelState.IsValid)
            {
                await _teamService.AddTeam(teamDto);
                return RedirectToAction(nameof(Index));
            }

            return View(); 
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var teamDto = await _teamService.GetTeamById(id.Value);
            if(teamDto == null) return NotFound();
            return View(teamDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TeamDTO teamDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _teamService.UpdateTeam(teamDto);
                }
                catch (Exception)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }

            return View(teamDto);
        }
    }
}
