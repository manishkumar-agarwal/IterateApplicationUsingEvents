using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicationRunning
{
    interface IApplicationInterface
    {
        bool RunApplicationFlag { get; set; }

        bool StartApplication();

        bool StopApplication();

        bool Display();

    }
}
