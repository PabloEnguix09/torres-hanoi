using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();
            // Keep the console window open in debug mode.
            Console.WriteLine("Indique el número de discos que va a utilizar: ");
            int cuantos = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
            for (int i = cuantos; i > 0; i--)
            {
                Disco disco = new Disco();
                disco.Valor = i;
                ini.push(disco);
            }
            int pasos = Hanoi.iterativo(cuantos, ini, fin, aux);

            int pasosRecursivo = Hanoi.recursivo(cuantos, ini, aux, fin);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Algoritmo iterativo");
            Console.WriteLine("Pasos realizados: " + pasos);
            Console.WriteLine("Pasos mínimos: " + (Math.Pow(2, cuantos) - 1));
            Console.WriteLine("------------------------------");
            Console.WriteLine("Algoritmo recursivo");
            Console.WriteLine("Pasos realizados: " + pasosRecursivo);
            Console.WriteLine("Pasos mínimos: " + (Math.Pow(2, cuantos) - 1));
            Console.WriteLine("------------------------------");
        }
    }
}
