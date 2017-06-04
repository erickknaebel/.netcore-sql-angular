using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DealerApp.Models;
using DealerApp.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AutoMapper;
using dotnetcore_sql_angular.Models;
using dotnetcore_sql_angular.Resources;

namespace dotnetcore_sql_angular.Controllers
{
   public class FeaturesController : Controller
  {
    private readonly DealerDbContext context;
    private readonly IMapper mapper;
    public FeaturesController(DealerDbContext context, IMapper mapper)
    {
      this.mapper = mapper;
      this.context = context;
    }

    [HttpGet("/api/features")]
    public async Task<IEnumerable<FeatureResource>> GetFeatures()
    {
      var features = await context.Features.ToListAsync();
      
      return mapper.Map<List<Feature>, List<FeatureResource>>(features); 
    }
  }
}