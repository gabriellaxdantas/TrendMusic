using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Player_Media
{
    class Arvore
    {
        Elemento raiz;
        public Arvore()
        {
            this.raiz = null;
        }

        public void Inserir(string x)
        { // "X" é o valor passado pela chamada do método
            Elemento novo = new Elemento(x);
            if (raiz == null)
            {
                this.raiz = novo;
            }
            else
            {
                Elemento atual = this.raiz;
                while (true)
                {
                    if (novo.Valor.CompareTo(atual.Valor) == -1) // Esquerda
                    {
                        if (atual.Esquerda != null)
                        {
                            atual = atual.Esquerda;
                        }
                        else
                        {
                            atual.Esquerda = novo;
                            break;
                        }
                    }
                    else // Direita
                    {
                        if (atual.Direita != null)
                        {
                            atual = atual.Direita;
                        }
                        else
                        {
                            atual.Direita = novo;
                            break;
                        }
                    }
                }
            }
        }

        public int Search(string x)
        {
            int cont = 1;
            Elemento atual = this.raiz;
            while (atual != null)
            {
                if (atual.Valor == x)
                {
                    cont = 0;
                    return cont;
                }

                if (atual.Esquerda != null)
                {
                    // Esquerda
                    if (atual.Esquerda.Valor == x)
                    {
                        return cont;
                    }
                    else
                        cont++;
                    atual = atual.Esquerda;
                }
                else if (atual.Direita != null)
                {
                    // Direita
                    if (atual.Direita != null)
                    {
                        if (atual.Direita.Valor == x)
                        {
                            return cont;
                        }
                        else
                            cont++;
                        atual = atual.Direita;
                    }
                }
                else
                    return -1;
            }
            return -1;
        }

        public Elemento Raiz
        {
            get { return this.raiz; }
        }
        public void InOrdem(Elemento atual, StreamWriter wr)
        {
            if (atual != null)
            {
                InOrdem(atual.Esquerda, wr);
                wr.WriteLine(atual.Valor);
                InOrdem(atual.Direita, wr);
            }
        }
    }
}
