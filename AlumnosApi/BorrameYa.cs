using AlumnosApi.Modelos;

namespace AlumnosApi
{
    public class BorrameYa
    {
        public string HacerAlgo()
        {
            return "hola mundo";
        }

        public void CrearAlumno(Alumno alumno)
        { 
        // codigo comentado.,...
        }

        public int Otra(string nombnreDeAlgo)
        {
            int elDato = 0;

            if (nombnreDeAlgo == "Juan")
            {
                elDato = 22;
            }
            else
            {
                elDato = 33;
            }

            return elDato;
        }

        public int Edad { get; set; }
        public string Nombre { get; set; }
    }

    
}
