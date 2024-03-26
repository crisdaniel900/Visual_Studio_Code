internal class Program
{
    private static void Main(string[] args)
    {
        float num1, num2, resultado1, resultado2, resultado3, resultado4;

        System.Console.WriteLine("Ingrese Valor 1");
        num1 = float.Parse(Console.ReadLine());

        System.Console.WriteLine("Ingrese Valor 2");
        num2 = float.Parse(Console.ReadLine());

        resultado1 = num1+ num2;
        resultado2 = num1 - num2;
        resultado3 = num1 * num2;
        resultado4 = num1 / num2;

        System.Console.WriteLine("La suma de {0} + {1} = {2} ", num1, num2, resultado1);
        System.Console.WriteLine("La resta de {0} - {1} = {2}", num1, num2, resultado2);
        System.Console.WriteLine("La multiplicacion de {0} * {1} = {2}" , num1, num2 , resultado3);
        System.Console.WriteLine("La division de {0} / {1} = {2}" , num1, num2, resultado4);
        Console.ReadKey();


    }
}