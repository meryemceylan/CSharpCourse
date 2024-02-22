﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = { "Ahmet", "Samet" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Çok Boyutlu Diziler");
            string[,] regions = new string[7, 3]
            {
                {"İstanbul","Kocaeli","Tekirdağ" },
                {"Ankara","Sivas","Kayseri" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" },
                {"Van","","" },
                {"Gaziantep","","" },
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("* Yeni Bölge *");
            }

            Console.WriteLine();
            Console.ReadLine(); 
        }
    }
}
