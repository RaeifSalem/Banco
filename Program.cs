using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Salem's Bank ");

            bool acessoPermitido = false;

            while (!acessoPermitido)
            {
                Console.WriteLine("Digite sua senha:");
                string senha = Console.ReadLine();

                if (senha == "123456")
                {
                    acessoPermitido = true;
                }
                else
                {
                    Console.WriteLine("Senha incorreta. Por favor, digite novamente:");
                }
            }
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Acesso permitido.");
                Console.WriteLine("Senha correta. Escolha uma opção:");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Sacar");
                Console.WriteLine("3. Consultar saldo");
                Console.WriteLine("4. Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());
                int saldo = 1000;
                switch (opcao)
                {

                    case 1:
                        Console.WriteLine("Digite o valor a ser depositado:");
                        int deposito = Convert.ToInt32(Console.ReadLine());
                        saldo += deposito;
                        Console.WriteLine("Depósito realizado com sucesso. Novo saldo:" + saldo);
                        break;
                    case 2:
                        Console.WriteLine("digite o valor a ser retirado:");
                        int saque = Convert.ToInt32(Console.ReadLine());
                        if (saque > saldo)
                        {
                            Console.WriteLine("Saldo insuficiente");


                        }
                        else
                        {
                            saldo -= saque;
                            Console.WriteLine("Retirada realizada com sucesso. Novo saldo:" + saldo);

                        }
                        break;
                    case 3:
                        Console.WriteLine("Seu saldo atual é " + saldo);
                        break;
                    case 4:
                        Console.WriteLine("Saindo");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção ivalida. Encerrando o aplicativo");
                        break;
                }

            }









        }
    }
}