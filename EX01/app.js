// Exibindo um alerta de boas-vindas
alert("Boas vindas ao nosso site!");

// Declarando e atribuindo valores a variáveis
let nome = "Lua";
let idade = 25;
let numeroDeVendas = 50;
let saldoDisponivel = 1000;

// Exibindo um alerta de erro
alert("Erro! Preencha todos os campos");

// Outra forma de exibir o alerta de erro usando uma variável
let mensagemDeErro = "Erro! Preencha todos os campos";
alert(mensagemDeErro);

// Pedindo o nome do usuário e armazenando na variável
nome = prompt("Digite seu nome:");

// Pedindo a idade do usuário e armazenando na variável
idade = prompt("Digite sua idade:");

// Verificando se a idade é maior ou igual a 18
if (idade >= 18) {
  alert("Pode tirar a habilitação!");
}