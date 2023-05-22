using System;

class Arvore
{

    Elemento raiz;
    public Arvore()
    {
        this.raiz = null;
    }

    public void Inserir(int x) { // "X" é o valor passado pela chamada do método
        Elemento novo = new Elemento(x);
        if (raiz == null) {
            this.raiz = novo;
        } else {
            Elemento atual = this.raiz;
            while (true) {
                if (novo.Valor.CompareTo(atual.Valor) == -1) {
                    // Esquerda
                    if (atual.Esquerda != null) {
                        atual = atual.Esquerda;
                    } else {
                        atual.Esquerda = novo;
                        break;
                    }
                } else {
                    // Direita
                    if (atual.Direita != null) {
                        atual = atual.Direita;
                    } else {
                        atual.Direita = novo;
                        break;
                    }
                }
            }
        }
    }

    public bool Search(int x) {        
        Elemento atual = this.raiz;        
        while(atual!=null) {   
                    if (atual.Valor==x)
                        return true;
                    else if (atual.Esquerda != null) {
                        // Esquerda
                        if (atual.Esquerda.Valor==x) {                            
                            return true;
                        }
                        atual = atual.Esquerda;
                    } else if (atual.Direita != null) {
                        // Direita
                        if (atual.Direita != null) {
                            if (atual.Direita.Valor==x)
                                return true;
                            atual = atual.Direita;
                        }
                    } else return false;            
        }
        return false;
    }

    public Elemento Raiz {
        get {return this.raiz; }
    }
    public void InOrdem(Elemento atual) {
        if (atual!=null) {
            InOrdem(atual.Esquerda);
            Console.Write(atual.Valor+" ");
            InOrdem(atual.Direita);
        }
    }

    public void PreOrdem(Elemento atual) {
        if (atual!=null) {
            Console.Write(atual.Valor+" ");
            PreOrdem(atual.Esquerda);
            PreOrdem(atual.Direita);
        }
    }

    public void PosOrdem(Elemento atual) {
        if (atual!=null) {            
            PosOrdem(atual.Esquerda);
            PosOrdem(atual.Direita);
            Console.Write(atual.Valor+" ");
        }
    }
}    
