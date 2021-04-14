using System;

namespace InterfacesDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker manager = new Manager();
            IWorker robot = new Robot();
            IWorker worker = new Worker();
            IWorker[] array = new IWorker[] {manager, robot, worker};
            foreach (var items in array)
            {
                items.Work();
            }

            Console.ReadLine();
        }

        
    }

    interface IWorker
    {
        void Work();
      
    }

    interface IEat
    {
        void Eat();
    }

    interface IGetSalary
    {
        void GetSalary();
    }

    class Manager : IWorker ,IEat,IGetSalary
    {
        public void Work()
        {
            Console.WriteLine("Managers are working");
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker ,IEat,IGetSalary
    {
        public void Work()
        {
            Console.WriteLine("Workers are working");
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robots are working");
        }
    }
}
