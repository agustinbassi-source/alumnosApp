using AlumnosApi.Modelos;
using Dapper;
using System.Data.SqlClient;

namespace AlumnosApi.Repository
{
    public class AlumnoRepository
    {

        string cs = @"Server=DESKTOP-MP45HVJ\SQLEXPRESS;Database=Alumnos;User Id=sa;Password=jairo2006;";

        public List<Alumno> ObtenerAlumnos()
        {
            var lista = new List<Alumno>();

            var con = new SqlConnection(cs);

            string query = $@"SELECT [Id]
      ,[Nombre]
      ,[Apellido]
      ,[CursoId]
      ,[Email]  
       FROM [dbo].[Alumno] order by Nombre ";

            con.Open();

            lista = con.Query<Alumno>(query).ToList();

            con.Close();

            return lista;
        }

        public void CrearAlumno(Alumno alumno)

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

            con.ExecuteScalar(insertCommnad, alumno);
        }

        public void EliminarAlumno(int id)
        {
            var con = new SqlConnection(cs);
            con.Open();

            var commnand = $@"DELETE FROM [dbo].[Alumno]  WHERE id = " + id;

            con.ExecuteScalar(commnand);
        }

        public void ActualizarAlumno(Alumno alumno)
        {
            var con = new SqlConnection(cs);
            con.Open();

            var insertCommnad = $@"
            UPDATE [dbo].[Alumno]
               SET [Nombre] = @Nombre
                  ,[Apellido] = @Apellido
                        ,[CursoId] = @CursoId
                              ,[Email] = @Email
                        WHERE Id = @Id";

            con.ExecuteScalar(insertCommnad, alumno);
        }
    }
}
