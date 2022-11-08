using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03_PAG62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double peso, media, acumulador=0, contador1=0, contador2= 0;
            int idade = 0;

            for (int i = 0; i < 40; i++)
            {
                Console.Clear();
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite seu peso: ");
                peso = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if(peso < 75)
                {
                    contador1++;
                }

                if(idade >= 20 && idade <= 23)
                {
                    contador2++;
                }

                acumulador += idade;
            }

            media = acumulador / 40;
            Console.WriteLine("A media de idade da Equipe é: " + media);
            Console.WriteLine("As pessoas abaixo de 75kg foram: " + contador1);
            Console.WriteLine("As pessoas abaixo de 75kg foram: " + contador2);
            Console.ReadKey();

            //Victor Carmo Alecrim
        }
    }
}
