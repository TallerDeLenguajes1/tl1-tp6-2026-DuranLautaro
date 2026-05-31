// See https://aka.ms/new-console-template for more information
int a,b,opcion;
double c;
do
{
    Console.WriteLine("Seleccione la opcion deseada:\n");
    Console.Write("1.SUMAR,2.RESTAR,3.MULTIPLICAR,4.DIVIDIR\n");
    string entrada=Console.ReadLine();
    if(!int.TryParse(entrada,out opcion))
    {
        Console.WriteLine("Numero invalido. Intente nuevamente\n");
    }
    else
    {
        if(opcion!=0)
        {
            Console.Write("Ingresar dos numeros enteros positivos:\n");
            string n1=Console.ReadLine(),n2=Console.ReadLine();
            int.TryParse(n1,out a);
            int.TryParse(n2,out b);
            int resultado=0;
            switch(opcion)
            {
                //SUMA ENTRE DOS NUMEROS
                case 1:
                resultado=a+b;
                break;
                //RESTA ENTRE DOS NUMEROS
                case 2:
                resultado=a-b;
                break;
                //MULTIPLICACION ENTRE DOS NUMEROS
                case 3:
                resultado=a*b;
                break;
                //DIVISION ENTRE DOS NUMEROS
                case 4:
                resultado=a/b;
                break;
                default:
                Console.Write("Opcion invalida\n");
                break;
            }
            Console.WriteLine("Resultado:"+resultado);
        }
        Console.Write("1.Valor absoluto ,2.Numero al cuadrado,3.Raiz cuadrada,4.Seno de un numero 5.Coseno de un numero, 6.Parte entera de un numero real:");
         Console.Write("Ingresar un numero entero:\n");
            string n=Console.ReadLine();
            double.TryParse(n,out c);
            double r=0;
            switch(opcion)
            {
                //VALOR ABSOLUTO
                case 1:
                r=Math.Abs(c);
                break;
                //Cuadrado
                case 2:
                r=Math.Pow(c,2);
                break;
                //LA RAIZ CUADRADA
                case 3:
                r=Math.Sqrt(c);
                break;
                //SENO
                case 4:
                r=Math.Sin(c);
                break;
                //COSENO
                case 5:
                r=Math.Cos(c);
                break;
                //PARTE ENTERA DE UN FLOAT
                case 6:
                r=Math.Truncate(c);
                break;
                default:
                Console.Write("Opcion invalida\n");
                break;
            }
            Console.WriteLine("Resultado:"+r);
            Console.Write("Ingresar dos numeros enteros:\n");
            int d,e;
            string n1=Console.ReadLine();
            string n2=Console.ReadLine();
            
           
            if(!int.TryParse(n1,out d) || !int.TryParse(n2,out e))
            {
                Console.Write("Uno de los numeros es invalido. Intente nuevamente");
            }
            else
            {
                Console.WriteLine("El numero maximo es: " + Math.Max(d, e));
                Console.WriteLine("El numero minimo es: " + Math.Min(d, e));
            }
        }

        Console.Write("Desea realizar otro calculo?Si/No:");
        string respuesta=Console.ReadLine();
      
        if(respuesta.ToLower()=="no") //tolower convierte string en minusculas
        {
            opcion=0;
        }
}while(opcion!=0);
