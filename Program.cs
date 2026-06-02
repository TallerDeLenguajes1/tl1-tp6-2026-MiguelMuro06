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
/*
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
*/

using System;

//Ingresa la oracion
Console.Write("Ingrese una oracion o una frase: ");
string oracion = Console.ReadLine();

//longitud de la cadena
int longitud = oracion.Length;
Console.WriteLine($"La longitud de la cadena es: {longitud}");


//ingresamos la 2da oracion o frase
Console.Write("Ingrese una 2da oracion o frase: ");
string oracionSecundaria = Console.ReadLine();

//Concatenamos la cadena
string cadenaConcatenada = string.Concat(oracion," " , oracionSecundaria);
Console.WriteLine($"Cadena Concatenada: {cadenaConcatenada}");

//3. Extraer la subcadena

int extraer = Math.Min(5, longitud);
string subcadena= oracion.Substring(0, extraer);
Console.WriteLine($"Extraimos esta cantidad de caracteres {extraer} y la subcadena es la siguiente: {subcadena}");

// 4. Simulamos la calculadora y mostramos el metodo ToString()
double num1 = 582 , num2 = 2;
double resultado = num1 + num2 ;
string mensajeCalculadora = $"la suma de {num1.ToString()} y de {num2.ToString()} es igual a: {resultado.ToString()}";
Console.WriteLine($"\n4. Simulación Calculadora (ToString): {mensajeCalculadora}");

// 5. Recorrer la cadena con un ciclo Foreach elemento por elemento
Console.WriteLine("Recorriendo la cadenade caracter por caracter con foreach:");
foreach ( char caracter in oracion)
{
    Console.Write($"[{caracter}]");
}
Console.WriteLine();

//6. Buscar la ocurrencia de una palabra determinada
Console.Write("Ingrese una palabra para buscar en la frase del inicio: ");
string palabraBuscar = Console.ReadLine();
bool contienePalabra = oracion.Contains(palabraBuscar);

// También buscamos en qué índice empieza usando IndexOf
int posicion = oracion.IndexOf(palabraBuscar);

if (contienePalabra)
{
    Console.WriteLine($"¡Palabra encontrada! Comienza en el índice de posición: {posicion}");
}
else
{
    Console.WriteLine("La palabra no se encuentra en la cadena original.");
}

// 7. Convertir la cadena en minuscula o mayuscula
Console.WriteLine($"Cadena en MAYUSCULA: {oracion.ToUpper()} ");
Console.WriteLine($"Cadena en minuscula: {oracion.ToLower()} ");

// 8. Ingrese una cadena separada por caracteres y mostrar el resultado de Split()
Console.WriteLine("\n Probando el metodo split():");
Console.Write("Ingrese palabras separadas por comas (termo,yerba,azucar):");
string cadenaSeparar = Console.ReadLine();
string[] resultadoSplit = cadenaSeparar.Split(",");
foreach (string elemento in resultadoSplit)
{
    Console.WriteLine($"- {elemento.Trim()}"); // Trim quita espacios sobrantes a los costados
}

Console.WriteLine("\n--- PARSER DE ECUACIONES SIMPLES ---");
Console.Write("Ingrese una ecuación simple de suma (ej: 582+2): ");
string ecuacion = Console.ReadLine();

// Buscamos si la cadena contiene el signo '+' para procesarla
if (ecuacion.Contains("+"))
{
    // Usamos Split para picar la cadena en dos partes usando el '+' como cuchillo
    string[] operandos = ecuacion.Split('+');

    // Verificamos que efectivamente tengamos dos partes de texto
    if (operandos.Length == 2)
    {
        double n1 = 0, n2 = 0;
        // Validamos que ambos bloques de texto sean números reales válidos
        if (double.TryParse(operandos[0].Trim(), out n1) && double.TryParse(operandos[1].Trim(), out n2))
        {
            double sumaEcuacion = n1 + n2;
            Console.WriteLine($"Resultado de resolver la ecuación: {n1} + {n2} = {sumaEcuacion}");
        }
        else
        {
            Console.WriteLine("Error: Los operandos de la ecuación no son números válidos.");
        }
    }
    else
    {
        Console.WriteLine("Error: Formato de ecuación incorrecto.");
    }
}
else
{
    Console.WriteLine("Error: Este parser simplificado solo resuelve operaciones con el signo '+'.");
}

/*
**cadenaPrincipal.Length: Propiedad nativa que te tira la cantidad exacta de caracteres que tiene el texto. 

**string.Concat(a, b): Método oficial para pegar dos o más cadenas de texto en bloque.

**cadena.Substring(inicio, longitud): Extrae un pedazo de texto empezando desde la posición que le digas.

**foreach (char caracter in cadena): Como en C# los strings son internamente colecciones de objetos Char de solo lectura ,
   los podés recorrer directamente con un bucle foreach renglón por renglón sin necesidad de usar un clásico índice i de un for. 

**cadena.Split('+'): Esta función es una locura de cómoda.
  Agarra un texto largo y lo corta en pedazos cada vez que encuentra el carácter separador que vos le indiques,
  guardando los fragmentos adentro de un arreglo de strings (string[]).
  Es la herramienta ideal que te pedía la cátedra para romper "582+2" en dos números limpios sueltos. 
*/