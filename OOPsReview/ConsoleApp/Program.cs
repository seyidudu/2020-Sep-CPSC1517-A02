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
            // create an instance of the window class using the default constructor
            // the system calls your class construstor, your code Never calls the constructor directly.
            // the "new" will use the indicated constructor
            // the "new" actually makes the call to the constructor and returns the 
            // instance of the class

            Window myInstance = new Window();// the system calls your class constructor
            // if you dont have constructors the system assigns the default value for the data type

            // results of the constructor
            Console.WriteLine($"Width{myInstance.Width}; Height{myInstance.Height};" + $"Panes{ myInstance.NumberOfPanes}; Manufacturer >{myInstance.Manufacturer}<");
            
            // to place data within the new instance (object) of the class
            //      use the properties
            // to reference a property within an instance, use the dot operator
            myInstance.Width = 1.2m;
            myInstance.Height = 1.2m;
            myInstance.NumberOfPanes = 3;
            myInstance.Manufacturer = "All-Weather Windows";

            Console.WriteLine($"Width{myInstance.Width}; Height{myInstance.Height};" + $"Panes{ myInstance.NumberOfPanes}; Manufacturer >{myInstance.Manufacturer}<");

            Window myGreedyInstance = new Window (1.6m, 3.3m, 3, "Fancy Windows");

            Console.WriteLine($"Width{myGreedyInstance.Width}; Height{myGreedyInstance.Height};" + 
                $"Panes{ myGreedyInstance.NumberOfPanes}; Manufacturer >{myGreedyInstance.Manufacturer};<");

            Door theDoor = new Door(1.2m, 1.9m, "L", "Wood");
            Console.WriteLine($"Width {theDoor.Width} Height {theDoor.Height};" +
                $"Right or Left { theDoor.RightOrLeft}; Material >{theDoor.Material}<");


            Console.ReadKey();//when using the debugger  your console window remains open

            Console.WriteLine("\n\n");

            UsingClasses();

            //when using your debugging
            Console.ReadKey();
        }
        static void UsingClasses()
        {
            //the purpose of this methid is to calculate the cost
            //  of painting a room
            //the room will have serval windows and walls with a single door
            //all data for windows, walls and doors will be collected and
            //   stored in an instance of Room

            //What does Room need
            //declare a set of List<T> for the components of the Room
            List<Wall> walls = new List<Wall>();
            List<Window> windows = new List<Window>();
            List<Door> doors = new List<Door>();
            Room room = new Room(); //Default constructor

            //read and collect the data for the room
            //create a reusable pointer variable to each of the components
            //   of a room (wall, window, door)
            //these pointers are created outside of my input loops
            Wall wall = null;
            Window window = null;
            Door door = null;



            //collect the data for all of the walls in the room
            //loop of prompt/input/validation for each wall

            //after validation of data, create an instance of the need class
            wall = new Wall();
            //load data into the instance
            wall.Width = 6.6m;
            wall.Height = 3.1m;
            //add the new instance into your collection (List<T>) to save the data
            walls.Add(wall);

            //end of the wall collection loop

            //assume the loop collected and stored the following
            //pass 2
            wall = new Wall();
            //load data into the instance
            wall.Width = 6.6m;
            wall.Height = 3.1m;
            //add the new instance into your collection (List<T>) to save the data
            walls.Add(wall);

            //pass 3
            wall = new Wall();
            //load data into the instance
            wall.Width = 5.6m;
            wall.Height = 3.1m;
            //add the new instance into your collection (List<T>) to save the data
            walls.Add(wall);

            //pass 4
            wall = new Wall();
            //load data into the instance
            wall.Width = 5.6m;
            wall.Height = 3.1m;
            //add the new instance into your collection (List<T>) to save the data
            walls.Add(wall);

            //door loop
            //collect the data for all of the doors in the room
            //loop of prompt/input/validation for each door
            //assume in this example that the literials were acually in variables
            //door = new Door(inputWidth, inputHeight, inputRL, inputMaterial);
            door = new Door(0.85m, 2.0m, "R", "Composite Pressed Wood");
            doors.Add(door);

            //end of door loop

            //Window loop
            //prompt/input/validate
            //store
            window = new Window(1.3m, 1.3m, 2, "Fancy Windows");
            windows.Add(window);
            // at this point you would have 3 listd to load to the eoom
            //Room is a composite class

            //window = new Window(1.3m, 1.3m, 2, "Fancy Windows");
            //windows.Add(window);
            room.Door = doors; // load the complete List(T)
            room.Walls = walls; // load the complete List(T)
            room.Window = windows; // load the complete List(T)
            room.Name = "Master Bedroom";

           // Determine the area of wall surface to paint
           // Area of the wall
           // Area of openings
           // paintable surface = area of the wall - area of the openings
           // cans = paintable surface /27.87

           // calculate the total area of the walls
           decimal wallarea = 0.0m;
            //foreach controls the traverse of the collection (List<T>)
            //item is a placeholder for the instance in the collection
            //item terminates at the end of the loop
           foreach(Wall item in room.Walls)
            {
                wallarea += item.WallArea();
            }
           
           // Calculate total area of doors
           // for review let us use the for (int i = 0; end condition; increment){.....} loop
           decimal doorarea = 0.0m;
            for (int i = 0; i < room.Door.Count(); i++)
            { 
            doorarea += room.Door[i].DoorArea();
            }

            // calculate the total area of windows
            // var datatype get resolved sat execution time
            //does not change datatype while within the loop
            decimal windowarea = 0.0m;
            foreach (var item in room.Window)
            {
                windowarea += item.WindowArea();
            }
            //painmtable surface area
            decimal netwallarea = wallarea - (doorarea - windowarea);

            // calculate the number of cans of paint required
            decimal cansOfPaint = netwallarea / 27.87m;

            //output results
            Console.WriteLine("Wall area is:\t\t{wallarea:0.00}");
            Console.WriteLine("Wall area is:\t{0.0.00}");
            Console.WriteLine("Door area is:\t{doorarea:0.00}");
            Console.WriteLine("Window area is:\t{windowarea:0.00}");
            Console.WriteLine("Net Wall area is:\t{netWallArea:0.00}");
            Console.WriteLine("Required number of paint is:\t{cansOfPaint:0.00}");

        }
    
    }
}
