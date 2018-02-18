using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace netdbdemo.Controllers
{
    [Route("api/[controller]")]
    public class ParentsController : Controller
    {

        [HttpGet("[action]")]
        public IEnumerable<Models.Parent> Parents()
        {

            var db = new Models.DemoDBContext();
            
            return db.Parents; 
        }
    }
}
