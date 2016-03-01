using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicationRunning
{
    class Program
    {
        static void Main(string[] args)
        {
            Application<EmployeeApplication> app = new Application<EmployeeApplication>();
            app.StartApplication();
        }
    }
}
