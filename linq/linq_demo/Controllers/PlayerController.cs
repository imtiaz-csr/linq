using linq_demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace linq_demo.Controllers
{
    public class PlayerController : Controller
    {
        #region Config
        private PlayerDbContext _context;
        public PlayerController(PlayerDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail()
        {
            var playerList = await _context.players.ToListAsync();
            //playerList.Sort();
            //var countPlayers = playerList.Count;
            return View(playerList);
        }
        #endregion
    }
}
