using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {// Exercicio 1:
            Console.Write("1. Escreva um aplicativo que apresente os números de 1 a 40 separados por um espaço em branco, da seguinte maneira:");
            Console.Write("\nResposta:");
            Console.Write("\na) 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40");
            Console.Write("\n");
            Console.Write("\nb)\t 1 2 3 4 5 6 7 8 9 10");
            Console.Write("\n\t 11 12 13 14 15 16 17 18 19 20");
            Console.Write("\n\t 21 22 23 24 25 26 27 28 29 30");
            Console.Write("\n\t 31 32 33 34 35 36 37 38 39 40");
            Console.ReadKey();

            //Exercício 2:
            int x = 2;
            int y = 3;
            Console.Write("\n\n2. ");
            Console.WriteLine("O que aparece na janela do console, quando cada uma das instruções C# abaixo são executadas, para x = 2 e y = 3 ?");
            Console.WriteLine("a)x = " + x);
            Console.WriteLine("b)O valor de x + x é " + (x + x));
            Console.WriteLine("c)x = ");
            Console.WriteLine("d)" + (x + y) + " = " + (y + x));
            Console.ReadKey();


            //Exercício 3
            Console.Write("\n3. O que o código a seguir imprime?\n");
            Console.WriteLine("*\n**\n***\n****\n*****");
            Console.ReadKey();


            //Exercício 4
            Console.Write("\n4. O que o código a seguir imprime?\n");
            Console.Write("*");
            Console.Write("***");
            Console.WriteLine("*****");
            Console.Write("****");
            Console.WriteLine("**");
            Console.ReadKey();


            //Exercício 5
            //Matrícula
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n5.***REGISTRO DE PESSOAS** ");
            Console.WriteLine("\nDigite sua matricula e aperte Enter:\n");
            Console.ResetColor();
            int matricula = Int32.Parse(Console.ReadLine());


            //Nome e Sobrenome
            Console.WriteLine("\nDigite seu Nome e Sobrenome e aperte Enter:\n");
            string nomeSobrenome = Console.ReadLine();

            Console.Write("\n\n\t ***Sua matrícula é ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(matricula);
            Console.ResetColor();

            Console.Write(" e Seu nome é ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(nomeSobrenome);
            Console.ResetColor();
            Console.Write("***\n");
            

            //Exercício 6
            Console.WriteLine("\n\n6. Informe 2 números inteiros abaixo:");
            Console.WriteLine("\nDigite o 1º número e aperte Enter:");
            int valor1 = Int32.Parse(Console.ReadLine());
          
            Console.WriteLine("\nDigite o 2º número e aperte Enter:");
            int valor2 = Int32.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n A soma destes números é: ");
            int soma = valor1 + valor2;
            Console.Write(soma);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n A subtração destes números é: ");
            int subtração = valor1 - valor2;
            Console.Write(subtração);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\n A multiplicação destes números é: ");
            int multiplicação = valor1 * valor2;
            Console.Write(multiplicação);
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n A divisão destes números é: ");
            int divisão = valor1 / valor2;
            Console.Write(divisão);
            Console.ResetColor();
            Console.Write("\n\n\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("***FIM***");
            Console.WriteLine("\n**Leia os comentários**");
            Console.ResetColor();
            Console.ReadKey();


            
         //Exercício 7. 
         //Exercício 8.
         //Exercício 9.
         //Exercício 10.

            /* Professor Diego, os exercícios 7, 8, 9 e 10 eu não soube fazer. Eu poderia ter copiado o exercício dos meus colegas, mas creio que esse 
             * exercício seja para aprendizagem e copiar não seria efetivo. Porém, com sua correção terei um aprendizado enorme. Obrigado.*/
        
            


        }
    }
}