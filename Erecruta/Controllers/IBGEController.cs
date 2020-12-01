using Erecruta.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Controllers
{
    [Route("[controller]")]
    public class IBGEController
    {
        private IIBGEService _service;

        public IBGEController(IIBGEService service) => _service = service;

        [HttpGet("listarEstado")]
        public IActionResult ListarEstado()
        {
            try
            {
                var resultado = _service.ListarEstado();
                return new ObjectResult(resultado) { StatusCode = StatusCodes.Status200OK };
            }
            catch (Exception)
            {
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }

        [HttpGet("listarCidade")]
        public IActionResult ListarCidade([FromQuery] long estadoId)
        {
            try
            {
                var resultado = _service.ListarCidade(estadoId);
                return new ObjectResult(resultado) { StatusCode = StatusCodes.Status200OK };
            }
            catch (Exception)
            {
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
