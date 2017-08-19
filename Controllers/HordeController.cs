using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OpenShiftTest.Controllers
{
    public class HordeController : Controller
    {
        private static Dictionary<string, string> _Cats = new Dictionary<string, string>();
        [HttpGet("horde/add/{cat}")]
        public string Add(string cat, string sound)
        {
            _Cats[cat] = sound;
            return string.Format("{0} Added to horde!", cat);
        }

        [HttpGet("horde/{cat}")]
        public string Get(string cat)
        {
            if (!_Cats.ContainsKey(cat))
            {
                return "Cat not found";
            }
            return _Cats[cat];
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}