using AlumnosApi.Modelos;
using System.Data.SqlClient;
using Dapper;

namespace AlumnosApi.Repository
{
    public class EntregaRepository
    {
        string cs = @"Server=.;Database=Alumnos;User Id=sa;Password=polo;";

        public List<Entrega> ObtenerEntregas()
        {
            var lista = new List<Entrega>();

            var con = new SqlConnection(cs);

            string query = $@"SELECT [Id]
      ,[AlumnoId]
      
       FROM [dbo].[Curso] order by Nombre ";

            con.Open();

            lista = con.Query<Entrega>(query).ToList();

            con.Close();

            return lista;
        }

        public void CrearEntrega(Entrega entrega)

        {
            var con = new SqlConnection(cs);
            con.Open();

            var insertCommnad = $@"INSERT INTO [Alumno]
           ([TrabajoId]
           ,[AlumnoId]
           ,[Nota]
           )
     VALUES
           (@TrabajoId
           ,@AlumnoId
           ,@Nota
           )";

            con.ExecuteScalar(insertCommnad, entrega);
        }

        public void EliminarEntrega(int id)
        {
            var con = new SqlConnection(cs);
            con.Open();

            var commnand = $@"DELETE FROM [dbo].[Curso]  WHERE id = " + id;

            con.ExecuteScalar(commnand);
        }

        public void ActualizarEntrega(Entrega entrega)
        {
            var con = new SqlConnection(cs);
            con.Open();

            var insertCommnad = $@"
            UPDATE [dbo].[Curso]
               SET [Nombre] = @Nombre
                  
                        WHERE Id = @Id";

            con.ExecuteScalar(insertCommnad, entrega);
        }

        public void ObtenerEntrega(int id)
        {
            var con = new SqlConnection(cs);
            con.Open();

            var commnand = $@"GET FROM [dbo].[Curso]  WHERE id = " + id;

            con.ExecuteScalar(commnand);
        }
    }
}
