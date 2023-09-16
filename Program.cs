﻿using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

string precoInicialEntrada;
string precoPorHoraEntrada;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
do {
    Console.WriteLine("Digite o preço inicial:");
    precoInicialEntrada = Console.ReadLine();
    if(decimal.TryParse(precoInicialEntrada, out precoInicial)) {
        break;
    } else {
        Console.WriteLine("Valor inválido!");
    }
} while(true);

do {
    Console.WriteLine("Agora digite o preço por hora:");
    precoPorHoraEntrada = Console.ReadLine();
    if(decimal.TryParse(precoPorHoraEntrada, out precoPorHora)) {
        break;
    } else {
        Console.WriteLine("Valor inválido!");
    }
} while(true);

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

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

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");