using AlumnosApi.Modelos;
using AlumnosApi.Repository;

namespace AlumnosApi.Business
{
    public class CursoBusiness 
    {

        CursoRepository cursoRepository = new CursoRepository();

        public Curso ObtenerCurso(int id)
        {
            var curso = new Curso();

            curso.Nombre = "Argentina";

            return curso;
        }

        public List<Curso> ObtenerCursos()
        {
            var lista = new List<Curso>();



            lista = cursoRepository.ObtenerCursos();

            return lista;
        }

        public void CrearCurso(Curso curso)
        {
           
            cursoRepository.CrearCurso(curso);
        }

        public void EliminarCurso(int id)
        {
            cursoRepository.EliminarCurso(id);
        }
        public void ActualizarCurso(Curso curso)
        {
            cursoRepository.ActualizarCurso(curso);
        }

    }
}
