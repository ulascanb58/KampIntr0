using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product 
    {
        //Primary Key
        public int Id { get; set; }
        //Foreign Key
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }   

        
    }
}
