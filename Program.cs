// See https://aka.ms/new-console-template for more information
double c;
int opcion;
do
{
    Console.WriteLine("Seleccione la opcion deseada:\n");
    Console.Write("1.Valor absoluto ,2.Numero al cuadrado,3.Raiz cuadrada,4.Seno de un numero 5.Coseno de un numero, 6.Parte entera de un numero real:");
    string entrada=Console.ReadLine();
    if(!int.TryParse(entrada,out opcion))
    {
        Console.WriteLine("Numero invalido. Intente nuevamente\n");
    }
    else
    {
        if(opcion!=0)
        {
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
            int a,b;
            string n1=Console.ReadLine();
            string n2=Console.ReadLine();
            
           
            if(!int.TryParse(n1,out a) || !int.TryParse(n2,out b))
            {
                Console.Write("Uno de los numeros es invalido. Intente nuevamente");
            }
            else
            {
                Console.WriteLine("El numero maximo es: " + Math.Max(a, b));
                Console.WriteLine("El numero minimo es: " + Math.Min(a, b));
            }
        }
        else
        {
            Console.Write("Saliendo del programa...");
        }
        Console.Write("Desea realizar otro calculo?Si/No:");
        string respuesta=Console.ReadLine();
      
        if(respuesta.ToLower()=="no") //tolower convierte string en minusculas
        {
            opcion=0;
        }
    }
}while(opcion!=0);

