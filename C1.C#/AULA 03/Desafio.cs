//Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.

void ExibirQuatroOperacoes(){

float a = 4;
float b = 8;

float soma = a + b;
float subtracao = a - b;
float divisao = a / b;
float multiplicacao = a * b;

Console.WriteLine($"a + b = {soma}");
Console.WriteLine($"a - b = {subtracao}");
Console.WriteLine($"a / b = {divisao}");
Console.WriteLine($"a * b = {multiplicacao}");
}

ExibirQuatroOperacoes();

//Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.

List<string> bandas = new List<string>();

bandas.Add("The Beatles");
bandas.Add("Pink Floyd");
bandas.Add("U2");
bandas.Add("Ira!");

//Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.

for(int i = 0; i < bandas.Count; i++){
    Console.WriteLine(bandas[i]);
}

//Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.

List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
int soma = 0;

foreach (int numero in numeros)
{
    soma += numero;
}

Console.WriteLine($"A soma dos elementos da lista é: {soma}");
