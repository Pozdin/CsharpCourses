using System;

namespace Lesson4_5
{
    class Program
    {
        static void Main(string[] args)
        {
             Random rnd = new Random();
             string[] names = new string[] { "Ivan", "Vas9", "Sveta", "Jenya", "Elena", "Жорик" };
             Worker[] workers = new Worker[rnd.Next(5,10)];
             for (int i = 0; i < workers.GetLength(0); i++)
             {
                 if (rnd.Next(1, 3) == 1)
                 {
                     workers[i] = new Driver(names[rnd.Next(0, names.GetLength(0))], rnd.Next(20, 80), rnd.Next(111111111, 999999999), "ВАЗ", rnd.Next(100, 500));
                 }
                 else
                 {
                    workers[i] = new Manager(names[rnd.Next(0, names.GetLength(0))], rnd.Next(20, 80), rnd.Next(111111111, 999999999), rnd.Next(1, 20));
                 }
             }
             for (int i = 0; i < workers.GetLength(0); i++)
             {
                workers[i].Print();
             }
             Console.ReadLine();
        }
    }
}