//Declarando variáveis

using JeffsCar;

decimal precoInicial = 0;
decimal precoHora = 0;

//Iniciar sistema

Console.WriteLine("Sejam bem vindos ao estacionamento do Jeff");
Console.WriteLine("------------------------------------------");

Console.WriteLine("Digite o preço Inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora: ");
precoHora = Convert.ToDecimal(Console.ReadLine());

//Estancia a classe estacionamento

Estacionamento es = new Estacionamento(precoInicial, precoHora);


//Loop

bool menu = true;

while (menu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção.");
    Console.WriteLine("1 - Adicionar veículo.");
    Console.WriteLine("2 - Remover veículo.");
    Console.WriteLine("3 - Listar veículo.");
    Console.WriteLine("4 - Sair do sistema.");

    switch (Console.ReadLine())
    {
        case "1":
            es.adicionarVeiculo();
            break;
        case "2":
            es.removerVeiculo();
            break;
        case "3":
            es.listarVeiculo();
            break;
        case "4":
            menu = false;
            break;
        default: Console.WriteLine("Digite uma opção válida!");
            break;
    }

    Console.WriteLine("Você saiu do sistema.");
}