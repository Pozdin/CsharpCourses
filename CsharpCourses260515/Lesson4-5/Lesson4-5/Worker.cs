using System;

namespace Lesson4_5
{
    abstract class Worker
    {
        private string name;
        private int age;
        public Int64 snn;
        public static int count;
        protected double salary;
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Неверно задан возраст!");
                }
                else
                {
                    age = value;
                }
            }
        }
        public virtual void Print()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("ИНН: " + snn);
            Console.WriteLine("Зарплата: " + salary);
            Console.WriteLine("Премия: " + GetBonus());
            Console.WriteLine();
        }
        public abstract double GetBonus();
        public static void PrintWorkers(Worker[] workers)
        {
            for (int i = 0; i < workers.GetLength(0); i++)
            {
                workers[i].Print();
            }
        }
        public Worker(string name, int age, Int64 snn)
        {
            this.name = name;
            this.Age = age;
            this.snn = snn;
            count++;
            salary = 20000;
        }
        public Worker(string name, int age)
            : this(name, age, 0)
        {

        }
        public Worker()
        {
        }
        static Worker()
        {
            count = 0;
        }
    }

    sealed class Driver : Worker
    {
        public string carType;
        public int hours;
        public Driver(string name, int age, Int64 snn, string carType, int hours)
            : base(name, age, snn)
        {
            this.carType = carType;
            this.hours = hours;
            salary = 35000;
        }
        public override double GetBonus()
        {
            return hours * 100;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Машина: " + carType);
            Console.WriteLine("Часы: " + hours);
            Console.WriteLine();
        }
    }

    sealed class Manager : Worker
    {
        public int projectsCount;
        public Manager(string name, int age, Int64 snn, int projectsCount)
            : base(name, age, snn)
        {
            this.projectsCount = projectsCount;
            salary = 40000;
        }
        public override double GetBonus()
        {
            return projectsCount * 1500;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Количество проектов: " + projectsCount);
            Console.WriteLine();
        }
    }
}
