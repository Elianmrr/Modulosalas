using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulosalas.Modulo
{
    public class SalaService
    {
        private string connectionString = "Server=Elian_Rodriguez;Database=ReservaSalas;Integrated Security=True;";

       
        public List<Sala> ObtenerSalas()
        {
            List<Sala> salas = new List<Sala>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Salas";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Sala sala = new Sala
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        NombreSala = row["NombreSala"].ToString(),
                        CapacidadMax = Convert.ToInt32(row["CapacidadMax"]),
                        Descripcion = row["Descripcion"].ToString()
                    };
                    salas.Add(sala);
                }
            }
            return salas;
        }

       
        public void AgregarSala(Sala sala)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Salas (NombreSala, CapacidadMax, Descripcion) VALUES (@NombreSala, @CapacidadMax, @Descripcion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreSala", sala.NombreSala);
                cmd.Parameters.AddWithValue("@CapacidadMax", sala.CapacidadMax);
                cmd.Parameters.AddWithValue("@Descripcion", sala.Descripcion);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

       
        public void ActualizarSala(Sala sala)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Salas SET NombreSala = @NombreSala, CapacidadMax = @CapacidadMax, Descripcion = @Descripcion WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", sala.ID);
                cmd.Parameters.AddWithValue("@NombreSala", sala.NombreSala);
                cmd.Parameters.AddWithValue("@CapacidadMax", sala.CapacidadMax);
                cmd.Parameters.AddWithValue("@Descripcion", sala.Descripcion);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

       
        public void EliminarSala(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Salas WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }

}
