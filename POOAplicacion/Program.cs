using POOAplicacion;

Concesionario concesionario = new Concesionario();
Coche coche = new Coche();
string opcion = "Menu";
while (opcion != "5")
{
    Console.WriteLine("Menu\n" + "1-Agregar Coche\n" + "2-Elimiar Coche\n" +
                  "3-Eliminar todos los coches\n" + "4-Stock de Coches\n" +
                  "5-Salir");
    opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Escribe la marca:");
            coche.marca = Console.ReadLine();
            Console.WriteLine("Escribe el modelo:");
            coche.modelo = Console.ReadLine();
            Console.WriteLine("Escribe el kilometraje:");
            string _km = Console.ReadLine();
            coche.km = int.Parse(_km);
            Console.WriteLine("Escribe el precio:");
            string _precio = Console.ReadLine();
            coche.precio = double.Parse(_precio);
            concesionario.AñadirCoche(coche);
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Carros en Stock:");
            concesionario.MostrarCoches();
            Console.WriteLine("Seleccione el id para eliminar");
            string eliminarposicion = Console.ReadLine();
            int i = int.Parse(eliminarposicion);
            concesionario.EliminarCoche(concesionario.coches[i]);
            break;
        case "3":
            Console.Clear();
            concesionario.VaciarCoches();
            break;
        case "4":
            Console.Clear();
            concesionario.MostrarCoches();
            break;
        case "5":
            opcion = "5";
            break;
        default:
            break;
    }
}


