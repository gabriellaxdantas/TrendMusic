using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Media
{
    class Elemento
    {
        private string valor;
        private Elemento esquerda, direita;

        public Elemento(string atual)
        {
            esquerda = null;
            direita = null;
            this.Valor = atual;
        }

        public string Valor
        {
            set { this.valor = value; }
            get { return this.valor; }
        }
        public Elemento Esquerda
        {
            get { return this.esquerda; }
            set { this.esquerda = value; }
        }
        public Elemento Direita
        {
            get { return this.direita; }
            set { this.direita = value; }
        }
    }
}