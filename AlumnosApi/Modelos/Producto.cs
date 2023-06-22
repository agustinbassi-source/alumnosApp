namespace AlumnosApi.Modelos
{
    public class Producto: ModeloBase
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int MarcaId { get; set; }
    }
}
