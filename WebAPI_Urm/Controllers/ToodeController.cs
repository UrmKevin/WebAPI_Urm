using Microsoft.AspNetCore.Mvc;
using WebAPI_Urm.Models;

namespace WebAPI_Urm.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ToodeController : ControllerBase
    {
        private static Toode _toode = new Toode(1, "Koola", 1.5, true);

        // GET: toode
        [HttpGet]
        public Toode GetToode()
        {
            return _toode;
        }

        // GET: toode/suurenda-hinda
        [HttpGet("suurenda-hinda")]
        public Toode SuurendaHinda()
        {
            _toode.Price = Math.Round(_toode.Price * 1.1, 3);
            return _toode;
        }

        // GET: toode/muuda-aktiivus
        [HttpGet("muuda-aktiivus")]
        public Toode Muudaaktiivus()
        {
            _toode.IsActive = !_toode.IsActive;
            return _toode;
        }

        // GET: toode/muuda-nimetus/baklozan
        [HttpGet("muuda-nimetus/{nimetus}")]
        public Toode Muudanimetus(string nimetus)
        {
            _toode.Name = nimetus;
            return _toode;
        }

        // GET: toode/muuda-hinda/2.4
        [HttpGet("muuda-hinda/{hind}")]
        public Toode MuudaHinda(double hind)
        {
            _toode.Price = Math.Round(hind, 3);
            return _toode;
        }
    }
}
