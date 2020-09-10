using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    // a class represent the defined characteristics of an item
    // an item can be a physical thing (cellphone), concept(student),
    //  a collection of data
    // Visual studio creates your class without a specific access type
    // the default type for a class is private
    // code outside of a private class cannot use the contents of the private class????
    // for the class to be used by an outside usewr (code) it must be public
    public class Window
    {
        public string name { get; set; }
    }
}
