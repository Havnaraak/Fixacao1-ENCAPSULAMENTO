using System;
using System.Globalization;

namespace Fixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorDeposito;
            int result2;

            Console.Write("Digite o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine();


            Console.Write("Haverá depósito inicial? (s/n) ");
            char deposito = char.Parse(Console.ReadLine());
            if (deposito == 's')
            {
                Console.Write("Insira o valor do depósito: ");
                valorDeposito = double.Parse(Console.ReadLine());
            }
            else
            {
                valorDeposito = 0;
            }

            DadosConta dadosConta = new DadosConta(numConta, titular, valorDeposito);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Conta cadastrada com sucesso");
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(dadosConta);
            Console.WriteLine("--------------------------------");


            Console.Write("Deseja Realizar mais algum procedimento? (s/n)");
            char continua = char.Parse(Console.ReadLine());

            while (continua == 's')
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("_________________________________");
                Console.WriteLine("O que deseja fazer agora?        ");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1         |SOBRE SALDO           ");
                Console.WriteLine("2         |SOBRE TITULAR         ");
                Console.WriteLine("3         |SOBRE NÚMERO DA CONTA ");
                Console.WriteLine("---------------------------------");
                int codigo = int.Parse(Console.ReadLine());

                if (codigo == 1)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1    | CONSULTAR SALDO");
                    Console.WriteLine("2    | FAZER DEPOSITO ");
                    Console.WriteLine("3    | FAZER SAQUE    ");
                    Console.WriteLine("----------------------");


                    result2 = int.Parse(Console.ReadLine());

                    if (result2 == 1)
                    {
                        Console.WriteLine("O saldo Atual é de: R$" + dadosConta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
                    }

                    else if (result2 == 2)
                    {
                        Console.Write("Digite o valor do depósito: ");
                        double valor = double.Parse(Console.ReadLine());
                        dadosConta.Deposito(valor);
                        Console.WriteLine("Deposito realizado com sucesso, saldo atualizado: " + dadosConta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
                    }
                    else if (result2 == 3)
                    {
                        Console.Write("Digite o valor do saque (Taxa de 5 reais por saque)");
                        double valor = double.Parse(Console.ReadLine());
                        dadosConta.Saque(valor);
                        Console.WriteLine("Saque realizado com sucesso, saldo atualizado: " + dadosConta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
                    }
                    else
                    {
                        Console.Write("CODIGO INVÁLIDO, INSIRA O CÓDIGO NOVAMENTE: ");
                        result2 = char.Parse(Console.ReadLine());
                    }
                }

                else if (codigo == 2)
                {
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("1   | CONSULTAR NOME DO TITULAR");
                    Console.WriteLine("2   | ALTERAR NOME DO TITULAR  ");
                    Console.WriteLine("-------------------------------");
                    int result = int.Parse(Console.ReadLine());
                    if (result == 1)
                    {
                        Console.WriteLine("O nome do titular da conta é: " + dadosConta.Titular);
                    }
                    else if (result == 2)
                    {
                        Console.Write("Digite o novo nome do Titular: ");
                        string titular2 = Console.ReadLine();
                        dadosConta.Titular = titular2;
                        Console.WriteLine("Nome do titular atualizado com sucesso, nome atual  no cadastro: " + dadosConta.Titular);
                    }
                    else
                    {
                        Console.Write("CODIGO INVÁLIDO, INSIRA O CÓDIGO NOVAMENTE: ");
                        result = int.Parse(Console.ReadLine());
                    }

                }

                else if (codigo == 3)
                {
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("1   | CONSULTAR NÚMERO DA CONTA");
                    Console.WriteLine("2   | ALTERAR NÚMERO DA CONTA  ");
                    Console.WriteLine("-------------------------------");
                    int result = int.Parse(Console.ReadLine());
                    if (result == 1);

                    if (result == 1)
                    {
                        Console.WriteLine("O Número da conta é: " + dadosConta.NumConta);
                    }
                    else if (result == 2)
                    {
                        Console.Write("Digite o novo nome do Titular: ");
                        int numeroConta = int.Parse(Console.ReadLine());
                        dadosConta.NumConta = numeroConta;
                        Console.WriteLine("Número da conta atualizado com sucesso, número atual: " + dadosConta.NumConta);
                    }
                    else
                    {
                        Console.Write("CODIGO INVÁLIDO, INSIRA O CÓDIGO NOVAMENTE: ");
                        result = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.Write("CÓDIGO INCORRETO, DIGITE NOVAMENTE: ");
                    codigo = int.Parse(Console.ReadLine());
                }



                Console.Write("Deseja Realizar mais algum procedimento? (s/n)  ");
                continua = char.Parse(Console.ReadLine());

                if (continua == 'n')
                {
                    Console.WriteLine("MUITO OBRIGADO, OS DADOS ATUALIZADOS DA CONTA SÃO: ");
                    Console.WriteLine(dadosConta);
                }

            }


        }

    }
}