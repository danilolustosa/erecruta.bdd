using Erecruta.Domain;
using Erecruta.Interface;
using Erecruta.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Controllers
{
    [Route("[controller]")]
    public class CandidatoController : ControllerBase
    {
        private ICandidatoService _candidatoService;

        public CandidatoController(ICandidatoService candidatoService) => _candidatoService = candidatoService;

        [HttpPost("incluir")]
        public IActionResult Incluir([FromBody] Candidato candidato)
        {
            try
            {
                var resultado = _candidatoService.Incluir(candidato);
                return new ObjectResult(resultado) { StatusCode = resultado.StatusCode };
            }
            catch (Exception)
            {
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }

        [HttpPut("alterar")]
        public IActionResult Alterar([FromBody] Candidato candidato)
        {
            try
            {
                var resultado = _candidatoService.Alterar(candidato);
                return new ObjectResult(resultado) { StatusCode = resultado.StatusCode };
            }
            catch (Exception)
            {
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }

        [HttpGet("listar")]
        public IActionResult Listar([FromQuery] int oportunidadeId)
        {
            try
            {
                var resultado = _candidatoService.Listar(oportunidadeId);
                return new ObjectResult(resultado) { StatusCode = resultado.StatusCode };
            }
            catch (Exception)
            {
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }

        [HttpGet("obter")]
        public IActionResult Obter([FromQuery] int id)
        {
            try
            {
                var resultado = _candidatoService.Obter(id);
                return new ObjectResult(resultado) { StatusCode = resultado.StatusCode };
            }
            catch (Exception)
            {
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
