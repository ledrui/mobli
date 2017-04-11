using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers.Api
{
    public class MakesController : Controller
    {
        private VegaDbContext _context;

        public MakesController(VegaDbContext context)
        {
            _context = context;
            
        }

        [HttpGet("/api/makes")]
        public async Task< IEnumerable<Make> > GetMakes()
        {
           return await _context.Makes.Include(m => m.Models).ToListAsync();
        }
    }
}