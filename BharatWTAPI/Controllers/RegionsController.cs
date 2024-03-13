using BharatWTAPI.Data;
using BharatWTAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BharatWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IRegionRepository _regionRepository;
        public RegionsController(IRegionRepository regionRepository)
        {
            this._regionRepository = regionRepository; 
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var regions = await _regionRepository.GetAll();
            return Ok(regions); 
        }

        //[HttpGet]
        //[Route("{id:Guid}")]
        //public async Task<IActionResult>GetById([FromRoute] Guid id)
        //{
        //    var regiondata = await _context.Regions.FirstOrDefaultAsync(x => x.Id == id);
        //    return Ok(regiondata);
        //}

    }
}
