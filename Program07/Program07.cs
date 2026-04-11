namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE CÁLCULO Y CONTROL ---
            const decimal TASA_IVA = 0.21m; // 21% fijo
            const bool MODO_PRUEBA = false; // Control de seguridad
            const char SIMBOLO_PESO = '$';

            Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

            decimal precioBase = 1500.50m;
            decimal impuestoCalculado = precioBase * TASA_IVA;
            decimal total = precioBase + impuestoCalculado;

            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
            Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
            Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

            bool excentoDeIVA = false;
            Console.WriteLine("¿Exento de IVA? " + excentoDeIVA);

            bool excentoDeIVA2 = true;
            Console.WriteLine("¿Exento de IVA? " + excentoDeIVA2);
            
            // --- CONSTANTES ---
            const decimal DESCUENTO = 0.15m; // 15%
            const char SIMBOLO_PESO = '$';

            Console.WriteLine("--- SISTEMA DE DESCUENTOS ---");

            decimal precioOriginal = 2000m;
            decimal montoDescuento = precioOriginal * DESCUENTO;
            decimal precioFinal = precioOriginal - montoDescuento;

            Console.WriteLine("Precio original: " + SIMBOLO_PESO + precioOriginal);
            Console.WriteLine("Descuento: " + SIMBOLO_PESO + montoDescuento);
            Console.WriteLine("Precio final: " + SIMBOLO_PESO + precioFinal);


            // ---- CONSTANTES ---
            const decimal COSTO_ENVIO = 500m;
            const bool ENVIO_GRATIS = false;

            Console.WriteLine("--- COMPRA ONLINE ---");

            decimal precioProducto = 3500m;
            decimal total = ENVIO_GRATIS ? precioProducto : precioProducto + COSTO_ENVIO;

            Console.WriteLine("Producto: $" + precioProducto);
            Console.WriteLine("Costo envío: $" + (ENVIO_GRATIS ? 0 : COSTO_ENVIO));
            Console.WriteLine("Total: $" + total);


            Console.ReadLine();

    }
}