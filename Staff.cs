using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUml
{
    class Staff:Person
    {
        //property
        public string School { get; set; }
        public double Pay { get; set; }

        //constructor
        public Staff() { }
        public Staff(string Name, string Address,string School, double Pay):base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }
        public override string ToString()
        {
            return (base.ToString()+$"School = {School} Pay = {Pay}");
        }
    }
}
