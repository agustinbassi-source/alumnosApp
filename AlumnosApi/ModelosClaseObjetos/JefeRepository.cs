using AlumnosApi.ModelosClaseObjetos.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace AlumnosApi.ModelosClaseObjetos
{
    public class JefeRepository
    {
        private readonly string _cnnString;

        public void TestPropiedades()
        { 
        
            Edificio edificio = new Edificio();

            edificio.CantidadDepartamentosTotal = 100;
            edificio.CantidadDepartamentosOcupados = 60;


          

            
        
        
        }

        public JefeRepository(string cnn)
        {
            _cnnString = cnn;
        }


        public Jefe Get(int id)
        {
            Jefe elJefe;

            //  _cnnString 

            var resultado = CalculadoraHelper.Sumar(1, 3);

            elJefe = new Jefe();

            elJefe.Nombre = "Juan";

            return elJefe;



        }

        public void Create(Jefe elJefe)
        {
            elJefe.Nombre = "nuevo nombre";
        }
    }
}
