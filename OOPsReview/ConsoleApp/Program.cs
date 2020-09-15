using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Window myInstance = new Window();// the system calls your class constructor
            // if you dont have constructors the system assigns the default value for the data type

            myInstance.Width = 1.2m;
            myInstance.Height = 1.2m;
            myInstance.NumberOfPanes = 3;
            myInstance.Manufacturer = "All-Weather Windows";

            Window myGreedyInstance = new Window (1.2m, 1.2m, 3, "All-Weather Windows");

           

            

        }
    }
}
