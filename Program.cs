using DesafioPOO.Models;
using System;
using System.Globalization;
using System.IO;

// TODO: Realizar os testes com as classes Nokia e Iphone
string opcao;
do { 
    Console.Clear();
Console.WriteLine(@$"Selecione o seu smartphone:
Nokia = 1
Iphone = 2
Sair = 0
");
opcao = Console.ReadLine();

switch (opcao)
{
    case "1" :
        Smartphone nokia = new Nokia(numero: "44444", modelo: "Lumia 530", imei: "00000000000", memoria: 16); 
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Youtube Music");
            Thread.Sleep(3000);
        break;
    case "2": 
        Smartphone iphone = new Iphone(numero: "443333", modelo: "Iphone 13 Pro", imei: "11111111111", memoria: 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Itunes");
            Thread.Sleep(3000);
        break;
    case "0":
    Console.WriteLine($"Saindo...");
    Thread.Sleep(3000);
    break;

    default:
        Console.WriteLine("Opção Inválida, tente novamente.");
        break;
}
}while (opcao != "0");
        