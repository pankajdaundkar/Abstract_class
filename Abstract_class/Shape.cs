﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public abstract class Shape
    {
        public abstract void CalculateArea();
    }
    public class Circle : Shape
    {
        private int r;
        private double area;

        public Circle(int r)
        {
            this.r = r;

        }
        public override void CalculateArea()
        {
            area = 3.14 * r * r;
        }
        public override string ToString()
        {
            return $"Area of circle is {area}";
        }
    }
    public class Rectangle : Shape
    {
        private int l, b;
        private Double area;

        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }
        public override void CalculateArea()
        {
            area = l * b;
        }
        public override string ToString()
        {
            return $"Area of rectangle is {area}";
        }
    }
}
