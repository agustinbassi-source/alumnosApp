using AlumnosApi.Modelos;
using AlumnosApi.Repository;

namespace AlumnosApi.Business
{
    public class EntregaBusiness
    {
        EntregaRepository cursoRepository = new EntregaRepository();

        public Entrega ObtenerEntrega(int id)
        {
            var entrega = new Entrega();

            entrega.AlumnoId = "Argentina";

            return entrega;
        }

        public List<Entrega> ObtenerEntrega()
        {
            var lista = new List<Entrega>();



            lista = EntregaRepository.ObtenerEntre0ga();

            return lista;
        }

        public void CrearEntrega(Entrega entrega)
        {

            EntregaRepository.CrearEntrega(entrega);
        }

        public void EliminarEntrega(int id)
        {
            EntregaRepository.EliminarEntrega(id);
        }
        public void ActualizarEntrega(Entrega entrega)
        {
           EntregaRepository.ActualizarEntrega(entrega);
        }
    }
}
