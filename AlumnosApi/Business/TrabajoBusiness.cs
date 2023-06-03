using AlumnosApi.Modelos;
using AlumnosApi.Repository;

namespace AlumnosApi.Business
{
    public class TrabajoBusiness
    {

        TrabajoRepository trabajoRepository = new TrabajoRepository();

        public Trabajo ObtenerTrabajo(int id)
        {
            var trabajo = new Trabajo();

            trabajo.Descripcion = "Argentina";

            return trabajo;
        }

        public List<Trabajo> ObtenerTrabajos()
        {
            var lista = new List<Trabajo>();



            lista = trabajoRepository.ObtenerTrabajos();

            return lista;
        }

        public void CrearTrabajo(Trabajo trabajo)
        {
            if (trabajo.Descripcion.Trim() == string.Empty)


                throw new Exception("La descipcion no puede estar vacia");


            trabajoRepository.CrearTrabajo(trabajo);
        }

    }

    public void EliminarTrabajo(int id)
    {
        trabajoRepository.EliminarTrabajo(id);
    }
    public void ActualizarCurso(Trabajo trabajo)
    {
        trabajoRepository.ActualizarTrabajo(trabajo);
    }
}
