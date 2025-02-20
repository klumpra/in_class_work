﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExample20250219
{
    internal abstract class Shape: Movable // implements Movable interface
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Shape()
        {
            X = 0;
            Y = 0;
        }
        public Shape(double x, double y)
        {
            X = x;
            Y = y;
        }
        public virtual string GetType()
        {
            return "shape";
        }
        public override string ToString()
        {
            return $"{GetType()} {X,0:F2} {Y,0:F2}";
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public void Move(double dx, double dy)
        {
            X = X + dx;
            Y = Y + dy;
        }
        public void RandomMove(Random rnd)
        {
            X = X -50 + rnd.NextDouble() * 100;
            Y = Y -50 + rnd.NextDouble() * 100;
        }

    }
}
