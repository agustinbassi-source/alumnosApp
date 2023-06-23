using AlumnosApi.ModelosClaseObjetos.Models;

namespace AlumnosApi.ModelosClaseObjetos
{
    public class JefeRepository
    {
        private readonly string _cnnString;

        public JefeRepository(string cnn)
        {
            _cnnString = cnn;
        }


        public Jefe Get(int id)
        {
            Jefe elJefe;

            // hacer algo cnnString

            elJefe = new Jefe();

            elJefe.Nombre = "Juan";

            return elJefe;



        }

        public void Create(Jefe elJefe)
        {
            elJefe.Nombre = "nuevo nombre";
        }
    }
}
