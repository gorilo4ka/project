using System;
class Swap
{
    // Этот метод меняет местами значения своих аргументов.
    public void swap(ref int a, ref int b)
    {
       
    }
}
class SwapDemo
{
    public static void Main()
    {
        Swap ob = new Swap();
        int x = 10, y = 20;
        Console.WriteLine("x и y перед вызовом: " +
        x + " " + y);
        int t;
        t = x;
        x = y;
        y = t;
        Console.WriteLine("x и y после вызова: " +
        x + " " + y);
        Console.ReadKey();
    }
}