using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02_PAG62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, contimpar=0, contpar=0;

            for(int i=0; i<20; i++)
            {
                Console.Write("Digite um numero: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                    contpar++;
                else
                    contimpar++;

                       
            }

            Console.Write($"Números pares: {contpar}");
            Console.Write($"Números ímpares: {contimpar}");

            Console.ReadKey();

            //Victor Carmo Alecrim, 
        }
    }
}
