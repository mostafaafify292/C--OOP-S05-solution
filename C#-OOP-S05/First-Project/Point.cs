using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_S05.First_Project
{
    internal class Point : IComparable , ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point()
        {
            
        }

        public Point(int _X , int _Y , int _Z) 
        { 
            X = _X;
            Y = _Y;
            Z = _Z;        
        }
        public Point(Point p1)
        {
            X = p1.X;
            Y = p1.Y;
            Z = p1.Z;
        }
        public override string ToString()
        {
             return $"Point Coordinates: ({X}, {Y}, {Z})";

        }

        public int CompareTo(object? obj)
        {
            Point testpoint = (Point) obj;
            if (this.X > testpoint.X)
                return 1;
            else if (this.X < testpoint.X)
                return -1;
            else if (this.X == testpoint.X)
            {
                if (this.Y > testpoint.Y)
                    return 1;
                else if (this.Y < testpoint.Y)
                    return -1;
                else return 0;
            }
            return 0;

            

            
        }

        public object Clone()
        {
            return new Point(this);
        }
    }
}
