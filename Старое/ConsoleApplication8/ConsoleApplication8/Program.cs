﻿using System;
public abstract class Figure
{
     const double pi = 3.1415;
    public int [] point1 = new int[2];
    public int [] point2 = new int [2];
    public int [] point3 = new int [2];
    public int [] point4 = new int [2];
    #region Construct    
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
    #endregion
    #region Properties


    public double Pi
    {
        get {return pi; }       
    }
    #endregion
    #region Methods

    public abstract void showStyle();
   
    //Метод возвращает длинну  по двум точкам.
    public double length_Line(int [] point1,int [] point2)
    {
        return Math.Sqrt(Math.Pow((point2[0] - point1[0]), 2) + Math.Pow((point2[1] - point1[1]), 2));
    }
    public abstract double area();
    public abstract double perimetr();
    #endregion
}


public class Circle : Figure
{
    double radius;
    public Circle(int[] point1, int[] point2) : base(point1, point2)

    {

        radius = length_Line(point1, point2);
       
    }


    public override double area()
    {

        return Pi * Math.Pow(radius, 2);
    }
    public override double perimetr()
    {

        return 2 * Pi * radius;
    }
    public override void showStyle()
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
}
    public override double area()
    {

        return diagonal1*diagonal2/2;
    }
    public override double perimetr()
    {
        return 4*side1;
    }
    public override void showStyle()
    {
        Console.WriteLine("Ромб сторона  = " + side1);
        Console.WriteLine("Ромб площадь " + area());
        Console.WriteLine("Ромб периметр " + perimetr());
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
        Circle circ1 = new Circle(point1, point2);
        Circle circ2 = new Circle(point2, point4);        
        Rhombus romb1 = new Rhombus(point1, point2, point3, point4);
        Rhombus romb2 = new Rhombus(point1, point2, point3, point4);
        Figure[] mas_figure = new Figure[4];
        mas_figure[0] = circ1;
        mas_figure[1] = circ2;
        mas_figure[2] = romb1;
        mas_figure[3] = romb2;
        
        for (int i = 0; i < mas_figure.Length; i++)
        {
            mas_figure[i].showStyle();
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}