using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITLA.Infraestructured.Repositorio;

namespace ITLA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTarea()
        {
            var tarea = new TareaRepositorio().GetTarea();
            return Ok(tarea);
        }

    }
}
