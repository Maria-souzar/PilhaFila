using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaLista
{
    class Pilha2
    {
        LinkedList<string> lista = new LinkedList<string>();



        public void Push(string nome)
        {
            lista.AddLast(nome);
        }



        public string  Pop()
        {

            string nome;
            if (!IsEmpty())
            {
                nome = Top();
                lista.RemoveLast();
            }

            else
            {
                nome = "Pilha vazia";
            }
            
            return nome;
        }



        public string Top()
        {
            return lista.Last.Value.ToString();
        }



        public int Size()
        {
            return lista.Count;
        }



        public bool IsEmpty()
        {
            return lista.Count == 0;
        }



        public void Imprimir()
        {
            Console.Write("\n| ");

            foreach (string nome in lista){
                Console.Write(nome + " | ");
            }
        }









    }
}
