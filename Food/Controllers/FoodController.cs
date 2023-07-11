using Food.Context;
using Food.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace Food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        AplicationContext Db = new AplicationContext();

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Foods>>> Get()
        {
            return await Db.Food.ToListAsync();
        }



    }
}
