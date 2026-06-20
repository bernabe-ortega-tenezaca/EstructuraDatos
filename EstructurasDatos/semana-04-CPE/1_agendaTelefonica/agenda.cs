public class Agenda
{
    public string[] Nombres { get; set; }
    public string[] Telefonos { get; set; } 
    public int Cantidad { get; set; }

    public Agenda(){}

    public Agenda(int cantidad){
        Cantidad = cantidad;
        Nombres = new string[Cantidad];
        Telefonos = new string[Cantidad];  // Resultados: La asignación de memoria es dinamica y de acuerdo con la necesidad del usuario
                                           // Conclusiones: la asignación de memoría dinámica es beneficiosa debido a que se ajusta a la necesidad del usuario
                                           // Conclusiones: la asignación de memoría dinámica puede ser contraproducente porque el usuario puede saturar la memoria, o provocar errores

        // ///
        // /// otra alternativa
        // /// 
        // string[] telefonos = new string[1000];  // Resultados: Se implemento un array limitado a 10000 contactos de manera estática
        //                                         // Conclusión: El uso de arrays(vectores) es una limitante restringida a solamente 1000 registros
        //                                         // Conclusión: El uso de arrays(vectores) es beneficioso porque permite optimizar el uso de memoria
    }

    public void ImprimirContactos(){
        for (int i = 0; i < Nombres.Length; i++)
        {
            System.Console.WriteLine(Nombres[i] + " " + Telefonos[i]);
        }
    }


}