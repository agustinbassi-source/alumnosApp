using AlumnosApi.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlumnosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        [HttpGet]
        public Marca Get()
        {
            Marca marca = new Marca();

            marca.Nombre = "Fiat";

            marca.Productos = new List<Producto>();

            Producto producto1 = new Producto();
            Producto producto2 = new Producto();

            producto1.Nombre = "Uno";
            producto2.Precio = 11111;

            producto2.Nombre = "Punto";
            producto2.Precio = 222222;

            marca.Productos.Add(producto1);
            marca.Productos.Add(producto2);


            return marca;
        }
    }
}
