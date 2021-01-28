using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica
{
    class Program
    {
        static void Main(string[] args)
        {
        inicio:
            try
            {
                Console.Title = "Exercício de Lógica";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Teste de Lógica: Alterne o valor de duas variáveis sem utilizar uma terceira.");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Digite o primeiro valor A:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                int valor = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Digite o segundo valor B:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                int valor2 = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--------------------------------------------------------");
                var RESULTADO = resolva(valor, valor2).ToString().Split('/');
                Console.Write("O valor de A é: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(RESULTADO[0].ToString());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("O valor de B é: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(RESULTADO[1].ToString());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--------------------------------------------------------");
                Console.Write("Pressione ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("A ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("para ver a regra utilizada ou qualquer tecla para fechar...");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("--------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("a = b + a");
                    Console.WriteLine("b = a - b");
                    Console.WriteLine("a = a - b");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Pressione qualquer tecla para fechar...");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Comando inválido.");
                Console.WriteLine("");
                goto inicio;
            }
           
        }
        public static string resolva(int x, int y)
        {
            x = y + x;
            y = x - y;
            x = x - y;
            return x.ToString() + "/" + y.ToString(); 
        }
    }
}
