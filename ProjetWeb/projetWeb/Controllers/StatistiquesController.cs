using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projetWeb.Data;

namespace projetWeb.Controllers
{
    public class StatistiquesController : Controller
    {
        private readonly LigueNationalHockeyContext _context;

        public StatistiquesController(LigueNationalHockeyContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var stats = await _context.VwStatistiquesJoueursParEquipes.ToListAsync();
            return View(stats);
        }
    }
}