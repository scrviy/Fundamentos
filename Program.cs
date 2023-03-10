using Fundamentos.Models;
namespace Fundamentos
{
    public class Fundamentos
    {
        public static void Main(string[] args)
        {
            //*Operadores Aritméticos
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
            
            calc.Somar(8, 2);
            calc.Subtrair(10, 5);
            calc.Multiplicar(2, 5);
            calc.Dividir(100, 2);
            calc.Potencia(3, 3);

            //*Trigonometria
            Calculadora calc1 = new Calculadora();
            calc1.Seno(30);
            calc1.Cosseno(30);
            calc1.Tangente(30);

            //* Incremento e Decremento
            int numeroIncremento = 10;
            Console.WriteLine(numeroIncremento);

            Console.WriteLine("Incrementando o 10");
            numeroIncremento++; // numero = numero + 1;

            int numeroDecremento = 20;
            Console.WriteLine("Decrementando o 20");
            numeroDecremento--; // numero = numero - 1;
            Console.WriteLine(numeroDecremento);
            

            //* Raiz Quadrada com classe Math
            calc.RaizQuadrada(9);      
        }
    }
}