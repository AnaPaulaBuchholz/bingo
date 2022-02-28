using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Numeros
    {
        List<int> listaDeNumerosASeremSorteados = new List<int>();
        List<int> listaDeNumerosJaSorteados = new List<int>();

        public Numeros()
        {
            for (var i = 1; i < 101; i++)
            { 
                listaDeNumerosASeremSorteados.Add(i);
            }
        }

        public List<int> Sortear()
        { 
            var random = new Random();
            var numeroSorteado = random.Next(1, 100);

            listaDeNumerosASeremSorteados.Remove(numeroSorteado);

            listaDeNumerosJaSorteados.Add(numeroSorteado);

            var numeroExiste = Pesquisar(listaDeNumerosJaSorteados, numeroSorteado);
            //listaDeNumerosJaSorteados.Any(n => n == numeroSorteado);

            return listaDeNumerosJaSorteados;
        }

        public bool Pesquisar(List<int> lista, int numero) 
        {
            foreach (var n in lista)
            {
                if (n == numero)
                    return true;
            }

            return false;
        }
    }
}
