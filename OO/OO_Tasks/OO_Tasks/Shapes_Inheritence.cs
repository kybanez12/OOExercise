using System;

namespace OO_Tasks_Inheritence {
    public abstract class Shape
    {
        private string _name;
        private string _colour;


        public Shape(string nm, string clr)
        {
            _name = nm;
            _colour = clr;
        }

        public abstract double GetArea();


        public abstract double GetPerimeter();

    }

    public abstract class Quadrilateral : Shape
    {
        protected int _NumSides = 4;

        public Quadrilateral(string qNm, string qClr) : base(qNm, qClr)
        {

        }

    }

    public class Square : Quadrilateral
    {
        private double _sideLength;

        public Square(string sNm, string sClr, double sLength) : base(sNm, sClr)
        {
            if (_NumSides == 4)
            {
                _sideLength = sLength;
            }


        }

        public override double GetArea()
        {
            return Math.Round(_sideLength * _sideLength, 2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(4 * _sideLength, 2);
        }
    }

    public class Rectangle : Quadrilateral
    {
        private double _length;
        private double _width;

        public Rectangle(string rNm, string rClr, double rL, double rW) : base(rNm, rClr)
        {
            if (_NumSides == 4)
            {
                _length = rL;
                _width = rW;
            }

        }

        public override double GetArea()
        {
            return Math.Round(_length * _width, 2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(2 * _length + 2 * _width, 2);
        }
    }

    public class Circle : Shape
    {
        public const double PI = 3.142;
        private double _radius;

        public Circle(string cNm, string cClr, double cRad) : base(cNm, cClr)
        {
            _radius = cRad;
        }

        public override double GetArea()
        {
            return Math.Round(_radius * _radius * PI, 2);
        }

        public double GetCircumference()
        {
            return Math.Round(2 * _radius * PI, 2);
        }

        public override double GetPerimeter()
        {
            return GetCircumference();
        }

    }


}