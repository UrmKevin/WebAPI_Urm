using Microsoft.AspNetCore.Mvc;
using WebAPI_Urm.Models;

namespace WebAPI_Urm.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TootedController : ControllerBase
    {
        private static List<Toode> _tooted = new()
        {
            new Toode(1,"Koola", 1.5, true),
            new Toode(2,"Fanta", 1.0, false),
            new Toode(3,"Sprite", 1.7, true),
            new Toode(4,"Vichy", 2.0, true),
            new Toode(5,"Vitamin well", 2.5, true)
        };

        // GET https://localhost:4444/tooted
        [HttpGet]
        public List<Toode> Get()
        {
            return _tooted;
        }

        // DELETE https://localhost:4444/tooted/kustuta/0
        [HttpDelete("kustuta/{index}")]
        public List<Toode> Delete(int index)
        {
            _tooted.RemoveAt(index);
            return _tooted;
        }

        [HttpDelete("kustuta2/{index}")]
        public string Delete2(int index)
        {
            _tooted.RemoveAt(index);
            return "Kustutatud!";
        }

        // POST https://localhost:4444/tooted/lisa/1/Coca/1.5/true
        [HttpPost("lisa/{id}/{nimi}/{hind}/{aktiivne}")]
        public List<Toode> Add(int id, string nimi, double hind, bool aktiivne)
        {
            Toode toode = new Toode(id, nimi, hind, aktiivne);
            _tooted.Add(toode);
            return _tooted;
        }

        [HttpPost("lisa2")]
        public List<Toode> Add2(int id, string nimi, double hind, bool aktiivne)
        {
            Toode toode = new Toode(id, nimi, hind, aktiivne);
            _tooted.Add(toode);
            return _tooted;
        }

        // PATCH https://localhost:4444/tooted/hind-dollaritesse/1.5
        [HttpPatch("hind-dollaritesse/{kurss}")]
        public List<Toode> UpdatePrices(double kurss)
        {
            for (int i = 0; i < _tooted.Count; i++)
            {
                _tooted[i].Price = _tooted[i].Price * kurss;
            }
            return _tooted;
        }
    }
    //[Route("api/[controller]")]
    //[ApiController]
    //public class TootedController : ControllerBase
    //{
    //    private static List<Toode> _tooted = new List<Toode>
    //    {
    //        new Toode(1,"Koola", 1.5, true),
    //        new Toode(2,"Fanta", 1.0, false),
    //        new Toode(3,"Sprite", 1.7, true),
    //        new Toode(4,"Vichy", 2.0, true),
    //        new Toode(5,"Vitamin well", 2.5, true)
    //    };


    //    // https://localhost:7052/tooted
    //    [HttpGet]
    //    public List<Toode> Get()
    //    {
    //        return _tooted;
    //    }

    //    [HttpGet("kustuta/{index}")]
    //    public List<Toode> Delete(int index)
    //    {
    //        _tooted.RemoveAt(index);
    //        return _tooted;
    //    }

    //    [HttpGet("kustuta2/{index}")]
    //    public Toode Delete2(int index)
    //    {
    //        Toode toode = _tooted[index];
    //        _tooted.RemoveAt(index);
    //        return toode;
    //    }

    //    [HttpGet("lisa/{id}/{nimi}/{hind}/{aktiivne}")]
    //    public List<Toode> Add(int id, string nimi, double hind, bool aktiivne)
    //    {
    //        Toode toode = new Toode(id, nimi, hind, aktiivne);
    //        _tooted.Add(toode);
    //        return _tooted;
    //    }

    //    [HttpGet("lisa")] // GET /tooted/lisa?id=1&nimi=Koola&hind=1.5&aktiivne=true
    //    public List<Toode> Add2([FromQuery] int id, [FromQuery] string nimi, [FromQuery] double hind, [FromQuery] bool aktiivne)
    //    {
    //        Toode toode = new Toode(id, nimi, hind, aktiivne);
    //        _tooted.Add(toode);
    //        return _tooted;
    //    }

    //    [HttpGet("hind-dollaritesse/{kurss}")] // GET /tooted/hind-dollaritesse/1.5
    //    public List<Toode> Dollaritesse(double kurss)
    //    {
    //        for (int i = 0; i < _tooted.Count; i++)
    //        {
    //            _tooted[i].Price = _tooted[i].Price * kurss;
    //        }
    //        return _tooted;
    //    }

    //    // või foreachina:

    //    [HttpGet("hind-dollaritesse2/{kurss}")] // GET /tooted/hind-dollaritesse2/1.5
    //    public List<Toode> Dollaritesse2(double kurss)
    //    {
    //        foreach (var t in _tooted)
    //        {
    //            t.Price = t.Price * kurss;
    //        }

    //        return _tooted;
    //    }

    //    // GET /tooted/kustuta-koik
    //    [HttpGet("kustuta-koik")]
    //    public string Kustutakoik()
    //    {
    //        _tooted.Clear();
    //        return "Kõik on kustatud";
    //    }

    //    // GET /tooted/aktiivus-false
    //    [HttpGet("aktiivus-false")]
    //    public List<Toode> Aktiivusfalse()
    //    {
    //        foreach (var item in _tooted)
    //        {
    //            item.IsActive = false;
    //        }
    //        return _tooted;
    //    }

    //    // GET /tooted/toode-id
    //    [HttpGet("toode-id/{id}")]
    //    public Toode ToodeID(int id)
    //    {
    //        Toode toode = null;
    //        foreach (var item in _tooted)
    //        {
    //            if (id == item.Id)
    //            {
    //                toode = _tooted[id];
    //            }
    //        }
    //        return toode;
    //    }

    //    // GET /tooted/suur-hind
    //    [HttpGet("suur-hind")]
    //    public Toode ToodeID()
    //    {
    //        Toode toode = null;
    //        double max = 0;
    //        foreach (var item in _tooted)
    //        {
    //            if (max < item.Price)
    //            {
    //                max = item.Price;
    //                toode = item;
    //            }
    //        }
    //        return toode;
    //    }
    //}
}
