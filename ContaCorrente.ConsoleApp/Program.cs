using System.Text.Json;
using ContaCorrente.ConsoleApp.Entidades;

Conta contaTiago = new Conta();
contaTiago.id = 1;
contaTiago.titular = "Tiago";
contaTiago.saldo = 1000;
contaTiago.limiteDebito = 800;

Conta contaRech = new Conta();
contaRech.id = 2;
contaRech.titular = "Rech";
contaRech.saldo = 6000;
contaRech.limiteDebito = 4000;


while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine($"Conta Corrente");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("1 - Saque");
    Console.WriteLine("2 - Depósito");
    Console.WriteLine("3 - Transferência");
    Console.WriteLine("4 - Consulta de Saldo");
    Console.WriteLine("S - Sair");
    Console.WriteLine("---------------------------------------------");
    Console.Write("> ");
    string? opcaoMenu = Console.ReadLine();
    Console.WriteLine("---------------------------------------------");

    if (opcaoMenu?.ToUpper() == "S")
        break;

    if (opcaoMenu == "1")
    {
        Console.Write("Digite o valor do saque: R$ ");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

        contaTiago.Sacar(valorSaque);
    }
    else if (opcaoMenu == "2")
    {
        Console.Write("Digite o valor do depósito: R$ ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        contaTiago.Depositar(valorDeposito);
    }
    else if (opcaoMenu == "3")
    {
        Console.Write("Digite o valor que deseja transferir: R$ ");
        decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

        contaTiago.Transferir(valorTransferencia, contaRech);
    }
    else if (opcaoMenu == "4")
    {
        contaTiago.VisualizarSaldo();
    }
}