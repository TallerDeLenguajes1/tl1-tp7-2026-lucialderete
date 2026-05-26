using EspacioCalculadora;
calculadora calc = new calculadora();
int opcion;
double num;

do
{
    Console.WriteLine("---CALCULADORA---");
    Console.WriteLine("1) Sumar");
    Console.WriteLine("2) restar");
    Console.WriteLine("3) multiplicar");
    Console.WriteLine("4) dividir");
    Console.WriteLine("5) limpiar");
    Console.WriteLine("0) salir");

    Console.WriteLine("Seleccione una opcion: ");
   
   /*if(!double.TryParse(Console.ReadLine(), out num)){
    Console.WriteLine("error");
   }*/
   
   opcion = Convert.ToInt32(Console.ReadLine());
    if(opcion >= 1 && opcion <= 5){
        Console.WriteLine("ingrese un numero: ");
        num = Convert.ToDouble(Console.ReadLine());
        switch (opcion)
        {
            case 1: 
                calc.sumar(num);
                break;
            case 2:
                calc.restar(num);
                break;
            case 3: 
                calc.multiplicar(num);
                break;
            case 4:
                calc.dividir(num);
                break;
            case 5:
                calc.limpiar();
                Console.WriteLine("calculadora reiniciada");
                break;
        }
        Console.WriteLine($"Resultado : {num}");
    }


} while (opcion != 0);