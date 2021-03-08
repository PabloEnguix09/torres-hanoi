using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        public int Top { get; set; }
        public List<Disco> Elementos { get; set; }

        //Inicializa las variables
        public Pila()
        {
            Size = 0;
            Top = 0;
            Elementos = new List<Disco>();
        }

        //Aumenta la cantidad de discos en la pila y el disco que está arriba
        public void push(Disco d)
        {
            Elementos.Add(d);
            Size++;
            Top++;
        }
        // Reduce la cantidad de discos en la pila, recarga el disco que está arriba y devuelve el disco que ha quitado
        public Disco pop()
        {
            Disco discoFuera = Elementos.ElementAt(Size - 1);
            Elementos.RemoveAt(Size - 1);
            Size--;
            Top--;
            return discoFuera;
        }

        // Devuelve true si el tamaño es 0
        public bool isEmpty()
        {
            return Size == 0;
        }
    }
}
