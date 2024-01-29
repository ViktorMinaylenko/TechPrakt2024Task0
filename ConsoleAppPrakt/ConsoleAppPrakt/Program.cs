using System.Text;

namespace ConsoleAppPrakt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Введіть перше число: ");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Введіть друге число:");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    double sum = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {sum}");
                }
                else
                {
                    Console.WriteLine("Має бути правильний формат другого числа!");
                }
            }
            else
            {
                Console.WriteLine("Має бути правильний формат першого числа!");
            }

        }
    }
}