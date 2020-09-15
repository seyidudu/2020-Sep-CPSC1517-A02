using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Wall
    {
        // Height, Width
        // Height and Width > 0.0
        // Height has a default of 4.25, width is 2.5
        // Area and Perimeter
        // Throw Exceptions for Invalid Data

        private decimal _Height;
        private decimal _Width;
        private string _RightOrLeft;

        public decimal Height
        {
            get { return _Height; }
            set {
                if (string.IsNullOrEmpty(null))
                {
                    throw new Exception("Room must have a name");
                }
                else
                {
                    _Height = value;
                }
            }
        }

        public decimal Width
        {
            get { return Width; }
            set
            {
                if (string.IsNullOrEmpty(null))
                {
                    throw new Exception("Room must have a name");
                }
                else
                {
                    _Width = value;
                }
            }
        }

        public decimal RightOrLeft
        {
            get { return RightOrLeft; }
            set
            {
                if (string.IsNullOrEmpty(null))
                {
                    throw new Exception("Room must have a name");
                }
                else
                {
                    _RightOrLeft = value;
                }
            }
        }



        public Door()
        {
            Width = 1.2m;
            Height = 1.75m;
            RightOrLeft = "R";



        }
        public Door(decimal width, decimal height, string rightorleft, string material)
        {

            Width = width;
            Height = height;
            RightOrLeft = rightorleft;
            Material = material;
        }
}
