using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intro();

            string sentence = "My name is Meryem Ceylan";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is x";

            bool result3 = sentence.EndsWith("ğ"); // cümle .. ile bitiyor mu
            bool result4 = sentence.StartsWith("My"); // cümle .. ile başlıyor mu

            var result5 = sentence.IndexOf("name"); //belli bir karakter ya da ifadeyi aramak için kullanılır
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3,4);

            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();

            var result12 = sentence.Replace(" ", "-");
            var result13 = sentence.Remove(2);


            Console.WriteLine(result);
            Console.WriteLine(result2); 
            Console.WriteLine(result9);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "İstanbul";
            Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Kayseri";
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
