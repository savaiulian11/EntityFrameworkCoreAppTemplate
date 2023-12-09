using dotNETCoreLearning.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotNETCoreLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private LibraryContext _ctx;
        public TestController(LibraryContext ctx) => _ctx = ctx;
        // GET: api/<TestController>
        [HttpGet]
        public ActionResult Get()
        {
            var items = _ctx.Loans.Where(u => u.NavCustomer.Id == 1).ToList();
            return StatusCode(200, items);
        }
    }
}
