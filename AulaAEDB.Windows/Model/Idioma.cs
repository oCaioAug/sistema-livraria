using AulaAEDB.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB.Windows.Model
{
    public class Idioma
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static List<Idioma> ListaTodos()
        {
            //return (from p in DataHelper.ListaIdioma select p).ToList();
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "SELECT * FROM Idioma";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                List<Idioma> Retorno = new List<Idioma>();
                while (oDr.Read())
                {
                    Retorno.Add(new Idioma
                    {
                        Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                        Nome = oDr.GetString(oDr.GetOrdinal("Nome"))
                    });
                }
                oDr.Close();

                return Retorno;
            }
        }

        public static Idioma? Seleciona(int Id)
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"SELECT * FROM Idioma WHERE id={Id}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                Idioma? Retorno = null;
                while (oDr.Read())
                {
                    Retorno = new Idioma
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
                string sql = $"INSERT INTO Idioma (Nome) VALUES ('{this.Nome}')";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.ExecuteNonQuery();
            }
        }

        public void Alterar()
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"UPDATE Idioma SET Nome='{this.Nome}' WHERE id={this.Id}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"DELETE FROM Idioma WHERE id={this.Id}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.ExecuteNonQuery();
            }
        }
    }
}
