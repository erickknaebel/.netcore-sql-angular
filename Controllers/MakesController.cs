using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DealerApp.Models;
using DealerApp.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AutoMapper;

namespace dotnetcore_sql_angular.Controllers
{
    public class MakesController : Controller
    {
        private readonly DealerDbContext context;
        
        public IMapper Mapper { get; }

        public MakesController(DealerDbContext context, IMapper mapper)
        {
            this.Mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Resources.MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();

            return Mapper.Map<List<Make>, List<Resources.MakeResource>>(makes);
        }
    }
}