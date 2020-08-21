using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DescricaoUsuario();
            // Soma();
            // Subtracao();
            // Divisao();
            // Multiplicacao();
        }

        static void DescricaoUsuario()
        {
            Console.Clear();
            Console.WriteLine("Olá usuário, vamos começar a calcular seus números ? ");
            Console.WriteLine("Diga seu nome ? ");
            var txtName = (Console.ReadLine());
            Console.WriteLine(txtName);

            Algoritmo();
        }
        static void Algoritmo()//short algoritmos)
        {

            Console.WriteLine("Qual Algoritmo deseja utilizar ? ");
            Console.WriteLine("1 : Soma");
            Console.WriteLine("2 : Subtração");
            Console.WriteLine("3 : Multiplicação");
            Console.WriteLine("4 : Divisão");

            short algoritmos = short.Parse(Console.ReadLine());

            // Primeira opção de condicional
            // if (algoritmos == 1)
            // {
            //     Soma();
            // }
            // else if (algoritmos == 2)
            // {
            //     Subtracao();
            // }
            // else if (algoritmos == 3)
            // {
            //     Multiplicacao();
            // }
            // else if (algoritmos == 4)
            // {
            //     Divisao();
            // }
            // else
            // {
            //     return;
            // }

            // Segunda opção de condicional
            switch (algoritmos)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                default: DescricaoUsuario(); break;

            }

        }
        static void Retorno()
        {
            Console.WriteLine("Deseja calcular outro número ?");
            Console.WriteLine("1 : Sim");
            Console.WriteLine("2 : Não");
            short escolha = short.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Algoritmo();
            }
            else if (escolha == 2)
            {
               System.Environment.Exit(0);
               Console.Write("Obrigado pela sua presença...");
            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor : ");
            float v1 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Primeiro Valor : ");
            float v2 = float.Parse(Console.ReadLine()!);

            System.Console.WriteLine("");
            
            float resultado = v1 + v2;

            // System.Console.WriteLine("O resultado da soma é " + resultado);
            System.Console.WriteLine($"O resultado da soma é {resultado}");
            // System.Console.WriteLine($"O resultado da soma é {v1 + v2}");
            // System.Console.WriteLine($"O resultado da soma é " + (v1 + v2));
            // System.Console.WriteLine(v1);
            // Console.ReadKey();
            Retorno();
        }
        static void Subtracao()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine()!);
            
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Retorno();
            Console.ReadKey();
        }
        static void Divisao()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine()!);
            
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Retorno();
            Console.ReadKey();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine()!);
            
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Retorno();
            Console.ReadKey();
        }
    }
}
