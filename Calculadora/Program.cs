using EspacioCalculadora;
Calculadora calc = new Calculadora();
int opcion = -1;

while (opcion != 0)
{
    Console.WriteLine("---CALCULADORA---");
    Console.WriteLine("1) Sumar");
    Console.WriteLine("2) restar");
    Console.WriteLine("3) multiplicar");
    Console.WriteLine("4) dividir");
    Console.WriteLine("5) limpiar");
    Console.WriteLine("0) salir");

    Console.WriteLine("Seleccione una opcion: ");
    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        if (opcion == 0)
        {
            break;
        }

        if (opcion >= 1 && opcion <= 4)
        {
            Console.WriteLine("ingrese un numero: ");
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                switch (opcion)
                {
                    case 1:
                        calc.Sumar(num);
                        break;
                    case 2:
                        calc.Restar(num);
                        break;
                    case 3:
                        calc.Multiplicar(num);
                        break;
                    case 4:
                        calc.Dividir(num);
                        break;
                }
                Console.WriteLine($"Resultado : {calc.Resultado}");
            }
            else
            {
                Console.WriteLine("Numero invalido");
            }
        }
        else if (opcion == 5)
        {
            calc.Limpiar();
            Console.WriteLine("Calculadora reiniciada a 0.");
        }
        else
        {
            Console.WriteLine("Opcion invalida");

        }

    }

}
Console.WriteLine("Fin del programa");