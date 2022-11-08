using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01_PAG62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota=0, notaM=0,media;
            int quantidade;
            double acumulador=0;

            for(quantidade= 0; quantidade<15; quantidade++)
            {
                Console.Write("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());
                acumulador += nota;

                if(quantidade == 0)
                {
                    notaM = nota;

                }
                else
                {
                    if(nota > notaM)
                    {
                        notaM = nota;
                    }
                }

            }

            media = acumulador / quantidade;
            Console.WriteLine("A media de notas da turma foi: " + media);
            Console.WriteLine("A maior nota foi: " + notaM);
            Console.ReadKey();
            
            //Victor Carmo Alecrim 

        }
    }
}
