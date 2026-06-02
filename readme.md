*¿String es una tipo por valor o un tipo por referencia?
string es un tipo por referencia. Aunque se comporta de forma parecida a un tipo valor (porque es inmutable y cuando lo modificás parece que se creara una copia), internamente en la memoria de .NET no guarda el texto directamente en la variable, sino que almacena un puntero o referencia a la ubicación del Heap donde está alojado el objeto con la cadena de caracteres.

*¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape son combinaciones de caracteres que arrancan con una barra invertida \ y sirven para meter caracteres especiales adentro del texto. Las principales son:

1. \n: Salto de línea (Nueva línea).
2. \t: Tabulador horizontal.
3. \": Comilla doble (para poder poner comillas adentro de un texto sin que rompa el string).
4. \\: Barra invertida simple.
5. \0: Carácter nulo.

*¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
El carácter $ (Interpolación de cadenas): Activa la forma moderna de formatear texto. Te permite incrustar variables o expresiones matemáticas directamente adentro del texto usando llaves {} (por ejemplo: $ "El resultado es {resultado}" ), haciendo que el código sea mucho más legible que concatenar con el signo +.
El carácter @ (Literales de cadena textuales / Verbatim strings): Le ordena al compilador que lea el string exactamente tal cual está escrito, anulando por completo todas las secuencias de escape. Es extremadamente útil para dos cosas:
1. Escribir rutas de archivos de Windows sin tener que duplicar las barras (ejemplo: @"D:\Dotnet\sdk" en lugar de "D:\\Dotnet\\sdk").
2. Escribir textos largos que ocupan varios renglones (saltos de línea presionando Enter en el editor) sin tener que usar \n.
