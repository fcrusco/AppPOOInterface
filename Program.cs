// --- Entrada de Dados Básicos ---
using AppPOOInterface.Interface;
using AppPOOInterface.Model;

Console.Write("Digite o número do pedido: ");
int numeroPedido = int.Parse(Console.ReadLine());

Console.Write("Digite o valor do pedido: ");
decimal valor = decimal.Parse(Console.ReadLine());

// --- Menu de Opções ---
Console.WriteLine("\nEscolha a forma de pagamento:");
Console.WriteLine("1 - Cartão de Crédito");
Console.WriteLine("2 - Boleto Bancário");
Console.WriteLine("3 - Bitcoin");
Console.Write("Opção: ");

string opcao = Console.ReadLine();

IPagavel pagamento;

// Utilizando switch para uma leitura mais limpa do menu
switch (opcao)
{
    case "1":
        Console.Write("Digite o número do cartão: ");
        string numeroCartao = Console.ReadLine();
        pagamento = new PagamentoCartao(valor, numeroCartao);
        break;

    case "2":
        Console.Write("Digite o código de barras do boleto: ");
        string codigoBarras = Console.ReadLine();
        pagamento = new PagamentoBoleto(valor, codigoBarras);
        break;

    case "3":
        Console.Write("Digite a carteira de destino: ");
        string carteira = Console.ReadLine();
        pagamento = new PagamentoBitcoin(valor, carteira);
        break;

    default:
        Console.WriteLine("Opção inválida. Operação cancelada.");
        return;
}

// --- Processamento (Injeção de Dependência aqui!) ---
// O Pedido recebe qualquer objeto que implemente IPagavel
Pedido pedido = new Pedido(numeroPedido, pagamento);

// --- Exibição do Resultado ---
Console.WriteLine("\n--- Resumo do Processamento ---");
foreach (var msg in pedido.FinalizarPedido())
{
    Console.WriteLine(msg);
}

Console.WriteLine("\nPressione Enter para sair...");
Console.ReadLine();