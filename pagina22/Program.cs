internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Ingresa el valore de 3 numeros con un espacio ");
        string ingreso = Console.ReadLine();
        
        string[] numeros = ingreso.Split(' ');
        int num1 = int.Parse(numeros[0]);
        int num2 = int.Parse(numeros[1]);
        int num3 = int.Parse(numeros[2]);

        int Grande = Math.Max (num1, Math.Max(num2, num3));
        int Chico = Math.Min (num1, Math.Min(num2, num3));

        System.Console.WriteLine($"Grande {Grande}");
        System.Console.WriteLine($"Chico {Chico}");


    }
}