internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingresa el primero numero ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingresa el segundo numero ");
        int num2 = int.Parse(Console.ReadLine());

        string comparacion = num1 > num2 ?  "Mayor " : (num1 == num2 ? "igual" : "Menor" );

        Console.WriteLine($"{num1} es  {comparacion} que {num2}");
        
    }
}