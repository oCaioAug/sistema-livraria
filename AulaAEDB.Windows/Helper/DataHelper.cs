using AulaAEDB.Windows.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AulaAEDB.Windows.Helper
{
    public static class DataHelper
    {
        public static  List<Genero> ListaGenero { get; set; }

        public static List<Autor> ListaAutor { get; set; }

        public static SqlConnection Conexao()
        {
            //return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aluno\source\repos\AulaAEDB\AulaAEDB.Windows\AulaAEDB.Windows\AulaAEDB.mdf;Integrated Security=True");
            SqlConnection oCn = new SqlConnection("Data Source=localhost;Initial Catalog=Livraria;User ID=sa;Password=#sqlServerdocker;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            oCn.Open();
            
            return oCn;
        }
    }
}
