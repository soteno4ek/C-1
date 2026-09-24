using System;

public class Summa
{
    public int PrintNum()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());
        return a + b;
    }
    
    public int Sum(int x1, int x2)
    {
        return x1 + x2;
    }
    
    public void PrintSum(int x1, int x2)
    {
        Console.WriteLine($"x1+x2 = {x1+x2}");
    }
}
class Program
{
    
    static void Main()
    {
        Summa summa = new Summa();
        int x = summa.Sum(7, 9);
        summa.PrintSum(2, 9);
        int x1 = summa.PrintNum();
        Console.WriteLine(x);
        Console.WriteLine(x1);
    }
}