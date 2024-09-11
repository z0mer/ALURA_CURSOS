// Screen Sound
using Microsoft.Win32.SafeHandles;

string mensagemDeBoasVindas = "Bem vindo(a) ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "One Direction", "The Beatles", "Calypso", "Guns N' Roses", "Iron Maiden", "Metallica", "AC/DC" };
Dictionary<string, List<int>> cantoresRegistros = new Dictionary<string, List<int>>();
cantoresRegistros.Add("Adele", new List<int> { 10, 8, 5});
cantoresRegistros.Add("Taylor Swift", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um(a) cantor(a).");
    Console.WriteLine("Digite 2 para mostrar todos(as) os(as) cantores(as).");
    Console.WriteLine("Digite 3 para avaliar um(a) cantor(a).");
    Console.WriteLine("Digite 4 para mostrar a média de um(a) cantor(a).");
    Console.WriteLine("Digite 0 para sair.");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    // muitos recursos de if e else, então é indicado o uso do switch 
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistroCantores();
            break;
        case 2:
            MostrarCantores();
            break;
        case 3:
            AvaliarCantores();
            break;
        case 4:
            ExibirNota();
            break;
        case 0:
            SairMenu();
            break;
        default:
            Console.WriteLine("Opção inválida, digite um número do menu");
            break;
    }
}

void RegistroCantores()
{
    Console.Clear();
    ExibirTitulo("Registro dos Cantores");
    Console.Write("\nDigite o nome do(a) cantor(a) que deseja registrar: ");
    string nomeCantor = Console.ReadLine()!;
    cantoresRegistros.Add(nomeCantor, new List<int> ());
    Console.WriteLine($"\nO(A) cantor(a) {nomeCantor} foi registrado(a) com sucesso! ");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void MostrarCantores()
{
    Console.Clear();
    ExibirTitulo("Exibindo os cantores cadastrados");
    Console.WriteLine(" ");

    //loop com for
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    //loop com foreach que é mais usado em C#
    foreach(string cantor in cantoresRegistros.Keys)
    {
        Console.WriteLine($"Cantor(a): {cantor}");
    }

    Console.WriteLine("\nDigite uma tecla para retornar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void ExibirTitulo(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras,'*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

void AvaliarCantores()
{
    //digite qual cantor deseja avaliar
    // se o cantor existir no dicionario >> atribuir uma nota
    // senão, volta ao menu principal

    Console.Clear();
    ExibirTitulo("Avaliação do(a) cantor(a)");
    Console.Write("\nDigite o nome do(a) cantor(a) que deseja avaliar: ");
    string nomeCantor = Console.ReadLine()!;
    if (cantoresRegistros.ContainsKey(nomeCantor))
    {
        Console.Write($"Qual nota o(a) cantor(a) {nomeCantor} merece?: ");
        int nota = int.Parse(Console.ReadLine()!);
        cantoresRegistros[nomeCantor].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para o(a) cantor(a) {nomeCantor}!");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nO(A) cantor(a) {nomeCantor} não foi encontrado(a)!");
        Console.WriteLine("Digite uma tecla para voltar para o menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

void ExibirNota()
{
    Console.Clear();
    ExibirTitulo("Exibir média do(a) cantor(a)");
    Console.Write("\nDigite o nome do(a) cantor(a) que deseja exibir a média: ");
    string nomeCantor = Console.ReadLine()!;
    if (cantoresRegistros.ContainsKey(nomeCantor))
    {
        List<int> notaCantor = cantoresRegistros[nomeCantor];
        Console.WriteLine($"A média do(a) {nomeCantor} é: {notaCantor.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nO(A) cantor(a) {nomeCantor} não foi encontrado(a)!");
        Console.WriteLine("Digite uma tecla para voltar para o menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

void SairMenu()
{
    Console.WriteLine("Você saiu do programa!");
    Thread.Sleep(4000);
    Console.Clear();
}

ExibirMenu();
