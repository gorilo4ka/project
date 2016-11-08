using System;
public abstract class Figure
{
    int point1;
    int point2;
    public Figure(int point1, int point2)
    {
        point1_pub = point1;
        point2_pub = point2;
    }
    public int point1_pub
    {
        get {return point1; }
        set { point1 = value;}
                        }
    public int point2_pub
    {
        get { return point2; }
        set { point2 = value; }
    }
    public abstract double area();
}
public class circle:Figure
{
    public circle(int point1, int point2) :base(point1, point2)
    {

    }
    public override double area()
    {
        
        return 3.14*Math.Pow((Math.Abs(point1_pub - point2_pub)), 2);
    }
    public void showStyle()
    {
        Console.WriteLine("Круг " +area());
    }
}

class Hello
{
    static void Main()
    {

        circle circ = new circle(3,6);
        circ.showStyle();
        Console.ReadKey();
    }
}