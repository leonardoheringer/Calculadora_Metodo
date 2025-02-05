 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Metodo
{
    public class Menu
    {
    public static void Tela()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----Bem Vindo a Calculadora-----");
            Console.WriteLine("Digite o Primeiro Numero");
            double numero1 = double.Parse(Console.ReadLine());  
            Console.WriteLine("Digite o Segundo Numero");
            double numero2 = double.Parse(Console.ReadLine()); ;

            Console.WriteLine("Escolha a operação desejada");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Cancelar");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Calculadora.Adicao(numero1, numero2);
                    break;
                case "2":
                    Calculadora.Subtracao(numero1, numero2);

                    break;
                case "3":
                    Calculadora.Multiplicacao(numero1, numero2);
                    break;
                case "4":
                    Calculadora.Divisao(numero1, numero2);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }
        }

    }

}
