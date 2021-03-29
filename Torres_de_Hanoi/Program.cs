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
            string key = Console.ReadLine();
            int cuantos = 0;
            while (!Int32.TryParse(key, out cuantos) || Int32.Parse(key) < 0)
            {
                Console.WriteLine("Inténtelo de nuevo");
                key = Console.ReadLine();
            }

            for (int i = cuantos; i > 0; i--)
            {
                Disco disco = new Disco();
                disco.Valor = i;
                ini.push(disco);
            }
            int pasos = Hanoi.iterativo(cuantos, ini, fin, aux);

            int pasosRecursivo = Hanoi.recursivo(cuantos, ini, aux, fin);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Pasos realizados con iterativo: " + pasos);
            Console.WriteLine("Pasos realizados con recursivo: " + pasosRecursivo);
            Console.WriteLine("Pasos mínimos: " + (Math.Pow(2, cuantos) - 1));
            Console.WriteLine("-----------------------------------");

        }
    }
}
