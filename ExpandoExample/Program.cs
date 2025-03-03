﻿using System.Dynamic;

namespace ExpandoExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic obj1 = new ExpandoObject();

            obj1.Name = "Volodymyr";
            obj1.Age = 35;
            obj1.Position = "Sofware Engeneer";
            obj1.DateStart = new DateOnly(2018, 1, 1);

            Console.WriteLine(obj1.Name);
            Console.WriteLine(obj1.DateStart);

            obj1.Sallary = 200009;

            Console.WriteLine(obj1.Sallary);

            obj1.Name = "Bob";

            Console.WriteLine(obj1.Name); 

        }
    }
}
