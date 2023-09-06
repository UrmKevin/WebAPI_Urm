using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Urm.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PrimitiividController : ControllerBase
    {

        // GET: primitiivid/hello-world
        [HttpGet("hello-world")]
        public string HelloWorld()
        {
            return "Hello world at " + DateTime.Now;
        }

        // GET: primitiivid/hello-variable/mari
        [HttpGet("hello-variable/{nimi}")]
        public string HelloVariable(string nimi)
        {
            return "Hello " + nimi;
        }

        // GET: primitiivid/add/5/6
        [HttpGet("add/{nr1}/{nr2}")]
        public int AddNumbers(int nr1, int nr2)
        {
            return nr1 + nr2;
        }
        // GET: primitiivid/multiply/5/6
        [HttpGet("multiply/{nr1}/{nr2}")]
        public int Multiply(int nr1, int nr2)
        {
            return nr1 * nr2;
        }
        // GET: primitiivid/do-logs/5
        [HttpGet("do-logs/{arv}")]
        public void DoLogs(int arv)
        {
            for (int i = 0; i < arv; i++)
            {
                Console.WriteLine("See on logi nr " + i);
            }
        }
        // GET: primitiivid/ghoul
        [HttpGet("ghoul")]
        public void Ghoul()
        {
            for (int i = 1006; i > 0; i--)
            {
                i = i - 6;
                Console.WriteLine(i + " - 7");
            }
        }
        // GET: primitiivid/random/1/6
        [HttpGet("random/{min}/{max}")]
        public int Random(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
        // GET: primitiivid/age/30/8/2005
        [HttpGet("age/{birthday}")]
        public string Age(DateTime birthday)
        {
            DateTime birthDate = birthday;
            DateTime currentDate = DateTime.Now;

            TimeSpan age = currentDate - birthDate;
            int years = age.Days / 365;

            return $"Currently you are {years} years old";
            //return age.ToString();
        }
    }
}
