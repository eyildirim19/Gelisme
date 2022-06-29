using Gelisme.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gelisme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        NorthwindContext dbContext = new NorthwindContext();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(dbContext.Categories.ToList());
        }

        [HttpPost]
        public IActionResult Post(Category model)
        {
            dbContext.Categories.Add(model);
            try
            {
                dbContext.SaveChanges();
                return Ok("İşlem Başarılı");
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
           
        }
    }
}