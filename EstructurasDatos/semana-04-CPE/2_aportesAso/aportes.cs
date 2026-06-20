public class Aportes{
    public double[] Aportaciones { get; set; }
    //public Trabajador[] Empleados { get; set; } ///1000 trabajadores
    public string[] Cedulas { get; set; }
    public string[] Nombres { get; set; }
    public DateTime[] Fechas{ get; set; } 

    public int Cantidad { get; set; }


    //public Aportes(){}
    public Aportes(){
        Cantidad = 1000;
        Aportaciones = new double[Cantidad];
        // Empleados = new Trabajador[Cantidad];
        Fechas = new DateTime[Cantidad];

    }
}