using AlumnosApi.Business;
using AlumnosApi.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace AlumnosApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : Controller
    {

        [HttpGet]
        public List<Alumno> Alumnos()
        {
            var business = new AlumnoBusiness();

            var misAlumnos = business.ObtenerAlumnos();

            return misAlumnos;
        }

        [HttpGet("{id}")]
        public Alumno Alumnos(int id)
        {
            var business = new AlumnoBusiness();

            var misAlumnos = business.ObtenerAlumnos();

            var alumno = misAlumnos.Where(x => x.Id == id).FirstOrDefault();

            return alumno;
        }

        [HttpPost]
        public void CrearAlumno(Alumno alumno)
        {
            var business = new AlumnoBusiness();

            business.CrearAlumno(alumno);


        }

        [HttpDelete("{id}")]
        public void EliminarAlumno(int id)
        {
            var business = new AlumnoBusiness();

            business.EliminarAlumno(id);


        }

        [HttpPut]
        public void ActualizarAlumno(Alumno alumno)
        {
            var business = new AlumnoBusiness();

            business.ActualizarPais(alumno);


        }
    }
}
