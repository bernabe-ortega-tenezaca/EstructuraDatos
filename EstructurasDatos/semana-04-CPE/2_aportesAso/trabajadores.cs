public class Trabajador{
    public int Codigo { get; set; }
    public string Nombres { get; set; }

    public Trabajador(){}

    public Trabajador(int codigo, string nombre){
        Codigo = codigo;
        Nombres = nombre;
    }
}