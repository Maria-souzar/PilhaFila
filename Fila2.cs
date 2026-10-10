using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaLista
{
    class Fila2
    {
        LinkedList<string> lista = new LinkedList<string>();



        public void Enqueue(string nome)
        {
            lista.AddLast(nome);
        }



        public string Dequeue()
        {

            string nome;
            if (!IsEmpty())
            {
                nome = Front();
                lista.RemoveFirst();
            }

            else
            {
                nome = "Fila vazia";
            }

            return nome;
        }



        public string Front()
        {
            return lista.First.Value.ToString();
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

            foreach (string nome in lista)
            {
                Console.Write(nome + " | ");
            }
        }
    }
}
