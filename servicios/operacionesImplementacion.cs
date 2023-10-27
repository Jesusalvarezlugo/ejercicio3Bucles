using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3Bucles.servicios
{
    internal class operacionesImplementacion : operacionesInterfaz
    {
        public void MuestraNumero(int numero)
        {
            for (int i = 1; i <= numero; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public int PedirNumero()
        {
            int num;

            Console.WriteLine("Introduce un número entero mayor que 0");
            num = Int32.Parse(Console.ReadLine());

            while (num <= 0)
            {
                Console.WriteLine("[Error] introduce un número mayor que 0");
                num = Int32.Parse(Console.ReadLine());
            }

            return num;
        }
    }
}
