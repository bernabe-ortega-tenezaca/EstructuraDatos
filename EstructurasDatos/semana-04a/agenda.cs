class clsAgenda
{
    static string[] nombres = new string[100];
    static string[] telefonos = new string[100];
    static int total = 0;
    static string archivo = "agenda.txt";

    public static void Ejecutar()
    {
        Cargar();
        int opcion;

        do
        {
            Console.WriteLine("\n--- AGENDA ---");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Ver contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine()!);

            switch (opcion)
            {
                case 1: Agregar(); break;
                case 2: Listar(); break;
                case 3: Buscar(); break;
            }
        } while (opcion != 0);
    }

    static void Agregar()
    {
        Console.Write("Nombre: ");
        nombres[total] = Console.ReadLine()!;
        Console.Write("Telefono: ");
        telefonos[total] = Console.ReadLine()!;
        total++;
        Guardar();
    }

    static void Listar()
    {
        Console.WriteLine("\nContactos:");
        for (int i = 0; i < total; i++)
            Console.WriteLine((i + 1) + ". " + nombres[i] + " - " + telefonos[i]);
    }

    static void Buscar()
    {
        Console.Write("Nombre a buscar: ");
        string busq = Console.ReadLine()!;
        for (int i = 0; i < total; i++)
            if (nombres[i].ToLower().Contains(busq.ToLower()))
                Console.WriteLine(nombres[i] + " - " + telefonos[i]);
    }

    static void Guardar()
    {
        using StreamWriter sw = new StreamWriter(archivo);
        for (int i = 0; i < total; i++)
            sw.WriteLine(nombres[i] + "|" + telefonos[i]);
    }

    static void Cargar()
    {
        if (!File.Exists(archivo)) return;
        foreach (string linea in File.ReadLines(archivo))
        {
            string[] partes = linea.Split('|');
            nombres[total] = partes[0];
            telefonos[total] = partes[1];
            total++;
        }
    }
}
