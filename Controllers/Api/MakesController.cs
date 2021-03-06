using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.Resources;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers.Api
{
    public class MakesController : Controller
    {
        private VegaDbContext _context;
        private IMapper _mapper;

        public MakesController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            
        }

        [HttpGet("/api/makes")]
        public async Task< IEnumerable<MakeResource> > GetMakes()
        {
          var makes = await _context.Makes.Include(m => m.Models).ToListAsync();

          return _mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}