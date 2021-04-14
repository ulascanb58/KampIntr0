using System;

namespace Interfac3sDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();
            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
        }

        interface IPersonManager
        {
            void Add();
            void Update();

        }

        class CustomerManager : IPersonManager
        {
            public void Add()
            {
               Console.WriteLine("Müşteri Eklendi");
            }

            public void Update()
            {
                throw new NotImplementedException();
            }
        }

        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Personel eklendi");
            }

            public void Update()
            {
                throw new NotImplementedException();
            }
        }

        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                personManager.Add();
            }

        }
    }
}
