public class Validator
{
    //на число
    public int ReadInt(string promt)
    {
        Console.Write(promt);
        string? s = Console.ReadLine();
        int x = 0;
        while (!int.TryParse(s, out x))
        {
            Console.WriteLine("ERROR! ");
            Console.WriteLine(promt);
            s = Console.ReadLine();
        }

        return x;
    }
    
    public int ReadIntNatural(string promt)
    {
        Console.WriteLine(promt);
        string? s = Console.ReadLine();
        int x = 0;
        while (!int.TryParse(s, out x) && x < 0)
        {
            Console.WriteLine("ERROR! ");
            Console.WriteLine(promt);
            s = Console.ReadLine();
        }

        return x;
    }
}