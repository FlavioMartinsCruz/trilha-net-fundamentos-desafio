﻿using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.Clear();
Console.Write("Seja bem vindo(a) ao sistema de estacionamento!\n" +
                  "Digite o preço inicial (fixo): ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o preço por hora (variável): ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

//string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("------------------------");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.WriteLine("------------------------");
    Console.Write("Digite uma das opções: ");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("");
    Console.Write("Pressione uma tecla para continuar");
    Console.ReadLine();
    Console.Clear();
}

Console.WriteLine("O programa se encerrou");
