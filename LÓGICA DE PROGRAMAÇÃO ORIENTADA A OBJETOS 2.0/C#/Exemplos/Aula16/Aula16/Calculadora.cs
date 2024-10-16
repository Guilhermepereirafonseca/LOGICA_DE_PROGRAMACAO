using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula16
{
    internal class Calculadora()
    {
        public static double PI = 3.14;

        public static int adicao(int n1, int n2)
        {
            return(n1 + n2);
        }

        public static int subtracao(int n1, int n2) 
        { 
            return(n1 - n2);
        }

        public static int multiplicacao(int n1, int n2) 
        {
            return (n1 * n2);
        }

        public static int divisao(int n1, int n2)
        {
            return (n1 / n2);
        }

        public static double areaCirculo(int raio) 
        {
            double area = 0;
            area = Calculadora.PI * raio * raio;
            return area;
        }
    }
}

