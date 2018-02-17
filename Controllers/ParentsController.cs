using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace netdbdemo.Controllers
{
    [Route("api/[controller]")]
    public class ParentsController : Controller
    {

        [HttpGet("[action]")]
        public IEnumerable<Models.Parent> Parents()
        {

            using(var db = new DemoDBContext()) {
            
                return db.Parents;
            } 
        }
    }
}
