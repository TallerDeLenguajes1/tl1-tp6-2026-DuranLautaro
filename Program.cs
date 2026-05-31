// See https://aka.ms/new-console-template for more information
string cadena="Hola me llamo Lautaro,";
Console.Write($"Longitud de la cadena:{cadena.Length}\n");
string cadena2=" Y estudio ingenieria informatica";
string concatenar=cadena+cadena2;
Console.Write(concatenar);
string subcadena=cadena.Substring(8,5); //substring(posicion,tomo los caracteres desde esa posicion en adelante)
Console.Write($"\nSubcadena: {subcadena}\n");
//Metodo Tostring convierte cualquier tipo de dato a string
Console.Write("Muestro caracter por caracter con foreach:\n");
foreach (char c in concatenar)
{
    Console.Write(c);
}
Console.Write($"Cadena en minusculas:{subcadena.ToLower()}, Cadena en mayusculas: {subcadena.ToUpper()}");
string cadena3="Cartuchera Libro Cuaderno";
string[] cadenasinseparador=cadena3.Split(" ");
Console.Write("\nCadena sin separadores:\n");
foreach (string cad in cadenasinseparador) {
    Console.Write(cad);
}

