using Arreglos.Logica;

Console.WriteLine("Operaciones de pila");

Console.WriteLine("Arreglo ");
MiArreglo oMiArreglo = new MiArreglo(5);

try
{
    oMiArreglo.Agregar(7);
    oMiArreglo.Agregar(-2);
    oMiArreglo.Agregar(8);
    Console.WriteLine(oMiArreglo);

    Console.ReadKey();
    Console.WriteLine("Insertar 500 en la posicion 1");
    oMiArreglo.Insertar(500, 1);
    Console.WriteLine(oMiArreglo);
    
    Console.WriteLine("Eliminar 500 en la posicion 1");
        Console.ReadKey();
    oMiArreglo.Eliminar(1);
    Console.WriteLine(oMiArreglo);  


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    
}




//oMiArreglo.Llenar(1, 20);



//Console.WriteLine("Arreglo desordenado\n");
//Console.WriteLine(oMiArreglo);


//Console.WriteLine("Arreglo ordenado ascendente\n");
//oMiArreglo.Ordenar();
//Console.WriteLine(oMiArreglo);


//Console.WriteLine("Arreglo ordenado descendente\n");
//oMiArreglo.Ordenar(false);
//Console.WriteLine(oMiArreglo);








Console.ReadKey();
