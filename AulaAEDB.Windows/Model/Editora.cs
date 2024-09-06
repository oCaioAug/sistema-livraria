using AulaAEDB.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;

namespace AulaAEDB.Windows.Models
{
    public class Editora
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static List<Editora> ListaTodos()
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "SELECT * FROM Editora";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                List<Editora> Retorno = new List<Editora>();
                while (oDr.Read())
                {
                    Retorno.Add(new Editora
                    {
                        Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                        Nome = oDr.GetString(oDr.GetOrdinal("Nome"))
                    });
                }
                oDr.Close();

                return Retorno;
            }
        }

        public static Editora? Seleciona(int Id)
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"SELECT * FROM Editora WHERE id={Id}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                Editora Retorno = null;
                while (oDr.Read())
                {
                    Retorno = new Editora
                    {
                        Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                        Nome = oDr.GetString(oDr.GetOrdinal("Nome"))
                    };
                }
                oDr.Close();

                return Retorno;
            }
        }

        public void Incluir()
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "INSERT INTO Editora (Nome) VALUES (@Nome)";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@Nome", this.Nome);
                oCmd.ExecuteNonQuery();
            }
        }

        public void Alterar()
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "UPDATE Editora SET Nome=@Nome WHERE id=@id";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@Nome", this.Nome);
                oCmd.Parameters.AddWithValue("@id", this.Id);
                oCmd.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "DELETE FROM Editora WHERE id=@id";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@id", this.Id);
                oCmd.ExecuteNonQuery();
            }
        }
    }
}
