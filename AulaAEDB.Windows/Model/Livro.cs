using AulaAEDB.Windows.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB.Windows.Model
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string ISBN { get; set; }
        public int QtdPaginas { get; set; }
        public int Edicao { get; set; }
        public Autor Autor { get; set; }
        public Editora Editora { get; set; }
        public Genero Genero { get; set; }
        public Idioma Idioma { get; set; }

        public static List<Livro> ListaTodos()
        {
            //return (from p in DataHelper.ListaLivro select p).ToList();
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "SELECT * FROM Livro";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                List<Livro> Retorno = new List<Livro>();
                while (oDr.Read())
                {
                    Retorno.Add(new Livro
                    {
                        Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                        Nome = oDr.GetString(oDr.GetOrdinal("Nome")),
                        Descricao = oDr.GetString(oDr.GetOrdinal("Descricao")),
                        ISBN = oDr.GetString(oDr.GetOrdinal("ISBN")),
                        QtdPaginas = oDr.GetInt32(oDr.GetOrdinal("qtdPaginas")),
                        Edicao = oDr.GetInt32(oDr.GetOrdinal("Edicao")),
                        Autor = Autor.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idAutor"))),
                        Editora = Editora.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idEditora"))),
                        Genero = Genero.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idGenero"))),
                        Idioma = Idioma.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idIdioma")))
                    });
                }
                oDr.Close();

                return Retorno;
            }
        }

        public static Livro? Seleciona(int Id)
        {
            //return (from p in DataHelper.ListaLivro where p.Id == Id select p).FirstOrDefault();
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"SELECT * FROM Livro WHERE id={Id}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                Livro? Retorno = null;
                while (oDr.Read())
                {
                    Retorno = new Livro
                    {
                        Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                        Nome = oDr.GetString(oDr.GetOrdinal("Nome")),
                        Descricao = oDr.GetString(oDr.GetOrdinal("Descricao")),
                        ISBN = oDr.GetString(oDr.GetOrdinal("ISBN")),
                        Autor = Autor.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idAutor"))),
                        Editora = Editora.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idEditora"))),
                        Genero = Genero.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idGenero"))),
                        Idioma = Idioma.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idIdioma")))
                    };
                }
                oDr.Close();

                return Retorno;
            }
        }

        public static List<Livro> SelecionaLivroPorAutor(int idAutor)
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"SELECT * FROM Livro WHERE idAutor={idAutor}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                List<Livro> Retorno = new List<Livro>();

                while(oDr.Read())
                {
                    Retorno.Add(new Livro
                    {
                        Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                        Nome = oDr.GetString(oDr.GetOrdinal("Nome")),
                        Descricao = oDr.GetString(oDr.GetOrdinal("Descricao")),
                        ISBN = oDr.GetString(oDr.GetOrdinal("ISBN")),
                        QtdPaginas = oDr.GetInt32(oDr.GetOrdinal("qtdPaginas")),
                        Edicao = oDr.GetInt32(oDr.GetOrdinal("Edicao")),
                        Autor = Autor.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idAutor"))),
                        Editora = Editora.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idEditora"))),
                        Genero = Genero.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idGenero"))),
                        Idioma = Idioma.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idIdioma")))
                    });
                }
                oDr.Close();

                return Retorno;
            }

        }

        public static List<Livro> SelecionaLivroPorEditora(int idEditora)
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"SELECT * FROM Livro WHERE idEditora={idEditora}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                List<Livro> Retorno = new List<Livro>();

                while (oDr.Read())
                {
                    Retorno.Add(new Livro
                    {
                        Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                        Nome = oDr.GetString(oDr.GetOrdinal("Nome")),
                        Descricao = oDr.GetString(oDr.GetOrdinal("Descricao")),
                        ISBN = oDr.GetString(oDr.GetOrdinal("ISBN")),
                        QtdPaginas = oDr.GetInt32(oDr.GetOrdinal("qtdPaginas")),
                        Edicao = oDr.GetInt32(oDr.GetOrdinal("Edicao")),
                        Autor = Autor.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idAutor"))),
                        Editora = Editora.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idEditora"))),
                        Genero = Genero.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idGenero"))),
                        Idioma = Idioma.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idIdioma")))
                    });
                }
                oDr.Close();

                return Retorno;
            }

        }
        
        public static List<Livro> SelecionaLivroPorGenero(int idGenero)
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"SELECT * FROM Livro WHERE idGenero={idGenero}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                List<Livro> Retorno = new List<Livro>();

                while (oDr.Read())
                {
                    Retorno.Add(new Livro
                    {
                        Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                        Nome = oDr.GetString(oDr.GetOrdinal("Nome")),
                        Descricao = oDr.GetString(oDr.GetOrdinal("Descricao")),
                        ISBN = oDr.GetString(oDr.GetOrdinal("ISBN")),
                        QtdPaginas = oDr.GetInt32(oDr.GetOrdinal("qtdPaginas")),
                        Edicao = oDr.GetInt32(oDr.GetOrdinal("Edicao")),
                        Autor = Autor.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idAutor"))),
                        Editora = Editora.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idEditora"))),
                        Genero = Genero.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idGenero"))),
                        Idioma = Idioma.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idIdioma")))
                    });
                }
                oDr.Close();

                return Retorno;
            }
        }

        public static List<Livro> SelecionaLivroPorIdioma(int id)
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "SELECT * FROM Livro WHERE idIdioma=@idIdioma";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@idIdioma", id);
                SqlDataReader oDr = oCmd.ExecuteReader();

                List<Livro> Retorno = new List<Livro>();

                while(oDr.Read())
                {
                    Retorno.Add(new Livro
                    {
                        Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                        Nome = oDr.GetString(oDr.GetOrdinal("Nome")),
                        Descricao = oDr.GetString(oDr.GetOrdinal("Descricao")),
                        ISBN = oDr.GetString(oDr.GetOrdinal("ISBN")),
                        QtdPaginas = oDr.GetInt32(oDr.GetOrdinal("qtdPaginas")),
                        Edicao = oDr.GetInt32(oDr.GetOrdinal("Edicao")),
                        Autor = Autor.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idAutor"))),
                        Editora = Editora.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idEditora"))),
                        Genero = Genero.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idGenero"))),
                        Idioma = Idioma.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idIdioma")))
                    });
                }
                oDr.Close();

                return Retorno;
            }
        }

        public void Incluir()
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "INSERT INTO Livro (Nome, Descricao, ISBN, qtdPaginas, Edicao, idAutor, idEditora, idGenero, idIdioma) VALUES (@Nome, @Descricao, @ISBN, @qtdPaginas, @Edicao, @idAutor, @idEditora, @idGenero, @idIdioma)";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@Nome", this.Nome);
                oCmd.Parameters.AddWithValue("@Descricao", this.Descricao);
                oCmd.Parameters.AddWithValue("@ISBN", this.ISBN);
                oCmd.Parameters.AddWithValue("@qtdPaginas", this.QtdPaginas);
                oCmd.Parameters.AddWithValue("@Edicao", this.Edicao);
                oCmd.Parameters.AddWithValue("@idAutor", this.Autor.Id);
                oCmd.Parameters.AddWithValue("@idEditora", this.Editora.Id);
                oCmd.Parameters.AddWithValue("@idGenero", this.Genero.Id);
                oCmd.Parameters.AddWithValue("@idIdioma", this.Idioma.Id);
                oCmd.ExecuteNonQuery();
            }
        }

        public static void Alterar(Livro oLivro)
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "UPDATE Livro SET Nome=@Nome, Descricao=@Descricao, ISBN=@ISBN, qtdPaginas=@qtdPaginas, Edicao=@Edicao, idAutor=@idAutor, idEditora=@idEditora, idGenero=@idGenero, idIdioma=@idIdioma WHERE id=@id";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@Nome", oLivro.Nome);
                oCmd.Parameters.AddWithValue("@Descricao", oLivro.Descricao);
                oCmd.Parameters.AddWithValue("@ISBN", oLivro.ISBN);
                oCmd.Parameters.AddWithValue("@qtdPaginas", oLivro.QtdPaginas);
                oCmd.Parameters.AddWithValue("@Edicao", oLivro.Edicao);
                oCmd.Parameters.AddWithValue("@idAutor", oLivro.Autor.Id);
                oCmd.Parameters.AddWithValue("@idEditora", oLivro.Editora.Id);
                oCmd.Parameters.AddWithValue("@idGenero", oLivro.Genero.Id);
                oCmd.Parameters.AddWithValue("@idIdioma", oLivro.Idioma.Id);
                oCmd.Parameters.AddWithValue("@id", oLivro.Id);
                oCmd.ExecuteNonQuery();
            }
        }

        public static void Excluir(int Id)
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"DELETE FROM Livro WHERE id={Id}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.ExecuteNonQuery();
            }
        }


    }
}
