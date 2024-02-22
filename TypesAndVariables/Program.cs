using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Value Types

            Console.WriteLine("Veri Tipleri!");
            byte number4 = 255; // 0 & 255 --> 8 bitlik yer kaplar
            short number3 = -32768; // -32768 & 32767 --> 16 bit
            int number1 = 10; // -2147483648 & 2147483647 --> 32 bit
            long number2 = 2147483648; //-9223372036854775808 & 9223372036854775807 --> 64 bit
            bool condition = true; //true - false
            char character = 'A';
            double number5 = 10.4; //64 bit
            decimal number6 = 10.4M;
            var number7 = 56; 
            
            Console.WriteLine("Number1 is {0}" , number1);
            Console.WriteLine("Number2 is {0}" , number2);
            Console.WriteLine("Number3 is {0}" , number3);
            Console.WriteLine("Number4 is {0}" , number4);
            Console.WriteLine("Number5 is {0}" , number5);
            Console.WriteLine("Number7 is {0}" , number7);

            Console.WriteLine("Character is : {0}", character );
            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine(Days.Friday);


            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday  
    }
}
