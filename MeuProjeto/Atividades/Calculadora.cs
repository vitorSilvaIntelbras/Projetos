using System;
using System.Linq.Expressions;
using System.Text;
using Algoritmos;


namespace MeuProjeto.Atividades{

    class Calculadora{
        public static void Executar(){
            Console.WriteLine("============= Bem vindo a calculadora ===========");

            Console.Write("Qual operação deseja fazer?\n1-Adição\n2-Subtração\n3-Multiplicação\n4-Divisão\n");
            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o primeiro número");
            int.TryParse(Console.ReadLine(), out int num_1);
            Console.WriteLine("\nDigite o segundo número");
            int.TryParse(Console.ReadLine(), out int num_2);

            int resultado = 0;

            switch (operacao)
            {
                case 1: 
                    resultado = Algoritmos.Calculos.Soma(num_1, num_2);
                    Console.WriteLine($"\nO resultado é {resultado}");
                break;
                case 2: 
                    resultado = Algoritmos.Calculos.Sub(num_1, num_2);
                    Console.WriteLine($"\nO resultado é {resultado}");
                break;
                case 3: 
                    resultado = Algoritmos.Calculos.Mult(num_1, num_2);
                    Console.WriteLine($"\nO resultado é {resultado}");
                break;
                case 4: 
                    resultado = Algoritmos.Calculos.Div(num_1, num_2);
                    Console.WriteLine($"\nO resultado é {resultado}");
                break;               
                default:
                    System.Console.WriteLine("Digite um número válido");
                break;
            }
            

        }
    }
}
