using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDEM0.Abstract;

namespace InterfaceAbstractDEM0.Entities
{
    public class Customer:IEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
