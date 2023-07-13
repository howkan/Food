using Food.Models;
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
        public FoodContext _context;

        public FoodController(FoodContext context)
        {
            _context = context;
        }

        [HttpGet(Name ="GetFood")]
        public async Task<ActionResult<IEnumerable<Foods>>> GetFoods()
        {
            return await _context.Foods.ToListAsync(); 
        }
    }
}
