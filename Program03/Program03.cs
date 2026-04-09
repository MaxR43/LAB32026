namespace Programa03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 2: NÚMEROS CON DECIMALES ---");

            // Estatura (double)
            double estatura = 1.75;
            Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
            Console.WriteLine("   Valor guardado: " + estatura + " metros");

            double peso = 70.52;
            Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
            Console.WriteLine("   Valor guardado: " + peso + " kilogramos");

            // Dinero (decimal) - Recuerda la 'm' al final
            decimal precioProducto = 199.99m;
            Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
            Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
            Console.WriteLine("   Valor guardado: $" + precioProducto);

            decimal valorDolar = 1425.47m;
            Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
            Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
            Console.WriteLine("   Valor guardado: $" + valorDolar);

            decimal distanciaRecorrida = 10.4;
            Console.WriteLine("\n3. TIPO DECIMAL COMÚN (decimal):");
            Console.WriteLine("   Valor guardado: " + distanciaRecorrida + " metros");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}