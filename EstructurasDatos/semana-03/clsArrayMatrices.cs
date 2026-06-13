class clsArrayMatrices
{
    public static void Ejecutar()
    {
        Console.WriteLine("================================================");
        Console.WriteLine("   ARRAYS Y MATRICES");
        Console.WriteLine("================================================");
        Console.WriteLine();

        // -------------------------------------------------------
        // 1. ARRAY UNIDIMENSIONAL (vector)
        // -------------------------------------------------------
        Console.WriteLine("--- 1. ARRAY (vector) ---");
        Console.WriteLine("Un array guarda VARIOS valores del mismo tipo en una sola variable.");
        Console.WriteLine();

        // Declarar e inicializar un array de enteros
        int[] numeros = { 10, 20, 30, 40, 50 };

        Console.WriteLine("  int[] numeros = { 10, 20, 30, 40, 50 };");
        Console.WriteLine();

        // Acceder a cada posición (índice empieza en 0)
        Console.WriteLine("  El primer elemento (índice 0): " + numeros[0]);
        Console.WriteLine("  El tercer elemento (índice 2): " + numeros[2]);
        Console.WriteLine("  El último elemento (índice 4): " + numeros[4]);
        Console.WriteLine();

        // Recorrer el array con un bucle
        Console.WriteLine("  Recorrer todo el array:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("    numeros[" + i + "] = " + numeros[i]);
        }

        Console.WriteLine();

        // Modificar un valor
        numeros[2] = 99;
        Console.WriteLine("  Cambiamos numeros[2] a 99:");
        Console.WriteLine("  numeros[2] ahora vale: " + numeros[2]);
        Console.WriteLine();

        // Longitud del array
        Console.WriteLine("  El array tiene " + numeros.Length + " elementos.");
        Console.WriteLine();

        // -------------------------------------------------------
        // 2. OTRA FORMA DE DECLARAR ARRAYS
        // -------------------------------------------------------
        Console.WriteLine("--- 2. DECLARAR PRIMERO, ASIGNAR DESPUÉS ---");

        int[] vacio = new int[3]; // crea un array de 3 enteros (inicialmente en 0)
        vacio[0] = 7;
        vacio[1] = 8;
        vacio[2] = 9;

        Console.WriteLine("  int[] vacio = new int[3];");
        Console.WriteLine("  vacio[0]=7, vacio[1]=8, vacio[2]=9");
        for (int i = 0; i < vacio.Length; i++)
        {
            Console.WriteLine("    vacio[" + i + "] = " + vacio[i]);
        }

        Console.WriteLine();

        // -------------------------------------------------------
        // 3. MATRIZ BIDIMENSIONAL (tabla)
        // -------------------------------------------------------
        Console.WriteLine("--- 3. MATRIZ (tabla de 2 dimensiones) ---");
        Console.WriteLine("Una matriz tiene filas y columnas, como una hoja de cálculo.");
        Console.WriteLine();

        // Declarar una matriz de 3 filas x 4 columnas
        int[,] matriz = new int[3, 4];

        // Llenar algunos valores
        // Fila 0
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[0, 2] = 3;
        matriz[0, 3] = 4;
        // Fila 1
        matriz[1, 0] = 5;
        matriz[1, 1] = 6;
        matriz[1, 2] = 7;
        matriz[1, 3] = 8;
        // Fila 2
        matriz[2, 0] = 9;
        matriz[2, 1] = 10;
        matriz[2, 2] = 11;
        matriz[2, 3] = 12;

        Console.WriteLine("  Matriz de 3 filas x 4 columnas:");
        Console.WriteLine();

        // Recorrer la matriz con dos bucles anidados
        for (int fila = 0; fila < 3; fila++)
        {
            Console.Write("    Fila " + fila + ": ");
            for (int col = 0; col < 4; col++)
            {
                Console.Write(matriz[fila, col].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("  Acceder a un elemento:");
        Console.WriteLine("  matriz[1, 2] = " + matriz[1, 2]); // fila 1, columna 2
        Console.WriteLine();

        // -------------------------------------------------------
        // 4. MATRIZ CON VALORES INICIALES
        // -------------------------------------------------------
        Console.WriteLine("--- 4. MATRIZ INICIALIZADA DIRECTAMENTE ---");

        int[,] tabla = {
            { 2, 4, 6 },
            { 1, 3, 5 },
            { 9, 8, 7 }
        };

        Console.WriteLine("  int[,] tabla = {");
        Console.WriteLine("    { 2, 4, 6 },");
        Console.WriteLine("    { 1, 3, 5 },");
        Console.WriteLine("    { 9, 8, 7 }");
        Console.WriteLine("  };");
        Console.WriteLine();

        Console.WriteLine("  Recorrer la tabla:");
        for (int f = 0; f < 3; f++)
        {
            Console.Write("    ");
            for (int c = 0; c < 3; c++)
            {
                Console.Write(tabla[f, c] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // -------------------------------------------------------
        // 5. ARRAY DE STRINGS
        // -------------------------------------------------------
        Console.WriteLine("--- 5. ARRAY DE TEXTO (string) ---");

        string[] nombres = { "Ana", "Luis", "Sofía", "Carlos" };

        Console.WriteLine("  string[] nombres = { \"Ana\", \"Luis\", \"Sofía\", \"Carlos\" };");
        Console.WriteLine();
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine("    nombres[" + i + "] = " + nombres[i]);
        }

        Console.WriteLine();

        // -------------------------------------------------------
        // RESUMEN
        // -------------------------------------------------------
        Console.WriteLine("================================================");
        Console.WriteLine("   RESUMEN");
        Console.WriteLine("================================================");
        Console.WriteLine("  int[] arr         → array de 1 dimensión");
        Console.WriteLine("  int[,] mat        → matriz de 2 dimensiones");
        Console.WriteLine("  arr[i]            → acceder / modificar posición");
        Console.WriteLine("  arr.Length        → cantidad de elementos");
        Console.WriteLine("  new int[n]        → crear array vacío de tamaño n");
        Console.WriteLine("  for + Length      → recorrer todo el array");
        Console.WriteLine("================================================");
    }
}
