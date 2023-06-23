namespace AlumnosApi.ModelosClaseObjetos
{
    public class Edificio: BaseEntity
    {
        public int CantidadDepartamentosTotal { get; set; }

        public int CantidadDepartamentosOcupados { get; set; }

        private int cantDepar;

        public int CantidadDepartamentosDisponible
        {
            get { return cantDepar; }
            //set { cantDepar = value; }
        }

    }
}
