using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUml
{
    class Person
    {
        //property
        public string Name { get; set; }
        public string Address { get; set; }

        //constructor
        public Person() { }
        public Person(string Name, String Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        //method
        public override string ToString()
        {
            return $"Name = {Name} Address = {Address}";
        }
        public virtual void AddInfo(List<Person> lst)
        {

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();

            lst.Add(new Person(name, address));      
        }
    }
}
