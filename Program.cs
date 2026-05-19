// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
/*Problema 1*/
int i;
Console.WriteLine("Ingresar un numero entero positivo");
string x=Console.ReadLine();
bool resultado=int.TryParse(x, out i);// transformo tipo de dato string a int
Console.WriteLine("valor de i:"+i);
int invertido=0;
int aux=i;
while (resultado && aux>0)
{
    int dig=aux%10;
    invertido=invertido*10+dig;
    aux=aux/10;
}
if(i>0)
{
    Console.WriteLine($"Numero invertido:{invertido}");
}
