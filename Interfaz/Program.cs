
using Interfaz;

Operacion operacion = new Operacion();

Console.WriteLine("Ingrese el primer numero");
bool validn1 = double.TryParse(Console.ReadLine(), out operacion.n1);

Console.WriteLine("Ingrese el segundo numero");
bool validn2 = double.TryParse(Console.ReadLine(), out operacion.n2);

if (validn1 && validn2)
{
    Console.WriteLine();
    Console.WriteLine("Validando...");
    Console.WriteLine();

    if (operacion.n2 == 0) {
        Console.WriteLine("El segundo valor no puede ser 0") ;
    } else
    {
        operacion.Imprimir();
    }

} else
{
    Console.WriteLine("Valores ingresados son incorrectos");
}