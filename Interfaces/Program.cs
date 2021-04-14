using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();
            // CustomerManager customerManager=new CustomerManager();
          // customerManager.Add(new SqlServerCustomerDal());
          ICustomerDal SqlServerDAL = new SqlServerCustomerDal();
          ICustomerDal OracleServerDAL = new OracleServerCustomerDal();
          List<ICustomerDal> DataAccesLayers = new List<ICustomerDal>(){SqlServerDAL,OracleServerDAL};
          CustomerManager _customerManager=new CustomerManager();
          _customerManager.Add(DataAccesLayers);
          
           Console.Read();



        }
       public void InterfacesIntro()
        {
            Customer cst = new Customer();
            PersonManager manager = new PersonManager();
            cst.FirstName = "İsim";
            manager.Add(cst);
        }
        interface IPerson
        {
           int Id { get; set; }
           string FirstName { get; set; }
           string LastName { get; set; }
        }

        class Customer :IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Address { get; set; }
        }

        class Student :IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
               
                
            }
        }
    }
}
