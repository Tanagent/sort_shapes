using System;
using System.Collections.Generic;
using System.Text;

namespace SortShapes
{
    class Shape
    {
        private string shape;
        private double size;

        public Shape(string shape, double size)
        {
            this.shape = shape;
            this.size = size;
        }

        public string getShape()
        {
            return shape;
        }

        public double getSize()
        {
            return Math.Round(size, 2);
        }
    }
}
