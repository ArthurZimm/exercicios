using System;

class MainClass {

  public static void Main () {

    int Num1, Num2, Soma;    

            Console.Write("Digite o primeiro numero >>");
            Num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo >>");
            Num2 = int.Parse(Console.ReadLine());


            Soma = Num1 + Num2;

            Console.WriteLine ("A soma é " + Soma);
  }
} 