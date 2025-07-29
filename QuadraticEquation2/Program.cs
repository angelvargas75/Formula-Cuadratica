using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ECUACIÓN DE SEGUNDO GRADO ===");
        Console.WriteLine("Forma: ax² + bx + c = 0");
        Console.WriteLine();

        try
        {
            Console.Write("Valor de a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Error: 'a' no puede ser cero.");
                return;
            }

            Console.Write("Valor de b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valor de c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            ResolverEcuacion(a, b, c);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }

    static void ResolverEcuacion(double a, double b, double c)
    {
        double discriminante = b * b - 4 * a * c;
        Console.WriteLine($"\nDiscriminante: {discriminante}");

        if (discriminante > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            Console.WriteLine("Raíces reales diferentes:");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        else if (discriminante == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Raíz real doble:");
            Console.WriteLine($"x = {x}");
        }
        else
        {
            // Raíces complejas
            double real = -b / (2 * a);
            double valorImaginario = Math.Sqrt(-discriminante);
            
            // Para mostrar en formato fraccionario cuando sea necesario
            double imaginarioFinal = valorImaginario / (2 * a);
            
            // Simplificar la raíz si es posible
            var parteImaginaria = SimplificarRaiz((int)(-discriminante));
            
            Console.WriteLine("Raíces complejas:");
            
            // Mostrar la parte imaginaria correctamente
            if (Math.Abs(parteImaginaria.coeficiente - valorImaginario) < 0.0001)
            {
                // No se puede simplificar bien, mostrar decimal
                Console.WriteLine($"x1 = {real} + {imaginarioFinal}i");
                Console.WriteLine($"x2 = {real} - {imaginarioFinal}i");
            }
            else
            {
                // Se puede simplificar
                double coeficienteFinal = parteImaginaria.coeficiente / (2 * a);
                
                if (parteImaginaria.radicando == 1)
                {
                    Console.WriteLine($"x1 = {real} + {coeficienteFinal}i");
                    Console.WriteLine($"x2 = {real} - {coeficienteFinal}i");
                }
                else if (Math.Abs(coeficienteFinal - 1.0) < 0.0001)
                {
                    Console.WriteLine($"x1 = {real} + √{parteImaginaria.radicando}i");
                    Console.WriteLine($"x2 = {real} - √{parteImaginaria.radicando}i");
                }
                else
                {
                    // Mostrar como fracción si es necesario
                    if (2 * a == Math.Floor(2 * a))
                    {
                        Console.WriteLine($"x1 = {real} + ({parteImaginaria.coeficiente}√{parteImaginaria.radicando}/{(int)(2 * a)})i");
                        Console.WriteLine($"x2 = {real} - ({parteImaginaria.coeficiente}√{parteImaginaria.radicando}/{(int)(2 * a)})i");
                    }
                    else
                    {
                        Console.WriteLine($"x1 = {real} + {coeficienteFinal}√{parteImaginaria.radicando}i");
                        Console.WriteLine($"x2 = {real} - {coeficienteFinal}√{parteImaginaria.radicando}i");
                    }
                }
            }
        }
    }

    static (int coeficiente, int radicando) SimplificarRaiz(int valor)
    {
        int coeficiente = 1;
        int radicando = valor;

        // Encontrar el mayor cuadrado perfecto que divide al número
        for (int i = (int)Math.Sqrt(valor); i >= 2; i--)
        {
            if (valor % (i * i) == 0)
            {
                coeficiente = i;
                radicando = valor / (i * i);
                break;
            }
        }

        return (coeficiente, radicando);
    }
}
