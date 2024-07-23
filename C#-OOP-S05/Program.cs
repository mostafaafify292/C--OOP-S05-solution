using C__OOP_S05.First_Project;
using C__OOP_S05.Second_Project;
using C__OOP_S05.Third_Project;

namespace C__OOP_S05
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region FirstProject (3)
            //    int y;
            //    int z;
            //    Console.WriteLine("please enter point1");
            //    Console.Write($" X OF point1 =  ");
            //    int x;
            //    bool g = int.TryParse(Console.ReadLine(), out x);
            //    if (g == false)
            //    {
            //        x = 0;
            //    }
            //    Console.Write($" Y OF point1 =  ");
            //    g = int.TryParse(Console.ReadLine(), out y);
            //    if (g == false)
            //    {
            //        y = 0;
            //    }
            //    Console.Write($" Z OF point1 =  ");
            //    g = int.TryParse(Console.ReadLine(), out z);
            //    if (g == false)
            //    {
            //        z = 0;
            //    }
            //    Point point1 = new Point(x, y, z);

            //    Console.WriteLine(point1.ToString());
            //    ////now will read from user point2

            //    int y2;
            //    int z2;
            //    Console.WriteLine("please enter point1");
            //    Console.Write($" X OF point2 =  ");
            //    int x2;
            //    bool g2 = int.TryParse(Console.ReadLine(), out x2);
            //    if (g2 == false)
            //    {
            //        x2 = 0;
            //    }
            //    Console.Write($" Y OF point2 =  ");
            //    g2 = int.TryParse(Console.ReadLine(), out y2);
            //    if (g2 == false)
            //    {
            //        y2 = 0;
            //    }
            //    Console.Write($" Z OF point2 =  ");
            //    g2 = int.TryParse(Console.ReadLine(), out z2);
            //    if (g2 == false)
            //    {
            //        z2 = 0;
            //    }
            //    Point point2 = new Point(x2, y2, z2);

            //    Console.WriteLine(point2.ToString());

            #endregion
            #region FirstProject (4)
            //Point p1 = new Point(1,2,3);
            //Point p2 = new Point(1,2,3);
            //if (p1 == p2)
            //{
            //    Console.WriteLine("p1 == p2 \n it worked");
            //}
            //////it dosn't work becouse we need to make overRide operator on class to can use this operator

            #endregion
            #region FirstProject (5)

            //Point[] points = new Point[3] 
            //{
            //new Point(4, 5, 3),
            //new Point(4, 6, 6),
            //new Point(7, 8, 9)
            //};

            //Array.Sort(points);

            //foreach (Point p in points)
            //{ Console.WriteLine(p); }

            #endregion
            #region FirstProject (6)

            //Point point01 = new Point(5, 5, 5);
            //Point point02 = new Point(10, 10, 10);
            //Console.WriteLine(point01.GetHashCode());
            //Console.WriteLine(point02.GetHashCode());
            //point02 = (Point)point01.Clone();
            //Console.WriteLine(point01.GetHashCode());
            //Console.WriteLine(point02.GetHashCode());
            //Console.WriteLine(point01.ToString());
            //Console.WriteLine(point02.ToString());

            #endregion

            #region SecondProject (1)

            //Maths.Add(5,5);
            //Maths.Subtract(4,5);
            //Maths.Multiply(5,5);
            //Maths.Divide(5,5);

            #endregion

            #region ThirdProject (3)
            //Duration D1 = new Duration(1, 70, 15);
            //Console.WriteLine(D1.ToString());

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString());

            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString());

            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString());
            #endregion
            #region ThirdProject (4)

            #region + operator
            //Duration d1 = new Duration(2, 7, 4);
            //Duration d2 = new Duration(5, 8, 9);
            //Duration d3;
            //d3 = d1 + d2;
            //Console.WriteLine(d3.ToString());
            //d3 = d1 + 7800;
            //Console.WriteLine(d3.ToString());
            #endregion
            #region preeFix ++d2 operator
            //Duration d1 = new Duration(2, 7, 4);
            //Duration d2 = new Duration(5, 8, 9);
            //Duration d3;
            //d3 = ++d2;
            //Console.WriteLine(d2); 
            #endregion
            #region -- operator
            //Duration d1 = new Duration(2, 7, 4);
            //Duration d2 = new Duration(5, 8, 9);
            //Duration d3;
            //d3 = --d2;
            //Console.WriteLine(d3);

            #endregion
            #region - operator
            //Duration d1 = new Duration(2, 7, 4);
            //Duration d2 = new Duration(5, 8, 9);
            //d2 = d2 - d1;
            //Console.WriteLine(d2); 
            //d2 -= d1;
            //Console.WriteLine(d2);
            #endregion
            #region > and <= operator
            //Duration d1 = new Duration(6, 8, 10);
            //Duration d2 = new Duration(6, 8, 11);
            //if (d2 <= d1)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine(" false");
            //}
            #endregion

            #endregion

        }
    }
}
