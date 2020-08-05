using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUml
{
    class Student:Person
    {
        //property
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        //constructor
        public Student() { }

        public Student (string Name, string Address, string Program,int Year, double Fee):base(Name,Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }
        public override string ToString()
        {
            return (base.ToString()+$"Program = {Program} Year = {Year} Fee = {Fee}");
        }
        public override void AddInfo(List<Person> lst)
        {
            //base.AddInfo(lst);
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();

            Console.WriteLine("Enter Program: ");
            string program = Console.ReadLine();

            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter year: ");
            double fee = int.Parse(Console.ReadLine());

            lst.Add(new Student(name, address,program,year,fee));
        }
    }
}
