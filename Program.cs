using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha2 p = new Pilha2();

            p.Push("Ana");
            p.Push("Eva");
            p.Push("Rui");
            p.Push("bob");
            p.Pop();

            Console.WriteLine("Retirou: " + p.Pop());
            Console.WriteLine("Topo: "+ p.Top());
            Console.WriteLine("Tamanho: " + p.Size());
            Console.WriteLine("Vazio: " + p.IsEmpty());
            p.Imprimir();

            Fila2 f = new Fila2();

            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------");
            f.Enqueue("Azul");
            f.Enqueue("Rosa");
            f.Enqueue("Roxo");
            f.Enqueue("Bege");
            f.Dequeue();

            Console.WriteLine("Retirou: " + f.Dequeue());
            Console.WriteLine("Começo: " + f.Front());
            Console.WriteLine("Tamanho: " + f.Size());
            Console.WriteLine("Vazio: " + f.IsEmpty());
            f.Imprimir();

            Console.Read();
        }
    }
}
