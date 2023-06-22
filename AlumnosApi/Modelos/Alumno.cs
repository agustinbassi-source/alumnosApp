namespace AlumnosApi.Modelos
{
    public class Alumno : ModeloBase
    {
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public int CursoId { get; set; }

        public string? Email { get; set; }

      


    }
}
