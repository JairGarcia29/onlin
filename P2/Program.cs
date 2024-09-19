internal class Program
{
    private static void Main(string[] args)
    {
        int n, v=0,a=0,r = 0;
        String s="v";


        Console.WriteLine("¿Desea continuar con el programa? (v/f)");
        s = Console.ReadLine().ToLower();

        while (s == "v") {
            
            Console.WriteLine("Ingrese el ultimo número de placa");
            n = int.Parse(Console.ReadLine());
            if (n >= 0 & n <= 3) {
                v++;
            } else if (n >= 4 & n <= 6) {
                a++;
            } else if (n >= 7 & n <= 9)
            {
                r++;
            }
            Console.WriteLine("¿Desea continuar con el programa? (v/f)");
            s = Console.ReadLine().ToLower();
        }
        Console.WriteLine("PROGRAMA TERMINADO");
        Console.WriteLine($"Verde: {v}");
        Console.WriteLine($"Azul: {a}");
        Console.WriteLine($"Rojo: {r}");


    }
}