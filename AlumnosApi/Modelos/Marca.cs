namespace AlumnosApi.Modelos
{
    public class Marca : ModeloBase
    {
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
