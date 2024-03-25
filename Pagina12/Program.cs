internal class Program
{
    private static void Main(string[] args)
    {
           int Num, Aux, Dec, Uni, Cen;
        Console.WriteLine("Ingrese numero de 3 cirfras: ");
        Num = int.Parse(Console.ReadLine());
        Cen = Num/100;
        Num = Num%100;
        Dec = Num/10;
        Uni = Num %10;
        Aux = (Uni *100 ) + (Dec *10 )+  Cen;
        Console.WriteLine ("Numero invertido es " + Aux);
        Console.ReadKey();
    }
}