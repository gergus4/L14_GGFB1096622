string opcion;

Console.WriteLine("Bienvenido al programa de la empresa");
Console.WriteLine("Ingrese la opcion deseada: ");

Console.WriteLine("Ingrese (1) si desea saber la edad de una persona");
Console.WriteLine("Ingrese (2) si desea saber los salarios de los trabajadores");
Console.WriteLine("Ingrese (3) si desea salir del programa");
opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        string[] name = new string[5];
        int[] año = new int[5];
        int edad = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese el nombre de la persona:");
            name[i] = Console.ReadLine();

            Console.WriteLine("Ingrese el año de nacimiento de esa persona:");
            año[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            edad = 2022 - año[i];

            Console.WriteLine("La edad de: "+ name[i] + " es: " +edad);
        }
        break; 



    case "2":
        string[] puesto = new string[5];
        double[] pago = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un puesto de trabajo:");
            puesto[i] = Console.ReadLine();

            Console.WriteLine("Ingrese el salario de ese puesto:");
            pago[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("El puesto: "+puesto[i] + " gana: " + pago[i]);
        }
        break;


    case "3":
        Console.WriteLine("El programa ha sido cerrado"); 
    break;

    default:
        Console.WriteLine("Ha ingresado un número inválido");
    break; 
}