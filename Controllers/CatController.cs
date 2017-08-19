using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OpenShiftTest.Controllers
{
    public class CatController
    {
        [HttpGet("/cat")]
        public string Cat(string cat)
        {
            switch (cat)
            {
                case "bill":
                    return "Meow";
                case "steve":
                    return "Purr.";
                case "amit":
                    return "Fuck Off";
            }
            return String.Empty;
        }
    }
}
