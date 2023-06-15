using AlumnosApi.Business;
using AlumnosApi.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace AlumnosApi.Controllers
{
   

        [Route("api/[controller]")]
        [ApiController]
        public class EntregasController : Controller
        {




            [HttpGet]
            public List<Entrega> Entrega()
            {
                var business = new EntregaBusiness();

                var misEntregas = business.ObtenerEntregas();

                return misEntregas;

            }

            [HttpGet("{id}")]
            public Entrega Entregas(int id)
            {
                var business = new EntregaBusiness();

                var misEntregas = business.ObtenerEntregas();

                var entrega = misEntregas.Where(x => x.Id == id).FirstOrDefault();

                return entrega;
            }

            [HttpPost]
            public void CrearEntrega(Entrega entrega)
            {
                var business = new TrabajoBusiness();

                business.CrearEntrega(entrega);


            }

            [HttpDelete("{id}")]
            public void EliminarEntrega(int id)
            {
                var business = new EntregaBusiness();

                business.EliminarEntrega(id);


            }

            [HttpPut]
            public void ActualizarEntrega(Entrega entrega)
            {
                var business = new EntregaBusiness();

                business.CrearEntrega(entrega);


            }

        }
    
