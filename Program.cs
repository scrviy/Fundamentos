using Fundamentos.Models;
namespace Fundamentos
{
    public class Fundamentos
    {
        public static void Main(string[] args)
        {
            //Operadores Aritméticos

            //Adicao
            Console.WriteLine(8 + 2); // output 10

            //Subtrair
            Console.WriteLine(10 - 5); //output 5

            //Multiplicar
            Console.WriteLine(2 * 5); //output 10

            //Dividir 
            Console.WriteLine(100 / 2); //output 50

            //* operacoes da calculadora
             
            Calculadora calc = new Calculadora();
            /*
            calc.Somar(8, 2);
            calc.Subtrair(10, 5);
            calc.Multiplicar(2, 5);
            calc.Dividir(100, 2);
            */

            calc.Potencia(3, 3);
        }
    }
}