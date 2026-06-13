class clsOperacionesTBasicos
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================================");
        Console.WriteLine("   OPERACIONES CON TIPOS DE DATOS BÁSICOS");
        Console.WriteLine("================================================");
        Console.WriteLine();

        // -------------------------------------------------------
        // 1. OPERACIONES ARITMÉTICAS
        // -------------------------------------------------------
        Console.WriteLine("--- 1. ARITMÉTICA ---");

        int a = 10;
        int b = 3;

        Console.WriteLine("  a = " + a + ", b = " + b);
        Console.WriteLine("  a + b = " + (a + b));     // suma
        Console.WriteLine("  a - b = " + (a - b));     // resta
        Console.WriteLine("  a * b = " + (a * b));     // multiplicación
        Console.WriteLine("  a / b = " + (a / b));     // división entera (trunca decimales)
        Console.WriteLine("  a % b = " + (a % b));     // módulo (residuo de la división)

        Console.WriteLine();

        // -------------------------------------------------------
        // 2. DIVISIÓN CON DECIMALES
        // -------------------------------------------------------
        Console.WriteLine("--- 2. DIVISIÓN CON DECIMALES ---");

        double x = 10;
        double y = 3;

        Console.WriteLine("  double: 10 / 3 = " + (x / y));

        int entero = 10;
        Console.WriteLine("  int / int: 10 / 3 = " + (entero / 3));
        Console.WriteLine("  int convertido a double: (double)10 / 3 = " + ((double)entero / 3));

        Console.WriteLine();

        // -------------------------------------------------------
        // 3. OPERADORES DE COMPARACIÓN
        // -------------------------------------------------------
        Console.WriteLine("--- 3. COMPARACIONES ---");
        Console.WriteLine("  Devuelven true (verdadero) o false (falso)");
        Console.WriteLine();

        int num1 = 7;
        int num2 = 5;

        Console.WriteLine("  num1 = " + num1 + ", num2 = " + num2);
        Console.WriteLine("  num1 == num2  → " + (num1 == num2));  // igualdad
        Console.WriteLine("  num1 != num2  → " + (num1 != num2));  // diferencia
        Console.WriteLine("  num1 >  num2  → " + (num1 > num2));   // mayor que
        Console.WriteLine("  num1 <  num2  → " + (num1 < num2));   // menor que
        Console.WriteLine("  num1 >= num2  → " + (num1 >= num2));  // mayor o igual
        Console.WriteLine("  num1 <= num2  → " + (num1 <= num2));  // menor o igual

        Console.WriteLine();

        // -------------------------------------------------------
        // 4. OPERACIONES CON CARACTERES
        // -------------------------------------------------------
        Console.WriteLine("--- 4. CARACTERES ---");

        char c1 = 'A';
        char c2 = 'C';

        Console.WriteLine("  c1 = '" + c1 + "', c2 = '" + c2 + "'");
        Console.WriteLine("  c1 + 1  = '" + (char)(c1 + 1) + "'  (pasamos de A a B)");
        Console.WriteLine("  c2 - c1 = " + (c2 - c1) + "  (distancia entre 'A' y 'C')");

        // Un char se puede comparar igual que un número
        Console.WriteLine("  ¿'A' < 'C'? → " + (c1 < c2));

        Console.WriteLine();

        // -------------------------------------------------------
        // 5. CONVERSIÓN ENTRE TIPOS
        // -------------------------------------------------------
        Console.WriteLine("--- 5. CONVERSIÓN DE TIPOS ---");
        Console.WriteLine();

        // int → double (implícita, no se pierde precisión)
        int entero2 = 42;
        double convertido = entero2;
        Console.WriteLine("  int a double (implícito): " + entero2 + " → " + convertido);

        // double → int (explícita, se pierden los decimales)
        double decimalGrande = 99.99;
        int truncado = (int)decimalGrande;
        Console.WriteLine("  double a int (explícito): " + decimalGrande + " → " + truncado);

        // char → int (código ASCII)
        char letra = 'Z';
        int codigo = letra;
        Console.WriteLine("  char a int: '" + letra + "' → " + codigo);

        // int → char
        int numero = 66;
        char letraDesdeNumero = (char)numero;
        Console.WriteLine("  int a char: " + numero + " → '" + letraDesdeNumero + "'");

        Console.WriteLine();

        // -------------------------------------------------------
        // 6. CONTAR CARACTERES EN UN TEXTO
        // -------------------------------------------------------
        Console.WriteLine("--- 6. LONGITUD DE TEXTO (string) ---");

        string mensaje = "Hola Mundo";
        Console.WriteLine("  Texto: \"" + mensaje + "\"");
        Console.WriteLine("  Cantidad de caracteres: " + mensaje.Length);

        Console.WriteLine();

        // -------------------------------------------------------
        // RESUMEN
        // -------------------------------------------------------
        Console.WriteLine("================================================");
        Console.WriteLine("   RESUMEN");
        Console.WriteLine("================================================");
        Console.WriteLine("  +  -  *  /  %   → aritmética");
        Console.WriteLine("  == != < > <= >= → comparación (dan true/false)");
        Console.WriteLine("  (tipo)valor     → conversión explícita");
        Console.WriteLine("  .Length         → cantidad de caracteres");
        Console.WriteLine("================================================");
    }
}
