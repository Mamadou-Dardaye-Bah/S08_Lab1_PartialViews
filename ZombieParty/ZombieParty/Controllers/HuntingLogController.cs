using Microsoft.AspNetCore.Mvc;
using ZombieParty.Models;
using ZombieParty.Models.Data;

namespace ZombieParty.Controllers
{
    public class HuntingLogController : Controller
    {
        private ZombiePartyDbContext _baseDonnees { get; set; }

        public HuntingLogController(ZombiePartyDbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }
        public IActionResult Index()
        {
            List<HuntingLog> huntingLogs = _baseDonnees.HuntingLogs.ToList();
            return View(huntingLogs);
        }
        public IActionResult Upsert(int? id)
        {
            if (id == 0 || id == null)
                return View(new Weapon());
            else
                return View(_baseDonnees.HuntingLogs.Find(id));
        }
    }
}
