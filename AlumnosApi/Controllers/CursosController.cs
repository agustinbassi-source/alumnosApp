using AlumnosApi.Business;
using AlumnosApi.Modelos;
using Microsoft.AspNetCore.Mvc;


namespace AlumnosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController
    {


            [HttpGet]
            public List<Curso> Cursos()
            {
                var business = new CursoBusiness();

                var misCursos = business.ObtenerCursos();

                return misCursos;
            }

            [HttpGet("{id}")]
            public Curso Cursos(int id)
            {
                var business = new CursoBusiness();

                var misCursos = business.ObtenerCursos();

                var curso = misCursos.Where(x => x.Id == id).FirstOrDefault();

                return curso;
            }

            [HttpPost]
            public void CrearCurso(Curso curso)
            {
                var business = new CursoBusiness();

                business.CrearCurso(curso);


            }

            [HttpDelete("{id}")]
            public void EliminarCurso(int id)
            {
                var business = new CursoBusiness();

                business.EliminarCurso(id);


            }

            [HttpPut]
            public void ActualizarCurso(Curso curso)
            {
                var business = new CursoBusiness();

                business.ActualizarCurso(curso);


            }
       
    }
}
