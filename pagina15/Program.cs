internal class Program
{
    private static void Main(string[] args)
    {
        byte cantidad;
        double total =0;
        const double preciosb=0.8;
        const double preciosh=2;
        const double preciosp=1.2;

        for (int i=0; i<3; i++)
        {

            //el ? es un if else abreviado y el : sirve para serarar un if/else de cada escensario
            Console.Write ("Cantidad de  {0}:", i==0 ? "hamburgesas" : i ==1? "papas ": "Bebidas");
            cantidad = byte.Parse(Console.ReadLine());

            switch (i)
        {
            case 0:
            total += cantidad * preciosh;
            break;

            case 1:
            total += cantidad * preciosp;
            break;

            case 2:
            total += cantidad * preciosb;
            break;
        }
        }

        
        System.Console.WriteLine();
        Console.WriteLine($"Valor a pagar {total}" );
    }
}