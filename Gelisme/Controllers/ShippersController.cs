using Gelisme.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gelisme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippersController : ControllerBase
    {
        NorthwindContext db = new NorthwindContext();


        [HttpGet]
        public IActionResult Get() {

            return Ok(db.Shippers.ToList());
        }

        [HttpPost]
        public IActionResult Post(Shipper model)
        {
            db.Shippers.Add(model);
            db.SaveChanges();
            return Ok(true);
        }
    }
}
