namespace AlumnosApi.ModelosClaseObjetos
{
    public class Edificio: BaseEntity
    {
        public int CantidadDepartamentosTotal { get; set; }

        public int CantidadDepartamentosOcupados { get; set; }

        public int CantidadDepartamentosDisponible
        {
            get { return CantidadDepartamentosTotal - CantidadDepartamentosOcupados; }
        }

    }
}
