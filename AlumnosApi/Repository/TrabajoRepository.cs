﻿using AlumnosApi.Modelos;
using System.Data.SqlClient;
using Dapper;

namespace AlumnosApi.Repository
{
    public class TrabajoRepository
    {

        string cs = @"Server=.;Database=Alumnos;User Id=sa;Password=polo;";

        public List<Trabajo> ObtenerTrabajos()
        {
            var lista = new List<Trabajo>();

            var con = new SqlConnection(cs);

            string query = $@"SELECT [Id]
      ,[CursoId]
      
       FROM [dbo].[Trabajo] order by CursoId ";

            con.Open();

            lista = con.Query<Trabajo>(query).ToList();

            con.Close();

            return lista;
        }

        public void CrearTrabajo(Trabajo trabajo)

        {
            var con = new SqlConnection(cs);
            con.Open();

            var insertCommnad = $@"INSERT INTO [Alumno]
           ([CursoId]
           ,[Entrega]
           )
     VALUES
           (@CursoId
           ,@Entrega
           )";

            con.ExecuteScalar(insertCommnad, trabajo);
        }

        public void EliminarTrabajo(int id)
        {
            var con = new SqlConnection(cs);
            con.Open();

            var commnand = $@"DELETE FROM [dbo].[Trabajo]  WHERE id = " + id;

            con.ExecuteScalar(commnand);
        }

        public void ActualizarTrabajo(Trabajo trabajo)
        {
            var con = new SqlConnection(cs);
            con.Open();

            var insertCommnad = $@"
            UPDATE [dbo].[Trabajo]
               SET [CursoId] = @CursoId
                  
                        WHERE Id = @Id";

            con.ExecuteScalar(insertCommnad, trabajo);
        }
    }
}
