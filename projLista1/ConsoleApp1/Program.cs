using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaInteiros;
            listaInteiros = new List<int>();

            listaInteiros.Add(44);
            listaInteiros.Add(33);
            listaInteiros.Add(22);
            listaInteiros.Add(33);
            listaInteiros.Add(11);
            mostraLista(listaInteiros);

            listaInteiros.Insert(2, 77);
            mostraLista(listaInteiros);

            Console.WriteLine("Posição do 33: {0}", listaInteiros.LastIndexOf(33));
            Console.WriteLine("Posição do 33: {0}", listaInteiros.IndexOf(99));

            Console.WriteLine(listaInteiros.Remove(22) ? "Removeu 22" : "Não achou o 22");
            Console.WriteLine(listaInteiros.Remove(22) ? "Removeu 22" : "Não achou o 22");
            mostraLista(listaInteiros);

            listaInteiros.RemoveAt(3);
            mostraLista(listaInteiros);


        }

        static void mostraLista(List<int> lista)
        {
            Console.WriteLine("Qtde: {0}", lista.Count);
            foreach(int i in lista)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------");

        }
    }
}
