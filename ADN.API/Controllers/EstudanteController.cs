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
        private readonly ILogger<EstudanteController> _log;

        public EstudanteController(IEstudanteService service, 
                                   ILogger<EstudanteController> log)
        {
            _service = service;
            _log = log;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _log.LogInformation("Iniciando GetAll");
            return Ok(await _service.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Insert(EstudanteInsertDTO estudanteDTO)
        {
            try
            {
                _log.LogInformation("Salvando estudante");
                await _service.Insert(estudanteDTO);
                return StatusCode(201); 
            }
            catch (Exception ex)
            {
                _log.LogError(ex, "Erro ao salvar estudante");
                return StatusCode(500, "Erro ao salvar estudante, contate o administrativo");
            }
        }
    }
}
