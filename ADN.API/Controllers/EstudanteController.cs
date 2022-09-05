using ADN.Domain.Domain;
using ADN.Domain.DTO.Estudante;
using ADN.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ADN.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudanteController : ControllerBase
    {
        private readonly IEstudanteService _service;

        public EstudanteController(IEstudanteService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Insert(EstudanteInsertDTO estudanteDTO)
        {
            await _service.Insert(estudanteDTO);
            return StatusCode(201);
        }
    }
}
