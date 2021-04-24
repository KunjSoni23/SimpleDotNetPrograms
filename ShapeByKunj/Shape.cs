using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeByKunj
{
    class Shape
    {

        private double _height;
        private double _width;

        public Shape()
        {
            _height = 0.0;
            _width = 0.0;
        }

        public double Height
        {
            get => _height;
            set => _height = value;
        }

        public double Width
        {
            get => _width;
            set => _width = value;
        }

        public double Area()
        {
            return Height * Width;
        }
    }
}
