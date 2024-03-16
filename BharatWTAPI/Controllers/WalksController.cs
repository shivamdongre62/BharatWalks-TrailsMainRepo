using AutoMapper;
using BharatWTAPI.Models.Domain;
using BharatWTAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BharatWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IWalksRepository walksRepository;
        public WalksController(IMapper mapper)
        {
            this.mapper = mapper;
            this.walksRepository = walksRepository;
        }

        [HttpPost] 
        public async Task<IActionResult> Create([FromBody] WalksDto.WalksRequestDto model)
        {
            try
            {
                var walks = mapper.Map<Walks>(model);
                await walksRepository.Create(walks);
                return Ok(walks); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
