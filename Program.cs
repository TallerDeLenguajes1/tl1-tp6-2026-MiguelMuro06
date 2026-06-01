using System;

bool continuar  = true ;

while (continuar)
{
    Console.WriteLine("--- CalculadoraV2 -----");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Funciones Cientificas(Un solo numero)");
    Console.WriteLine("6. Maximo y minimo (dos numeros)");
    Console.WriteLine("7. Salir");
    Console.Write("Elija la opcion que desee (1-7): ");

    string opcion = Console.ReadLine();

    if(opcion == "7")
    {
        continuar = false;
        Console.WriteLine("Gracias por usar la calculadora");
        break;
    }
    if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "7")
    {
        Console.WriteLine("Opcion invalida. Intente nuevamente");
        continue;
    }

    if(opcion == "5")
    {
        double numero =0;
        bool numValido = false;

        while (!numValido)
        {
            Console.Write("Ingrese el numero: ");
            string input = Console.ReadLine();
            numValido = double.TryParse(input, out numero);
            if (!numValido)
            {
                Console.WriteLine("Ingreso un numero no valido.Ingrese un numero real");
            }
        
        }

        double valorAbsoluto = Math.Abs(numero);
        double Cuadrado = Math.Pow(numero, 2);
        double seno = Math.Sin(numero);
        double coseno = Math.Cos(numero);
        int parteEntera = (int)numero;
        Console.WriteLine($"Resultados para el numero: {numero}");
        Console.WriteLine($"Valor Absoluto: {valorAbsoluto}");
        Console.WriteLine($"El cuadrado: {Cuadrado}");
        
        if (numero >= 0)
        {
            double raizCuadrada= Math.Sqrt(numero);
            Console.WriteLine($"La Raiz Cuadrada es: {raizCuadrada}");
        }
        else
        {
            Console.WriteLine("No se puede calcular la raiz cuadrada de un numero negativo");
            
        }
        Console.WriteLine($"El seno: {seno}");
        Console.WriteLine($"El coseno: {coseno}");
        Console.WriteLine($"La parte entera es: {parteEntera}");

    }

    else if(opcion == "6")
    {    
        double val1 = 0, val2 = 0;
        bool v1Valido = false, v2Valido = false;
        while(!v1Valido)
        {
            Console.Write("Ingrese el primer numero: ");
            string v1Input = Console.ReadLine();
            v1Valido = double.TryParse(v1Input, out val1);
            if (!v1Valido)
            {
                Console.WriteLine("Ingreso un numero no valido. Ingrese un numero real");
            }
        }
        
        while(!v2Valido)
        {
            Console.Write("Ingrese el segundo numero: ");
            string v2Input = Console.ReadLine();
            v2Valido = double.TryParse(v2Input, out val2);
            if (!v2Valido)
            {
                Console.WriteLine("Ingreso un numero no valido. Ingrese un numero real");
            }
        }
        double maximo = Math.Max(val1, val2);
        double minimo = Math.Min(val1, val2);

        Console.WriteLine($"Comparacion entre {val1} y {val2}");
        Console.WriteLine($"Maximo es: {maximo}");
        Console.WriteLine($"Minimo es: {minimo}");
    }

    else
    {
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
            }
            else
            {
                resultado = num1 / num2;
                Console.WriteLine($"La division de {num1} y {num2} es: {resultado}");
            }
            break;
    }
    }
    //opcion de si desea continua

    Console.WriteLine("\n ¿Desea realizar otra operacion? (s/n): ");
    string respuesta = Console.ReadLine().ToLower(); // Convertimos a minúscula para aceptar 'S' o 's'
    if (respuesta != "s" && respuesta != "si")
    {
        continuar = false;
        Console.WriteLine("Gracias por usar la calculadora");
    }

}