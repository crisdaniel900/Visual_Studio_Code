internal class Program
{
    private static void Main(string[] args)
    {
         int Num, Aux, Dec, Uni;
        string Linea;
        System.Console.WriteLine("Ingrese nuemero de dos cifras");
       Num = int.Parse(Console.ReadLine());
       Dec = Num/10;
       Uni = Num %10;
       Aux = (Uni*10)+Dec;
       Console.WriteLine("Numero invertido eso " + Aux);
       Console.ReadKey();
    }
}