namespace AlumnosApi.Modelos
{
    public class Persona
    {
        public string Nombre  { get; set; }
        public List<Persona> Hijos { get; set; } = new List<Persona>();
    }
}
