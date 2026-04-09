namespace Program01;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("--- SISTEMA DE REGISTRO DE USUARIO ---");

            // 1. Entrada de Texto (Simple)
            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Por favor, ingresa tu apellido: ");
            string apellido = Console.ReadLine();

            // 2. Entrada de Números (Requiere Conversión)
            Console.Write("Ingresa tu edad: ");
            string edadTexto = Console.ReadLine();
            int edad = int.Parse(edadTexto); // Convertimos el texto a número entero

            // 3. Entrada de Decimales (Precios o Medidas)
            Console.Write("Ingresa tu estatura (ejemplo: 1,75): ");
            double estatura = double.Parse(Console.ReadLine()); // Conversión directa en una línea

            Console.Write("Ingresa tu peso (ejemplo: 1,75): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Indica en que mes estamos: ");
            string mes = Console.ReadLine();

            // 4. Mostrar los resultados procesados
            Console.WriteLine("\n--- PERFIL CREADO ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad el próximo año: " + (edad + 1)); // Operación matemática
            Console.WriteLine("Estatura: " + estatura + " metros");
            Console.WriteLine("Peso: " + peso + " kilogramos");
            Console.WriteLine("Mes: " + mes);

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
    }
}