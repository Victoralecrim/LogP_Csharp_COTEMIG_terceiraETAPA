using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10Pag73
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int classe = 0;
            int cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0, cont6 = 0, cont7 = 0;

            string[] nome = new string[5];
            double[] salario = new double[5];

            for (int i = 0; i < nome.Length; i++)
            {

                Console.WriteLine("Escreva seu nome");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Escreva sua classe");
                classe = int.Parse(Console.ReadLine());

                while (classe < 1 || classe > 7)
                {
                    Console.WriteLine("Classe digitada invalida digite novamente: ");
                    classe = int.Parse(Console.ReadLine());
                }
                switch (classe)
                {
                    case 1: salario[i] = 250.00;
                        cont1++;
                        break;
                    case 2:
                        salario[i] = 350.00;
                        cont2++;
                        break;
                    case 3:
                        salario[i] = 450.00;
                        cont3++;
                        break;
                    case 4:
                        salario[i] = 550.00;
                        cont4++;
                        break;
                    case 5:
                        salario[i] = 700.00;
                        cont5++;
                        break;
                    case 6:
                        salario[i] = 900.00;
                        cont6++;
                        break;
                    case 7:
                        salario[i] = 1300.00;
                        cont7++;
                        break;
                }

            }
            Console.Clear();

            // a) 
            for (int i = 0; i < nome.Length; i++)
            {
               Console.WriteLine(nome[i]);
                Console.WriteLine("R$" + salario[i]);
                Console.WriteLine("--------------------");
            }
            // b)
            Console.WriteLine("O total de funcionarios da classe 1 é: " + cont1);
            Console.WriteLine("O total de funcionarios da classe 2 é: " + cont2);
            Console.WriteLine("O total de funcionarios da classe 3 é: " + cont3);
            Console.WriteLine("O total de funcionarios da classe 4 é: " + cont4);
            Console.WriteLine("O total de funcionarios da classe 5 é: " + cont5);
            Console.WriteLine("O total de funcionarios da classe 6 é: " + cont6);
            Console.WriteLine("O total de funcionarios da classe 7 é: " + cont7);
            // c)
            int[] vet = new int[7] {cont1, cont2, cont3, cont4, cont5, cont6, cont7};
            int maior = 0;
            int classeMaior = 0;
             for (int i = 0; i < 6 ;i++)
            {
                if(i == 0)
                {
                    maior = vet[i];
                    classeMaior = i + 1;
                }
                else
                {
                    if (vet[i] > maior)
                    {
                        maior = vet[i];
                        classeMaior = i + 1;
                    }
                }


            }
            Console.WriteLine(" A classe com mais funcionarios é: " + classeMaior + " com " + maior + " funcionários" );
            Console.ReadKey();
        }
    }
}
