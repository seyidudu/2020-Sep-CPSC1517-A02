using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Door
    {
        // Height, Width, Material, Right or Left Swing Door
        // Height and Width > 0.0
        // Height has a default of 1.75, width is 1.2
        // Right or Left are Indicated with an R or L
        // Area and Perimeter
        // Throw Exceptions for Invalid Data

        private string _Material;
        private decimal _Height;
        private string _RightOrLeft;
        private decimal _Width;

        public string Material
        {
            get { }
            set { }
        }

        public Door(1.2m, 1.75m)
        {
            Width = 1.2m;
            Height = 1.75m;
            RightorLeft = "R"
        

        }
        public Door(decimal width, decimal height, string rightorleft, string material)
        {

            Width = width;
            Height = height;
            RightOrLeft = rightorleft;
            Material = material;

        }

        public decimal DoorArea()
        {
            return Height * Width;
        }

        public decimal DoorPerimeter
        {
            return 2 * (Height + Width);
        }


    }
}
