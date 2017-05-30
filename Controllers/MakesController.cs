using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DealerApp.Models;
using DealerApp.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace dotnetcore_sql_angular.Controllers
{
    public class MakesController : Controller
    {
        private readonly DealerDbContext context;

        public MakesController(DealerDbContext context)
        {
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes() 
        {
            return await context.Makes.Include(m => m.Models).ToListAsync();
        }
    }
}