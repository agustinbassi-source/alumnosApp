using AlumnosApi.Modelos;
using System.Data.SqlClient;
using Dapper;

namespace AlumnosApi.Repository
{
    public class CursoRepository
    {

        string cs = @"Server=.;Database=Alumnos;User Id=sa;Password=polo;";

        public List<Curso> ObtenerCursos()
        {
            var lista = new List<Curso>();

            var con = new SqlConnection(cs);

            string query = $@"SELECT [Id]
      ,[Nombre]
      
       FROM [dbo].[Curso] order by Nombre ";

            con.Open();

            lista = con.Query<Curso>(query).ToList();

            con.Close();

            return lista;
        }

        public void CrearCurso(Curso curso)

        {
            var con = new SqlConnection(cs);
            con.Open();

            var insertCommnad = $@"INSERT INTO [Alumno]
           ([Nombre]
           ,[Apellido]
           ,[CursoId]
           ,[Email])
     VALUES
           (@Nombre
           ,@Apellido
           ,@CursoId
           ,@Email)";

            con.ExecuteScalar(insertCommnad, curso);
        }

        public void EliminarCurso(int id)
        {
            var con = new SqlConnection(cs);
            con.Open();

            var commnand = $@"DELETE FROM [dbo].[Curso]  WHERE id = " + id;

            con.ExecuteScalar(commnand);
        }

        public void ActualizarCurso(Curso curso)
        {
            var con = new SqlConnection(cs);
            con.Open();

            var insertCommnad = $@"
            UPDATE [dbo].[Curso]
               SET [Nombre] = @Nombre
                  
                        WHERE Id = @Id";

            con.ExecuteScalar(insertCommnad, curso);
        }

       
    }
}
