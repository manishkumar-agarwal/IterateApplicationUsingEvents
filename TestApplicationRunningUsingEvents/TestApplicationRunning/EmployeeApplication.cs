using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicationRunning
{
    class EmployeeApplication : Application<EmployeeApplication>
    {
        public override bool Display()
        {
            Console.WriteLine("Into the Employee Display Function");

            return true;
        }
    }
}
