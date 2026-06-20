class clsRecord
{
    public static void Ejecutar()
    {
        Persona p1 = new Persona("Ana", 25);
        Persona p2 = new Persona("Ana", 25);
        Persona p3 = p1 with { Edad = 26 };

        Console.WriteLine("p1: " + p1);
        Console.WriteLine("p2: " + p2);
        Console.WriteLine("p1 == p2: " + (p1 == p2));
        Console.WriteLine("p3: " + p3);
    }
}

record Persona(string Nombre, int Edad);
