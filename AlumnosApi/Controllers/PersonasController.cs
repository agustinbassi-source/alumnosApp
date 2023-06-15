using AlumnosApi.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlumnosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        [HttpGet]
        public List<Persona> ArbolFamiliar()
        {
            var inicioFamilia = new List<Persona>();

            var abuelo = new Persona { Nombre = "EL abuelo" };

            abuelo.Hijos = new List<Persona>();

            var hijo1 = new Persona { Nombre = "Hijo 1" };
            var hijo2 = new Persona { Nombre = "Hijo 2" };

            var nieto1 = new Persona { Nombre = "Nieto 1" };

            hijo1.Hijos = new List<Persona>();

            hijo1.Hijos.Add(nieto1);

            abuelo.Hijos.Add(hijo1);
            abuelo.Hijos.Add(hijo2);

            inicioFamilia.Add(abuelo);

            return inicioFamilia;

        }
    }
}
