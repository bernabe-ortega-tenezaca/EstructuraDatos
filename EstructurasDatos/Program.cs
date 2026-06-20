int[] numeros = new int[5] { 10, 20, 30, 40, 50 };

Console.WriteLine(numeros[2]); 

// Console.WriteLine("La longitud del array es: " + numeros.Length);


// for (int i = 0; i < numeros.Length; i++)
// {
//     Console.WriteLine($"Número en posición {i}: {numeros[i]}");
// }

// foreach (int n in numeros)
// {
//     Console.WriteLine($"Número: {n}");
// }



// bool salir = false;

// while (!salir)
// {
//     Console.Clear();
//     Console.WriteLine("================================================");
//     Console.WriteLine("   UNIVERSIDAD ESTATAL AMAZONICA");
//     Console.WriteLine("   ESTRUCTURA DE DATOS");
//     Console.WriteLine("================================================");
//     Console.WriteLine();
//     Console.WriteLine("   MENÚ DE SEMANAS");
//     Console.WriteLine();
//     Console.WriteLine("    1.  Semana 01 - Tipos de datos básicos");
//     Console.WriteLine("    2.  Semana 02 - Operaciones con tipos básicos");
//     Console.WriteLine("    3.  Semana 03 - Arrays y matrices");
//     Console.WriteLine("    4.  Práctico Experimental 1");
//     Console.WriteLine("    5.  Semana 05");
//     Console.WriteLine("    6.  Semana 06");
//     Console.WriteLine("    7.  Semana 07");
//     Console.WriteLine("    8.  Práctico Experimental 2");
//     Console.WriteLine("    9.  Semana 09");
//     Console.WriteLine("   10. Semana 10");
//     Console.WriteLine("   11. Semana 11");
//     Console.WriteLine("   12. Práctico Experimental 3");
//     Console.WriteLine("   13. Semana 13");
//     Console.WriteLine("   14. Semana 14");
//     Console.WriteLine("   15. Semana 15");
//     Console.WriteLine("   16. Práctico Experimental 4");
//     Console.WriteLine();
//     Console.WriteLine("    0. Salir");
//     Console.WriteLine();
//     Console.Write("  Seleccione una opción: ");

//     string? input = Console.ReadLine();
//     Console.WriteLine();

//     switch (input)
//     {
//         case "1":
//             clsTiposBasicos.Ejecutar();
//             break;
//         case "2":
//             clsOperacionesTBasicos.Ejecutar();
//             break;
//         case "3":
//             clsArrayMatrices.Ejecutar();
//             break;
//         case "4":
//             Console.WriteLine("Práctico Experimental 1 - próximamente.");
//             break;
//         case "5":
//             Console.WriteLine("Semana 05 - próximamente.");
//             break;
//         case "6":
//             Console.WriteLine("Semana 06 - próximamente.");
//             break;
//         case "7":
//             Console.WriteLine("Semana 07 - próximamente.");
//             break;
//         case "8":
//             Console.WriteLine("Práctico Experimental 2 - próximamente.");
//             break;
//         case "9":
//             Console.WriteLine("Semana 09 - próximamente.");
//             break;
//         case "10":
//             Console.WriteLine("Semana 10 - próximamente.");
//             break;
//         case "11":
//             Console.WriteLine("Semana 11 - próximamente.");
//             break;
//         case "12":
//             Console.WriteLine("Práctico Experimental 3 - próximamente.");
//             break;
//         case "13":
//             Console.WriteLine("Semana 13 - próximamente.");
//             break;
//         case "14":
//             Console.WriteLine("Semana 14 - próximamente.");
//             break;
//         case "15":
//             Console.WriteLine("Semana 15 - próximamente.");
//             break;
//         case "16":
//             Console.WriteLine("Práctico Experimental 4 - próximamente.");
//             break;
//         case "0":
//             salir = true;
//             continue;
//         default:
//             Console.WriteLine("Opción no válida.");
//             break;
//     }

//     Console.WriteLine();
//     Console.Write("Presione Enter para continuar...");
//     Console.ReadLine();
// }