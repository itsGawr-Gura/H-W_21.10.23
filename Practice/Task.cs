using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_21._10._23
{
    internal class Task
    {
        public string Name { get; set; }
        public Employee Recipient { get; set; }

        public Task(string name, Employee recipient)
        {
            Name = name;
            Recipient = recipient;
        }
    }
}
