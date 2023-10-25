using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_21._10._23
{
    internal class Employee
    {
        public string Name { get; set; }
        public Employee Manager { get; set; }

        public Employee(string name, Employee manager)
        {
            Name = name;
            Manager = manager;
        }
    }
}
