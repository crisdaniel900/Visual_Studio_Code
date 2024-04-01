internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        string Linea;
        long  Resul;
        Console.WriteLine("Eliga un numero");
        num = int.Parse(Console.ReadLine());
        Resul= Math.Abs(num);
        Console.WriteLine("Valor absouluto es " + Resul);
        System.Console.WriteLine("Potenica " + Math.Pow(num, 3));
        System.Console.WriteLine("Raiz Cuadrada " + Math.Sqrt(num));
        System.Console.WriteLine("Seno " + Math.Sin(num * Math.PI /180));
        System.Console.WriteLine("Seno " + Math.Cos(num * Math.PI /180));
        System.Console.WriteLine("Maximo " + Math.Max(num, 50));
        System.Console.WriteLine("Maximo " + Math.Min(num, 50));
        System.Console.WriteLine("Entera " + Math.Truncate(15.23));
        System.Console.WriteLine("Redondero " + Math.Round(3.1416));
        Console.ReadKey();

    }
}