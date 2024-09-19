using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        String nomb;
        double sal, v, desc=0,co=0,salb,suel;
        int año;
        Console.WriteLine("Ingrese su nombre");
        nomb = Console.ReadLine();
        Console.WriteLine("Ingrese su salario bruto del mes");
        sal = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese lo ganado en ventas (s/.)");
        v = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese sus años en la empresa");
        año = int.Parse(Console.ReadLine());

        if (v <= 600) {
            co = v * 0.05;
        } else if (v > 600 & v <= 3000) {
            co = v * 0.07;
        } else if (v > 3000) {
            co = (v * 0.06) + 300;
        }

        salb = sal + co;

        if (año <= 3) {
            desc = salb * 0.065;
        }else if (año >= 4) {
            desc = salb * 0.045;
        }

        suel = salb - desc;

        Console.WriteLine($"Su nombre: {nomb}");
        Console.WriteLine($"Salario bruto: {suel}");
        Console.WriteLine($"Ventas: {v}");
        Console.WriteLine($"Años en la empresa: {año}"); 




    }
}