using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebPersonal.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilPersonalController : ControllerBase
    {
        [HttpGet("{id}")]
        public string Get(int id) {
            return id switch {
                1 => "Alan",
                2 => "Patrick",
                _ => throw new NotSupportedException("El id no es valido")
            };
        }

        [HttpPost]
        public string Post(PerfilPersonalDto perfilPersonal) {
            return perfilPersonal.Nombre;
        }
    }

    public class PerfilPersonalDto {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
    }
}
