using AulaAEDB.Windows.Helper;
using AulaAEDB.Windows.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB.Windows.Mock
{
    public class MockAutor
    {
        public static void CarregaAutor()
        {
            List<Autor> oLista = new List<Autor>();

            for (int i = 1; i <= 10; i++)
            {
                Autor oAutor = new Autor
                {
                    Id = i,
                    Nome = $"Autor {i}"
                };

                oLista.Add(oAutor);
            }

            DataHelper.ListaAutor = oLista;
        }
    }
}
