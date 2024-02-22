using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods //Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(3, 5);
            Console.WriteLine(result);

            int number1 = 20;
            int number2 = 30;
            var result2 = Add3(number1, ref number2); //ref yerine out da kullanılabilir : ref'de number2 değer ataması yapılmış olmalı ama out da öyle bir zorunluluk yok
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.WriteLine(number2);

            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Multiply(2, 3, 4));

            Console.WriteLine(Add4(1,2,3,4)); //params ile metoda aynı tipte istenildiği kadar sayı gönderilebilir
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2=0)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(int number1,ref int number2)
        {
            number1 = 30; 
            number2 = 5; //out da method ilk kullanıldığı yerde set edilmiş olmalı
            return number1 + number2;
        }

        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
