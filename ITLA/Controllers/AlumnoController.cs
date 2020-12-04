using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITLA.Infraestructured.Repositorio;


namespace ITLA.Api.Controllers
{
    public class AlumnoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAlumno()
        {
            var alumno = new AlumnoRepositorio().GetAlumno();
            return Ok(alumno);
        }

    }


}