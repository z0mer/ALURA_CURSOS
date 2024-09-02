alert('Bem vindo ao jogo do número secreto');
let numeroSecreto = 29;
console.log(numeroSecreto);
let chute = prompt('Escolha um número entre 1 e 100');

if (chute == numeroSecreto){
    alert('Parabéns, você descobriu o número secreto!!');
} else{
    alert('Você errou!')
}