using AutoMapper;
using BharatWTAPI.Data;
using BharatWTAPI.Models.Domain;
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
        private readonly IMapper mapper;
        public RegionsController(IRegionRepository regionRepository,IMapper mapper)
        {
            this._regionRepository = regionRepository;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var regions = await _regionRepository.GetAll();

            var regionsDto = mapper.Map<List<RegionDto>>(regions);
            
            return Ok(regionsDto); 
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
