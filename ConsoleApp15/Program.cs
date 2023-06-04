using System.Xml;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int c = a;
            int g;
            g = a;
            int b = 0;
            int number1 = 1;
            int number2 = 1;
            int number3 = 1;
            while (a>0) {
                a = a / 10;
                b++;
            }
            
            for (int i = 0; i < b; i++) 
            {
                number1 = number1 * (c % 10);
            }
            c = c / 10;
            for (int i = 0; i < b; i++)
            {
                number2 = number2 * (c % 10);
            }
            c = c / 10; 
            for (int i = 0; i < b; i++)
            {
                number3 = number3 * (c % 10);
            } 
            if (number1 + number2 + number3 == g) {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}