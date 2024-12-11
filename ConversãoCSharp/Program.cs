using System;

namespace conversão;

class program
{
    static void Main(string[] args)
    {
        /*Números científicos
        Um número de ponto flutuante também pode ser um número científico com um "e" para indicar a potência de 10:8*/
        float f1 = 35e3F;
        double d1 = 12E4D;
        Console.WriteLine(f1);
        Console.WriteLine(d1);
        /* A conversão de tipo ocorre quando você atribui um valor de um tipo de dado a outro tipo.
        Casting implícito (automaticamente) - convertendo um tipo menor em um tamanho de tipo maior
        char-> int-> long-> float->double
        Conversão explícita (manual) - convertendo um tipo maior em um tipo de tamanho menor
        double-> float-> long-> int->char*/

        int myInt = 10;
        double myDouble = 5.25;
        bool myBool = true;

        Console.WriteLine(Convert.ToString(myInt));    // converte int para string
        Console.WriteLine(Convert.ToDouble(myInt));    // converte int para double
        Console.WriteLine(Convert.ToInt32(myDouble));  // converte double para int
        Console.WriteLine(Convert.ToString(myBool));   // converte bool para string
    }
}