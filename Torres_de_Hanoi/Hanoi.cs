using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if(a.Top < b.Top)
            {
                b.push(a.pop());
            }
            if(b.Top < a.Top)
            {
                a.push(b.pop());
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;

            if(n%2 != 0)
            {
                while(fin.Size != n)
                {
                    m++;
                    mover_disco(ini, fin);
                    mover_disco(ini, aux);
                    mover_disco(aux, fin);
                }
            } 
            else
            {
                while (fin.Size != n)
                {
                    m++;
                    mover_disco(ini, aux);
                    mover_disco(ini, fin);
                    mover_disco(aux, fin);
                }
            }

            return m;
        }

    }
}
