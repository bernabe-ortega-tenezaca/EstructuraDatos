class clsTiposBasicos
{
    public static void Ejecutar()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   TIPOS DE DATOS BÁSICOS");
        Console.WriteLine("========================================");
        Console.WriteLine();

        // -------------------------------------------------------
        // 1. NÚMEROS ENTEROS (int)
        // -------------------------------------------------------
        Console.WriteLine("--- ENTEROS (int) ---");
        Console.WriteLine("Guardan números sin decimales: -5, 0, 42, 1000");
        Console.WriteLine();

        // Declaramos una variable de tipo entero llamada 'edad'
        int edad = 25;

        // Declaramos otra entero llamada 'año'
        int anio = 2026;

        // Mostramos los valores en pantalla
        Console.WriteLine("  edad = " + edad);
        Console.WriteLine("  año  = " + anio);

        // Podemos hacer operaciones aritméticas básicas
        int suma = edad + 10;
        Console.WriteLine("  edad + 10 = " + suma);

        int resta = anio - 2000;
        Console.WriteLine("  año - 2000 = " + resta);

        int producto = 4 * 5;
        Console.WriteLine("  4 * 5 = " + producto);

        int division = 15 / 3;
        Console.WriteLine("  15 / 3 = " + division);

        Console.WriteLine();

        // -------------------------------------------------------
        // 2. NÚMEROS FLOTANTES (float / double)
        // -------------------------------------------------------
        Console.WriteLine("--- FLOTANTES (double) ---");
        Console.WriteLine("Guardan números CON decimales: 3.14, -0.5, 99.99");
        Console.WriteLine();

        // 'double' es el tipo más común para decimales
        double precio = 19.99;
        double temperatura = 36.5;

        Console.WriteLine("  precio       = " + precio);
        Console.WriteLine("  temperatura  = " + temperatura);

        // Operaciones con decimales
        double descuento = precio * 0.15;
        Console.WriteLine("  15% de " + precio + " = " + descuento);

        double promedio = (10.5 + 20.3 + 30.1) / 3;
        Console.WriteLine("  promedio de (10.5, 20.3, 30.1) = " + promedio);

        Console.WriteLine();

        // -------------------------------------------------------
        // 3. CARACTERES (char)
        // -------------------------------------------------------
        Console.WriteLine("--- CARACTERES (char) ---");
        Console.WriteLine("Guardan UN SOLO carácter: 'A', '?', '7', ' '");
        Console.WriteLine();

        // Los char se escriben con comillas SIMPLES
        char letra = 'A';
        char simbolo = '@';
        char numeroComoChar = '7';   // Esto es el carácter '7', no el número 7
        char espacio = ' ';

        Console.WriteLine("  letra          = " + letra);
        Console.WriteLine("  símbolo        = " + simbolo);
        Console.WriteLine("  dígito         = " + numeroComoChar);
        Console.WriteLine("  espacio        = '" + espacio + "'");

        // Cada carácter tiene un número asociado (código ASCII/Unicode)
        Console.WriteLine();
        Console.WriteLine("  Cada carácter tiene un código numérico:");
        Console.WriteLine("  El código de 'A' es: " + (int)letra);
        Console.WriteLine("  El código de '@' es: " + (int)simbolo);

        Console.WriteLine();

        // -------------------------------------------------------
        // RESUMEN
        // -------------------------------------------------------
        Console.WriteLine("========================================");
        Console.WriteLine("   RESUMEN");
        Console.WriteLine("========================================");
        Console.WriteLine("  int    -> números enteros     ej: 42, -3, 0");
        Console.WriteLine("  double -> números decimales   ej: 3.14, -0.5");
        Console.WriteLine("  char   -> un solo carácter    ej: 'A', '?'");
        Console.WriteLine("========================================");
    }
}
