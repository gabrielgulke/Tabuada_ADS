using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número da tabuada: ");
            int ntab = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual número você deseja se se inicie a tabuada?: ");
            int ni = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual número você quer que termine a tabuada?: ");
            int nf = Convert.ToInt32(Console.ReadLine());
            for (int n = ni; n <= nf; n++)
                 
                        
            Console.WriteLine(ntab + "x" + n + "=" + n * ntab);

            if (ni > 100)
                Console.WriteLine("Limite máximo permitido é 100");
            else if (ni < 0 )
                Console.WriteLine("Limite minimo permitido é 0");
            if (nf > 100)
                Console.WriteLine("Limite máximo permitido é 100");
            else if (nf < 0)
                Console.WriteLine("Limite minimo permitido é 0");





            Console.ReadKey();
        }
    }
}
