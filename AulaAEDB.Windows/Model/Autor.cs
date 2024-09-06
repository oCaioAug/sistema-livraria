using AulaAEDB.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB.Windows.Model
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static List<Autor> ListaTodos()
        {
            //return (from p in DataHelper.ListaAutor select p).ToList();
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "SELECT * FROM Autor";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                List<Autor> Retorno = new List<Autor>();
                while (oDr.Read())
                {
                    Retorno.Add(new Autor
                    {
                        Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                        Nome = oDr.GetString(oDr.GetOrdinal("Nome"))
                    });
                }
                oDr.Close();

                return Retorno;
            }
        }

        public static Autor? Seleciona(int Id)
        {
            //return (from p in DataHelper.ListaAutor where p.Id == Id select p).FirstOrDefault();
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"SELECT * FROM Autor WHERE id={Id}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                Autor? Retorno = null;
                while (oDr.Read())
                {
                    Retorno = new Autor
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
            //Autor? oAutorSelecionado = Autor.Seleciona(this.Id);
            //if (oAutorSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no Autor {oAutorSelecionado.Id}");
            //}
            //else
            //{
            //    DataHelper.ListaAutor.Add(this);
            //}

            using (var ocn = DataHelper.Conexao())
            {
                string sql = "INSERT INTO Autor (Nome) VALUES (@Nome)";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@Nome", this.Nome);
                oCmd.ExecuteNonQuery();
            }
        }

        public static void Alterar(Autor oAutor)
        {
            //Autor? oAutorColecao = Autor.Seleciona(oAutor.Id);

            //if (oAutorColecao == null)
            //{
            //    throw new Exception($"O código informado não foi encontrado");
            //}
            //else
            //{
            //    oAutorColecao.Nome = oAutor.Nome;
            //}
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "UPDATE Autor SET Nome=@Nome WHERE id=@Id";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@Nome", oAutor.Nome);
                oCmd.Parameters.AddWithValue("@Id", oAutor.Id);
                oCmd.ExecuteNonQuery();
            }

        }

        public void Excluir(){
            //Autor? oAutorColecao = Autor.Seleciona(this.Id);

            //if (oAutorColecao == null)
            //{
            //    throw new Exception($"O código informado não foi encontrado");
            //}
            //else
            //{
            //    DataHelper.ListaAutor.Remove(oAutorColecao);
            //}

            using (var ocn = DataHelper.Conexao())
            {
                string sql = "DELETE FROM Autor WHERE id=@Id";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@Id", this.Id);
                oCmd.ExecuteNonQuery();
            }
        }
    }
}
