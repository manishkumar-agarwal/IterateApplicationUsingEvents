using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicationRunning
{
    public delegate bool ApplicationHandler();

    class Application<T> : IApplicationInterface  where T : IApplicationInterface,new()
    {
        public bool RunApplicationFlag{ get;   set;}

        public event ApplicationHandler CurrentApplicationInstance;

        public bool StartApplication()
        {
            Console.WriteLine("Hello!!\nWelcome to the Application");
            RunApplicationFlag = true;
            Display();
            return RunApplicationFlag;
        }

        public bool StopApplication()
        {
            RunApplicationFlag = false;
            Console.WriteLine("Thank You for using the Application!!! We wish to see you again");
            return RunApplicationFlag;
        }

        public virtual bool Display()
        {
            do
            {
                Console.WriteLine("1)App1\n2)App2\n3)End");
            }

            while (Int32.Parse(Console.ReadLine()) != 3);
            return true;

        }
    }
}
