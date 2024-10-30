public class Session05_01
{
    public static void swap (ref int a, ref int b)
    {
    int temp = a;
    a = b;
    b = temp;
    }
    public static void Main  (string[]args)
    {
        int a = 6; 
        int b = 7;
        Console.WriteLine($"Before call a ={a}, b = {b}");
        Console.WriteLine($"After call a ={a}, b = {b}");
        Console.ReadKey();
    }
}
