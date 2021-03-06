using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vegas.Controllers.Resources;
using Vegas.Models;
using Vegas.Persistence;

namespace Vegas.Controllers
{
    public class MakesController : Controller
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;
        public MakesController(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
           var makes = await context.Makes.Include(m => m.Models).ToListAsync();
           return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }

    }
}