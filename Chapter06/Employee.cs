using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Chapter06
{
    public class Employee : Person
    {
        public string? EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public void WriteToConsole()
        {
            WriteLine(format:
                "{0} was born on {1:dd/MM/yy} and hired on {2:dd/MM/yy}",
                arg0: Name,
                arg1: DateOfBirth,
                arg2: HireDate
                );
        }

        //overridden methods
        public override string ToString()
        {
            return $"{Name} is a {base.ToString()}";
        }
    }
}
