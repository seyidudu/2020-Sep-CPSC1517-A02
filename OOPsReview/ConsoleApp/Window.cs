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
        //public string name { get; set; }
        // PRIVATE DATA MEMBERS
        //      These are variables that are known ONLY within the class
        //      will be used for fully implemented properties
        //      will be used for locak class only data
        private string _Manufacturer;
        private decimal _Height;

        // PRIVATE DATA MEMBERS
        //      Are known within the class and outside of the class
        //      public data members can be altered by code within and without side the class
        //      It is preferred to use properties instead of public data members
        
        //PROPERTIES
        //OPTIONAL
        //  Properties can be imp;lemented in two ways
        //  a) Fully Implemented property
        //      Used because there us additonal code/lgic use in processing the data
        //  b) Auto Implemented Property
        //      Used when there is no need for additional code/logic
        //      When the data is simply saved/stored

        //FULLY IMPLEMENTED PROPERTY
        public string Manufacturer 
        {
            //assume the Manufacturer is nullable string
            // 3 possibilities
            // a) there are no characters 
            // b) string has no data (null)
            // c) there is a physical string BUT NO characters
            // there will be addtional code/logic to ensure ONLY a and b exists in the
            get
            {
                //returns data via the property to the outside user of thr property
                // a get operates on the right side of an equal sign (assignment statement)
                return _Manufacturer;
            }
            set 
            {
                // the set takes incoming data and places that data into a private member
                // internal to the property, incoming data will be placed in a common variable called value
                // a property is associated with a single data member
                // a property has NO parameter list
                // a set operates on the left side of an equal sign (assignment statement)
                if (string.IsNullOrEmpty(value))
                {
                    // ensure a null is stores in the private data member
                    //      eliminate the c possibility
                    _Manufacturer = null;// case b
                }
                else 
                {
                    // ensure the value is stored in the private data member
                    
                    _Manufacturer = null; // case a
                }

            //alternative coding (only used when you have a single value coming back)
            //syntax    receiving field = conditions(s) ? true value: false value;
            // _Manufacturer = string.ISNullOrEmpty(value) ? null: value;
        //private string _WeekDay;
        //WeekDay = value == "0" ? "Sunday" : (value == "1" ? "Monday" :
        //                                        (value == "2" ? "Tuesday" :)
        //                                        (value == "3" ? "Wednesday" :...
        //                                        (value == "5" ? "Friday" : "Saturday"))))

            }

        }

        public decimal Height
        {
            //Height mucst be greater than 0
            get { return _Height;}
            set 
            {
                //the m indicates the value is a decimal
                if (value <= 0.0m)
                {
                    throw new Exception("Height can not be 0 or less than 0");
                }
                else
                {
                    _Height = value;
                }
            }

        }
        //Auto Implemented Property
        //  Auto Implemented Property can be used when there is no need for additional processing against the incoming data
        //  No internal private data member is requiered for this property
        //  The system will internally generate a data read for the data
        //  accessing the stores data(get, set) CAN ONLY be done via the property

        
        public decimal Width { get; set; }

        // one can still code auto implemented properties as fully implemented properties
        //private decimal _FullWidth;
        //public decimal FullWidth {
        //    get { return _FullWidth; } 
        //    set { _FullWidth = value; } }

        // WHat about nullable numerics
        // Do we need to test for a null value to be used for missing incoming data?
        // No, you don not have to code a fully implemented property for a nullable numeric
        // Numerics have a default of Zero
        // Numerics can ONLY store a numeric (unless nullable)
        // Numerics can BE NULL if declared as nullable
        // IF the numeric has additional criteria THEN you can
        // code the propertied as a Fully Implemented property

        public int NumberOfPanes { get; set;}
        // Constructors
        // a constructor is"a method" that guarantees that the newly created instance of this class will AWLAYS be created
        // "a known state"
        // constructors do not use a return data type

        //syntax
        //public constructorname ([list of parameters])
        //{
        //  your code
        //}

        // Constructors are OPTIONAL
        // If a class DOES NOT have a constructor then the system 
        // will generate the class instance using the datatype defauls
        //for your private data memebers and auto implemented properties
        // this situation of no constructor(s) is often rfred to as 
        // using a "system" constructor

        //

    }
}
