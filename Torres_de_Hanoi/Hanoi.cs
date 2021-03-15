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
        public static void mover_disco(Pila a, Pila b)
        {
            Disco discoMover = new Disco();

            if(a.isEmpty())
            {
                discoMover = b.pop();
                Console.WriteLine("Moviendo disco " + discoMover.Valor + " de B a A");
                if (discoMover.Valor != 0)
                {
                    a.push(discoMover);
                }
                return;
            } 
            else if(b.isEmpty())
            {
                discoMover = a.pop();
                Console.WriteLine("Moviendo disco " + discoMover.Valor + " de A a B");
                if (discoMover.Valor != 0)
                {
                    b.push(discoMover);
                }
                return;
            } 
            else if(a.Top > b.Top)
            {
                discoMover = b.pop();
                Console.WriteLine("Moviendo disco " + discoMover.Valor + " de B a A");
                if (discoMover.Valor != 0)
                {
                    a.push(discoMover);
                }
                return;
            } 
            else if(b.Top > a.Top)
            {
                discoMover = a.pop();
                Console.WriteLine("Moviendo disco " +discoMover.Valor+ " de A a B");
                if (discoMover.Valor != 0)
                {
                    b.push(discoMover);
                }
                return;
            }
        }

        public static int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;

            if(n%2 != 0)
            {
                while(fin.Size != n)
                {
                    mover_disco(ini, fin);
                    m++;
                    if(fin.Size == n)
                    {
                        break;
                    }
                    mover_disco(ini, aux);
                    m++;
                    if (fin.Size == n)
                    {
                        break;
                    }
                    mover_disco(aux, fin);
                    m++;
                    if (fin.Size == n)
                    {
                        break;
                    }
                }
            } 
            else
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, aux);
                    m++;
                    if (fin.Size == n)
                    {
                        break;
                    }
                    mover_disco(ini, fin);
                    m++;
                    if (fin.Size == n)
                    {
                        break;
                    }
                    mover_disco(aux, fin);
                    m++;
                    if (fin.Size == n)
                    {
                        break;
                    }
                }
            }
            return m;
        }
    }
}
