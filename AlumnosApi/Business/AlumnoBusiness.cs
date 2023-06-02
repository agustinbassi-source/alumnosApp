using AlumnosApi.Modelos;
using AlumnosApi.Repository;

namespace AlumnosApi.Business 
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
            if (alumno.Apellido.Trim()==string.Empty)
            {

                throw new Exception("EL apellido no puede estar vacio");

            }
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
