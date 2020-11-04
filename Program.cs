using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
          double Nota1; 
          double Nota2;
          double Nota3;
          double Nota4;
          double resulMedia; 

          Console.Write("1ºNota:"); 
          Nota1 = double.Parse(Console.ReadLine());
            if (Nota1 < 0 || Nota1 > 10) 
            {   
                Console.WriteLine();
                Console.WriteLine("Digite somente números de 0 a 10");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!"); 
                Console.ReadKey();
                Environment.Exit(-1);
            } 

                 Console.Write("2ºNota: ");
             Nota2 = double.Parse(Console.ReadLine());
            if (Nota2< 0 || Nota2 > 10) 
            {
                Console.WriteLine();
                Console.WriteLine("Digite somente números de 0 a 10");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                Console.ReadKey();
                Environment.Exit(-1);  
            }       

                Console.Write("3ºNota: ");
            Nota3 = double.Parse(Console.ReadLine());
            if (Nota3 < 0 || Nota3 > 10) 
            {
                Console.WriteLine();
                Console.WriteLine("Digite somente números de 0 a 10");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                Console.ReadKey();
                Environment.Exit(-1);
            }   

                Console.Write("4ºNota: ");
            Nota4 = double.Parse(Console.ReadLine());
            if (Nota4 < 0 || Nota4 > 10) 
            {
                Console.WriteLine();
                Console.WriteLine("Digite somente números de 0 a 10");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                Console.ReadKey();
                Environment.Exit(-1); 
            }
                resulMedia = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            if (resulMedia >= 7) 
            { 
                Console.WriteLine();
                Console.WriteLine($"Sua media final é de {Math.Round(resulMedia, 1)}");
                Console.WriteLine("APROVADO!"); 
            }   
            else if (resulMedia >= 5 && resulMedia <= 6) 
            {
                Console.WriteLine();
                Console.WriteLine($"Sua media final é de {Math.Round(resulMedia, 1)}");
                Console.WriteLine("Você está de  RECUPERAÇÃO!"); 
            }  
            else 
            { 
            Console.WriteLine();
                Console.WriteLine($"Sua media final é de {Math.Round(resulMedia, 1)}");
                Console.WriteLine("Então você foi REPROVADO!"); 
            }             
        }   
    }
}
