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


        public decimal Height
        {
            get { return _Height; }
            set
            {
                if (value <= 0.0m)
                {
                    throw new Exception("Height can not be 0 or less than 0.");
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
                if (value <= 0.0m)
                {
                    throw new Exception("Width can not be 0 or less than 0.");
                }
                else
                {
                    _Width = value;
                }
            }
        }

        public Wall()
        {
            Width = 1.2m;
            Height = 1.75m;
        }
        public Wall(decimal width, decimal height)
        {

            Width = width;
            Height = height;
        }
        public decimal WallArea()
        {
            return Width * Height;
        }
    }
}
