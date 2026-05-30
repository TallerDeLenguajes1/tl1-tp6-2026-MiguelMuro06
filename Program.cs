using System;

bool continuar  = true ;

while (continuar)
{
    Console.WriteLine("--- Calculadora -----");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Elija la opcion que desee (1-5): ");

    string opcion = Console.ReadLine();

    if(opcion == "5")
    {
        continuar = false;
        Console.WriteLine("Gracias por usar la calculadora");
        break;
    }
    if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5")
    {
        Console.WriteLine("Opcion invalida. Intente nuevamente");
        continue;
    }

    //Ingreso del 1er numero
    double num1 = 0;
    bool num1Valido = false;
    while (!num1Valido)
    {
        Console.WriteLine("Ingrese el primer numero: ");
        string input1 = Console.ReadLine();
        num1Valido = double.TryParse(input1, out num1);
        if (!num1Valido)
        {
            Console.WriteLine("Ingreso un numero no valido. Ingrese un numero real");
        }
    }

    //Ingreso del 2do numero
    double num2 = 0;
    bool num2Valido = false;
    while (!num2Valido)
    {
        Console.WriteLine("Ingrese el segundo numero: ");
        string input2 = Console.ReadLine();
        num2Valido = double.TryParse(input2, out num2);
        if (!num2Valido)
        {
            Console.WriteLine("Ingreso un numero no valido. Ingrese un numero real por favor");
        }
    }


    //operaciones
    double resultado;
    bool opcionExitosa = true;
    switch (opcion)
    {
        case "1":
            resultado = num1 + num2;
            Console.WriteLine($"La suma de {num1} y {num2} es: {resultado}");
            break;

        case "2":
            resultado = num1 - num2;
            Console.WriteLine($"La resta de {num1} y {num2} es: {resultado}");
            break;
        
        case "3":
            resultado = num1 * num2;
            Console.WriteLine($"La multiplicacion de {num1} y {num2} es: {resultado}");
            break;

        case "4":
            if(num2 == 0)
            {
                Console.WriteLine("No se puede dividir por cero");
                opcionExitosa = false;
            }
            else
            {
                resultado = num1 / num2;
                Console.WriteLine($"La division de {num1} y {num2} es: {resultado}");
            }
            break;
    }

    //opcion de si desea continua
    if (opcionExitosa)
    {
        Console.WriteLine("\n ¿Desea realizar otra operacion? (s/n): ");
        string respuesta = Console.ReadLine().ToLower(); // Convertimos a minúscula para aceptar 'S' o 's'
        if (respuesta != "s" && respuesta != "si")
        {
            continuar = false;
            Console.WriteLine("Gracias por usar la calculadora");
        }

    }
}