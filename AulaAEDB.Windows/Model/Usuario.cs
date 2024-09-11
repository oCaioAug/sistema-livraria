using AulaAEDB.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB.Windows.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public static List<Usuario> ListaTodos()
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "SELECT * FROM Usuario";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                List<Usuario> Retorno = new List<Usuario>();                
                while (oDr.Read())
                {
                    Retorno.Add(new Usuario
                    {
                        Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                        Nome = oDr.GetString(oDr.GetOrdinal("Nome")),
                        Email = oDr.GetString(oDr.GetOrdinal("Email")),
                        Senha = oDr.GetString(oDr.GetOrdinal("Senha"))
                    });
                }
                oDr.Close();

                return Retorno;
            }
        }

        public static Usuario? Seleciona(int Id)
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"SELECT * FROM Usuario WHERE id={Id}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                Usuario? Retorno = null;
                while (oDr.Read())
                {
                    Retorno = new Usuario
                    {
                        Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                        Nome = oDr.GetString(oDr.GetOrdinal("Nome")),
                        Email = oDr.GetString(oDr.GetOrdinal("Email")),
                        Senha = oDr.GetString(oDr.GetOrdinal("Senha"))
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
                string sql = "INSERT INTO Usuario (Nome, Email, Senha) VALUES (@Nome, @Email, @Senha)";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@Nome", this.Nome);
                oCmd.Parameters.AddWithValue("@Email", this.Email);
                oCmd.Parameters.AddWithValue("@Senha", this.Senha);
                oCmd.ExecuteNonQuery();
            }
        }

        public void Alterar()
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "UPDATE Usuario SET Nome=@Nome, Email=@Email, Senha=@Senha WHERE id=@id";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@Nome", this.Nome);
                oCmd.Parameters.AddWithValue("@Email", this.Email);
                oCmd.Parameters.AddWithValue("@Senha", this.Senha);
                oCmd.Parameters.AddWithValue("@id", this.Id);
                oCmd.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "DELETE FROM Usuario WHERE id=@id";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@id", this.Id);
                oCmd.ExecuteNonQuery();
            }
        }
    }
}
