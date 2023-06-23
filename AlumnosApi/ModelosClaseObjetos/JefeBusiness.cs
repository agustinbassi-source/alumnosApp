namespace AlumnosApi.ModelosClaseObjetos
{
    public class JefeBusiness
    {
        private readonly JefeRepository _repository;

        public JefeBusiness(string asd)
        {
            _repository = new JefeRepository(asd);

        }

        public Jefe Get(int id)
        {
            return _repository.Get(id);
        }
    }
}
