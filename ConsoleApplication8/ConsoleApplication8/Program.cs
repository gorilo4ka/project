using System;
public abstract class Figure
{
     const double pi = 3.1415;
    public int [] point1 = new int[2];
    public int [] point2 = new int [2];
    public int [] point3 = new int [2];
    public int [] point4 = new int [2];

    public Figure(int [] Point1, int [] Point2)
    {
        point1 = Point1;
        point2 = Point2;
    }
   public Figure(int [] Point1, int [] Point2,int [] Point3, int [] Point4)
    {
        point1 = Point1;
        point2 = Point2;
        point3 = Point3;
        point4 = Point4;

    }

    public double Pi
    {
        get {return pi; }       
    }

            //Метод возвращает длинну  по двум точкам.
    public double length_Line(int [] point1,int [] point2)
    {
        return Math.Sqrt(Math.Pow((point2[0] - point1[0]), 2) + Math.Pow((point2[1] - point1[1]), 2));
    }
    public abstract double area();
    public abstract double perimetr();

}


public class Circle:Figure
{
    double radius;
    public Circle(int [] point1, int [] point2):base(point1,point2)

    {

        radius = length_Line(point1, point2);
    }


     public override double area()
     {

         return Pi*Math.Pow(radius, 2);
     }
     public override double perimetr()
     {

         return 2* Pi * radius;
     }
     public void showStyle()
     {
        Console.WriteLine("Круг радиус " +  radius);
        Console.WriteLine("Круг площадь " + area());
        Console.WriteLine("Круг периметр " + perimetr());
     }
}

public class Rhombus : Figure
{
    double diagonal1;
    double diagonal2;
    double side1;
    double side2;
    public Rhombus (int [] point1,int [] point2,int [] point3,int [] point4):base(point1,point2,point3,point4)
    {
        diagonal1 = length_Line(point1, point3);
        diagonal2 = length_Line(point2, point4);
        side1= length_Line(point1, point2);
        side2 = length_Line(point2, point3);
        if (side1 != side2)
        {
            Console.WriteLine("Это не ромб!");
        }
        else
        {
            Console.WriteLine("Ромб сторона  = " + side1);
            Console.WriteLine("Ромб площадь " + area());
            Console.WriteLine("Ромб периметр " + perimetr());
        }
}
    public override double area()
    {

        return diagonal1*diagonal2/2;
    }
    public override double perimetr()
    {
        return 4*side1;
    }

}


class Hello
{
    static void Main()
    {
        int[] point1 = new int[2] { 1, 1 };
        int[] point2 = new int[2] { 2, 2 };
        int[] point3 = new int[2] { 3, 3 };
        int[] point4 = new int[2] { 4, 4 };
        Circle circ = new Circle(point1, point2);
        circ.showStyle();
        Rhombus romb = new Rhombus(point1, point2, point3, point4);
        
        Console.ReadKey();
    }
}