

namespace Interfaz
{
    public class Operacion : IOperacion, IArea
    {

        public double n1;
        public double n2;
        public double Division()
        {
            return n1 / n2;
        }

        public double Multiplicacion()
        {
            return n1 * n2;
        }

        public double Resta()
        {
            return n1 - n2;
        }

        public double Suma()
        {
            return n1 + n2;
        }

        public double Cuadrado()
        {
            return n1* n2;
        }

        public double Triangulo()
        {
            return (n1*n2)/2;
        }

        public void Imprimir()
        {
            Console.WriteLine($"La suma es: {Suma()}");
            Console.WriteLine($"La resta es: {Resta()}");
            Console.WriteLine($"La multiplicacion es: {Multiplicacion()}");
            Console.WriteLine($"La division es: {Division()}");
            Console.WriteLine($"El area del cuadrado es: {Cuadrado()}mts2");
            Console.WriteLine($"El area del triangulo es: {Triangulo()}mts2");
        }
    }
}