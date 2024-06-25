using System;
using System.IO;
using System.Collections.Generic;
using Entities;

class Program
{
    static void Main(string[] args)
    {
        string path = "/home/vinicius/Área de Trabalho/C#/IComparable/names.txt";
        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                List<Employee> list = new List<Employee>();
                while (!sr.EndOfStream)
                {
                    list.Add(new Employee(sr.ReadLine()));
                }
                list.Sort();
                foreach (Employee str in list)
                {
                    Console.WriteLine(str);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}
