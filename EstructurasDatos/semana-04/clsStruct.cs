class clsStruct
{
    public static void Ejecutar()
    {
        Punto p1 = new Punto(3, 5);
        Punto p2 = p1;
        p2.X = 10;

        Console.WriteLine("p1: " + p1.X + ", " + p1.Y);
        Console.WriteLine("p2: " + p2.X + ", " + p2.Y);
    }
}

struct Punto
{
    public int X;
    public int Y;

    public Punto(int x, int y)
    {
        X = x;
        Y = y;
    }
}
