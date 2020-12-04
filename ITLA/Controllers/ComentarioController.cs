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
    public class ComentarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetComentario()
        {
            var comentario = new ComentarioRepositorio().GetComentario();
            return Ok(comentario);
        }

    }
}
