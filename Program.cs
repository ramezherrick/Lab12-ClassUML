using System;
using System.Collections.Generic;

namespace Lab12_ClassUml
{
    class Program
    {
        static void Main(string[] args)
        {
            Person people = new Person();
            List<Person> peopleList = new List<Person>();

            Student students = new Student();
            List<Student> studentsList = new List<Student>()
            {
                new Student("Ramez","3007 N Vermont","C#",2020,10750),
                new Student("Curtis","Sterling Heights","C#",2020,10750),
                new Student("Josh","Troy","C#",2020,10750)
             };

            for (int i =0;i<studentsList.Count;i++)
            {
                Console.WriteLine(studentsList[i]);
            }

            Staff staff = new Staff();
            List<Staff> staffList = new List<Staff>()
            {
                new Staff("Anna", "Detroit", "grand circus", 100),
                 new Staff("Tommy", "Grand Rapids", "grand circus", 100),
                 new Staff("Steve", "Auburn Hills", "grand circus", 30)
            };
            
            //Addinfo(people);
            //Addinfo(students);
        }
        public static void Addinfo(Person x)
        {
            
            List<Person> lst = new List<Person>();
            
            x.AddInfo(lst);

            for (int i =0;i<lst.Count;i++)
            {
                Console.WriteLine(lst[i]);
            }

        }

    }
}
