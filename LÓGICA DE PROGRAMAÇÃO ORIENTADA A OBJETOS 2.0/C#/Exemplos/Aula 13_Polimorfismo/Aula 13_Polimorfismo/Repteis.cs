using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_13_Polimorfismo
{
    internal class Repteis : Animal
    {
        public Repteis(string tipoAnimal) : base(tipoAnimal) { 
            
        }

        public override void caracteristicas()
        {
            Console.WriteLine("Troca de pele");
        }
    }
}
