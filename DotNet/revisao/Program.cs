using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- inserir novo aluno");
            Console.WriteLine("2- listar aluno");
            Console.WriteLine("3- calcular media geral");
            Console.WriteLine("x- sair");
            Console.WriteLine();

            string opcao = Console.ReadLine();

            while (opcao.ToUpper() != "x")
            {
                switch (opcao)
                {

                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Escolha uma opcao válida");


                }
Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- inserir novo aluno");
            Console.WriteLine("2- listar aluno");
            Console.WriteLine("3- calcular media geral");
            Console.WriteLine("x- sair");
            Console.WriteLine();

            opcao = Console.ReadLine();


            }
        }
    }
}
