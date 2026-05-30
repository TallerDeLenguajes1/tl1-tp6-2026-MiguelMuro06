/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/

// MOSTRAR TEXTO EN PANTALLA Y LEER LA ENTRADA

/*
Console.WriteLine("Ingrese un numero entero mayor que 0: ");
string entrada = Console.ReadLine();

"Console.WriteLine": sirve para mostrar mensaje

"string entrada": En C# las cadenas de texto son un tipo nativo llamado string.
Acá guardamos lo que el usuario tipea tal cual.

"Console.ReadLine": Lee toda la línea de texto que el usuario ingresa desde la terminal.
*/

//DECLARAR VARIABLES Y VALIDAR (la condicion)

/*
int numero; // Declaramos una variable entera para guardar el número convertido.

if (int.TryParse(entrada, out numero))
{
    // Si entra acá, significa que el texto SÍ era un número válido y se guardó en "numero"
    if (numero > 0)
    {
        // ¡Perfecto! El número es válido y mayor a 0. Acá va la lógica para invertirlo.
    }
    else
    {
        Console.WriteLine("Error: El número debe ser mayor a 0.");
    }
}
else
{
    Console.WriteLine("Error: No ingresaste un número entero válido.");
}

*if (condicion): Funciona exactamente igual que en C.

*int.TryParse(entrada, out numero): Intenta convertir el string entrada en el int numero.
Si sale bien, devuelve true y llena la variable.
Si meten verdura (ej: "hola"), devuelve false y va directo al else.


*/

/*
int numeroInvertido = 0;
int auxiliar = numero; // Usamos una copia para no perder el valor original

while (auxiliar > 0)
{
    int resto = auxiliar % 10;                  // Tomamos el último dígito
    numeroInvertido = (numeroInvertido * 10) + resto; // Lo vamos armando al revés
    auxiliar = auxiliar / 10;                   // Le quitamos el último dígito
}

// Mostramos el resultado combinando texto y variables (Interpolación)
Console.WriteLine($"Número original: {numero}");
Console.WriteLine($"Número invertido: {numeroInvertido}");

*Console.WriteLine($"..."): Esto se llama Interpolación de cadenas.
Si le ponés el signo $ antes de las comillas, podés meter variables directamente adentro del texto usando llaves {}.
Es muchísimo más cómodo y moderno que usar los viejos %d de C.

*/

//Preguntas que tengo yo

/*

° ¿Que significa usar el using al inicio?

En C#, para tener el código ordenado, Microsoft organiza las miles de funciones y clases que existen dentro de cajas llamadas Espacios de nombres (Namespaces). 
La palabra clave "using" sirve para decirle al compilador: "Che, abrí esa caja porque voy a usar las herramientas que están adentro". 
System es la caja principal y más importante de toda la plataforma .NET.
Adentro de la caja System viven las herramientas fundamentales de la consola, como Console.WriteLine(), Console.ReadLine(), o los tipos de datos básicos.

°¿Qué pasa si no lo ponés?
Si no escribís using System; arriba, el compilador no va a saber de dónde sacaste el objeto Console y te va a tirar un error.
Para que funcione sin el using, estarías obligado a escribir el nombre completo ("la ruta absoluta") de la herramienta cada vez que la uses,así:
// Sin el using System, tendrías que escribirlo así:
System.Console.WriteLine("Hola Miguel");

DEBO ESCRIBIR TODO EN MAYUSCULA DONDE SE DEBE, SINO ME DARA ERROR

°¿Que hace la funcion int.TryParse(entrada, out numero) y todo los argumentos que estan adentro?
En términos simples, int.TryParse() es un extractor y un filtro de seguridad todo en uno.
Su trabajo es agarrar una cadena de texto, fijarse si tiene la forma de un número entero y, si es así,
transformarla en un número real para que puedas hacer operaciones matemáticas.

int.TryParse(  entrada  ,  out numero  )
               └───┬───┘      └───┬──┘
             Argumento 1     Argumento 2

1. El primer argumento: "entrada"
Es el texto de origen que querés evaluar.
En nuestro caso, es la variable de tipo string donde guardamos lo que el usuario escribió en la consola (Console.ReadLine()). 
La función va a leer este string carácter por carácter para verificar si contiene un número válido
(por ejemplo, "123" es válido, pero "12a3" o "hola" no).  

2. El segundo argumento: out numero
Acá está el secreto de C#.
Este argumento tiene dos partes: la palabra clave out y la variable numero donde querés guardar el resultado.
¿Qué significa out? En C, si vos querías que una función modificara el valor de una variable externa,
tenías que pasarle la dirección de memoria usando un puntero con el símbolo & (como hacías en scanf("%d", &numero)).
En C#, en lugar de andar lidiando con punteros manuales, usamos la palabra clave out (que viene de output o salida).
Le dice al compilador: "Te paso esta variable vacía para que la función la llene con el resultado adentro".
La variable numero: Si la conversión del texto sale bien, int.TryParse inyecta el valor numérico directamente en esta variable.
Si la conversión falla (porque metieron letras), automáticamente le asigna un 0 por seguridad. 

*/
using System;

Console.WriteLine("Ingrese un numero entero mayor que cero: ");
string entrada = Console.ReadLine();

int numero;

if(int.TryParse(entrada, out numero))
{
    
    if(numero > 0)
    {
        int numeroInvertido=0;
        int auxiliar = numero;

        while(auxiliar >0)
        {
            int resto = auxiliar %10;
            numeroInvertido = (numeroInvertido * 10) + resto;
            auxiliar = auxiliar / 10;
        }
        Console.WriteLine($"Numero original: {numero}");
        Console.WriteLine($"Numero invertido: {numeroInvertido}");
    }
    else
    {
        Console.WriteLine("El numero debe ser mayor que 0");
    }
}
else
{
    Console.WriteLine("Error: La entrada ingresada no es un número entero válido");
}


