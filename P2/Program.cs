internal class Program
{
    private static void Main(string[] args)
    {
        int n, v=0,a=0,r = 0;
        
        n = 1;

        while (n >= 0& n<=9) {
            Console.WriteLine("Ingrese su ultimo número de placa");
            n = int.Parse(Console.ReadLine());
            if (n >= 0 & n <= 3) {
                v++;
            } else if (n >= 4 & n <= 6) {
                a++;
            } else if (n >= 7 & n <= 9)
            {
                r++;
            }
        }
        Console.WriteLine("PROGRAMA TERMINADO");
        Console.WriteLine($"Verde: {v}");
        Console.WriteLine($"Azul: {a}");
        Console.WriteLine($"Rojo: {r}");


    }
}