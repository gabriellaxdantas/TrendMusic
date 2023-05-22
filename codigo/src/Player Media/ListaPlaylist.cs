using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Media
{
    internal class ListaPlaylist
    {
        private celula primeiro, ultimo;

        public ListaPlaylist()
        {
            primeiro = new celula();
            ultimo = primeiro;
        }
        public int tamanho()
        {
            int aux = 0;
            for (celula i = primeiro; i != ultimo; i = i.apontador)
            {
                aux++;
            }
            return aux;
        }

        public void acrescentar(string num)
        {
            ultimo.apontador = new celula(num);
            ultimo = ultimo.apontador;
        }
        public void acrescentar(string num, int posicao)
        {
                celula aux = primeiro;
                for (int i = 0; i < posicao; i++)
                {
                    aux = aux.apontador;
                }
                celula aux2 = new celula(num);
                aux2.apontador = aux.apontador;
                aux.apontador = aux2;
                aux = null;
                aux2 = null;
            }
    }
}
