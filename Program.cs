using Models;
// Este código representa a interação principal com o sistema de estacionamento.
// Inicia-se com a configuração da codificação para permitir a exibição de acentos.
Console.OutputEncoding = System.Text.Encoding.UTF8;
// Declaração e inicialização das variáveis de preço inicial e por hora.
decimal precoInicial = 0;
decimal precoPorHora = 0;
// Solicita ao usuário inserir o preço inicial e por hora do estacionamento.
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());
// Instancia a classe Estacionamento com os valores obtidos anteriormente.
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;
// Loop do menu principal, exibindo opções ao usuário.
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    // Switch statement para processar a escolha do usuário.
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
            Console.WriteLine("O programa se encerrou");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
