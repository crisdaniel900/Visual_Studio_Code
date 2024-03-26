internal class Program
{
    private static void Main(string[] args)
    {
      int num1;

        Console.WriteLine("Ingrese un numerp para saber si es par o impar");
        num1 = int.Parse(Console.ReadLine());

        if (num1 % 2 == 0)
    {
        Console.WriteLine(num1 + " Es par");
    }
        else
    {  
        Console.WriteLine(" Es par es impar");
    }
        Console.ReadKey();
    }
}