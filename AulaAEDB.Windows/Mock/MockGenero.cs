using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaAEDB.Windows.Model;
using AulaAEDB.Windows.Helper;

namespace AulaAEDB.Windows.Mock
{
    public class MockGenero
    {
        public static void CarregaGenero()
        {
            List<Genero> oLista = new List<Genero>();

            for (int i = 1; i <= 10; i++)
            {
                //Genero oGenero = new Genero();
                //oGenero.Id = i;
                //oGenero.Nome = "Gênero " + i;
                //oLista.Add(oGenero);

                Genero oGenero = new Genero
                {
                    Id = i,
                    Nome = $"Gênero {i}"
                };

                oLista.Add(oGenero);
            }

            DataHelper.ListaGenero = oLista;
        }
    }
}
