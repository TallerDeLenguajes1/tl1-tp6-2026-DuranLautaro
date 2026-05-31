¿String es una tipo por valor o un tipo por referencia?
Si, se guarda la direccion de memoria la cual esta apuntando a ese dato
¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape que tiene el tipo string son:
1. /
2. $
3. @
¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Con $, se escribe antes de la palabra a ingresar y permite insertar variables dentro del string.Ejemplo:
string nombre="Simon";
Console.Write($"Hola {nombre}");
Con @, se toma todo lo escrito en mi cadena string, es decir, las demas secuencias de escape no tienen efecto en este tipo de cadena cuando se utilice @. Ejemplo:
string palabra=@"hola soy
lauti"; 
Debo hacer el salto de linea manualmente en lugar de hacer \n