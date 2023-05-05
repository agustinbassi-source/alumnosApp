using AlumnosApi.Modelos;

namespace AlumnosApi
{
    public class AlumnoBusiness
    {

        AlumnoRepository alumnoRepository = new AlumnoRepository();

        public Alumno ObtenerAlumno(int id)
        {
            var alumno = new Alumno();

            alumno.Nombre = "Argentina";

            return alumno;
        }

        public List<Alumno> ObtenerAlumnos()
        {
            var lista = new List<Alumno>();



            lista = alumnoRepository.ObtenerAlumnos();

            return lista;
        }

        public void CrearAlumno(Alumno alumno)
        {
            alumnoRepository.CrearAlumno(alumno);
        }

        public void EliminarAlumno(int id)
        {
            alumnoRepository.EliminarAlumno(id);
        }
        public void ActualizarPais(Alumno alumno)
        {
            alumnoRepository.ActualizarAlumno(alumno);
        }
    }
}
