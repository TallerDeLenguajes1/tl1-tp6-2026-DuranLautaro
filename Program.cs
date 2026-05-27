// See https://aka.ms/new-console-template for more information
int a,b,opcion;
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
