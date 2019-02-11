using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
          float num1, num2, num3;
          const float peso1 = 0.1f, peso2 = 0.3f, peso3 = 0.6f;

          Console.WriteLine("Digite a Primeira nota");
          num1 = float.Parse(Console.ReadLine());

          Console.WriteLine("Digite o Segundo Numero");
          num2 = float.Parse(Console.ReadLine());

          Console.WriteLine("Digite o Terceiro Numero");
          num3 = float.Parse(Console.ReadLine());

          float media = num1 * peso1 + num2 * peso2 + peso2 * peso3 + peso3;

          Console.WriteLine("Digite o a media Final " + media);
          
        }
    }
}
