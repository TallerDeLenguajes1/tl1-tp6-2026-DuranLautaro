// See https://aka.ms/new-console-template for more information
double c;
int opcion;
do
{
    Console.WriteLine("Seleccione la opcion deseada:\n");
    Console.Write("1.SUMAR,2.RESTAR,3.MULTIPLICAR,4.DIVIDIR");
    string entrada=Console.ReadLine();
    if(!int.TryParse(entrada,out opcion))
    {
        Console.WriteLine("Numero invalido. Intente nuevamente\n");
    }
    else
    {
        if(opcion!=0)
        {
            Console.Write("Ingresar un numero entero positivo:\n");
            string n=Console.ReadLine();
            double.TryParse(n,out c);
            double r=0;
            switch(opcion)
            {
                //VALOR ABSOLUTO
                case 1:
                Math.Abs(c);
                break;
                //Cuadrado
                case 2:
                Math.Pow(c,2);
                break;
                //LA RAIZ CUADRADA
                case 3:
                Math.Sqrt(c);
                break;
                //SENO
                case 4:
                Math.Sin(c);
                break;
                //COSENO
                case 5:
                Math.Cos(c);
                break;
                //PARTE ENTERA DE UN FLOAT
                case 6:
                Math.Truncate(c);
                break;
                default:
                Console.Write("Opcion invalida\n");
                break;
            }
            Console.WriteLine("Resultado:"+r);
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

