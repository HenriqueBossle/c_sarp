﻿/*//numero aleatorio

int numero = 0;

bool adivinha = true;

Random randon = new Random();

int numeroAleatorio;

numeroAleatorio = randon.Next(1, 100);

Console.WriteLine("Número Aleatorio: " + numeroAleatorio); 

while(adivinha){
    Console.WriteLine("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());
    if(numero == numeroAleatorio){
       Console.WriteLine("Você acertou");
       adivinha = false;
    }
}*/


/*//caixa eletronico

double saldo = 1000;
bool ativo = true;

while(ativo){
    Console.WriteLine("1 - Consultar o Saldo");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Depostitar");
    Console.WriteLine("4 - Sair");
    string? opcao = Console.ReadLine();

    switch(opcao){
        case "1":
        Console.WriteLine("Seu Saldo é: "+ saldo);
        break;

        case "2":
        Console.WriteLine("Digite o valor do saque: ");
        double saque = Convert.ToDouble(Console.ReadLine());
        saldo -= saque;
        break;
 
        case "3":
        Console.WriteLine("Digite o valor do deposito: ");
        double deposito = Convert.ToDouble(Console.ReadLine());
        saldo += deposito;
        break;

        case "4":
        Console.WriteLine("Saindo do sistema");
        ativo = false;
        break;

        default:
        Console.WriteLine("Opção inválida");
        break;
    }

}*/

//Calculadora
double numero;
double numero2;
bool calculo = true;

while (calculo){
    Console.WriteLine("Operações:");
    Console.WriteLine("Selecione uma operação");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("Escolha uma opção:");
    string? opcao = Console.ReadLine();

  

    switch(opcao){
        case "1":
           Console.WriteLine("Informe um número: ");
           numero = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Informe um segundo número: ");
           numero2 = Convert.ToDouble(Console.ReadLine()); 
           double soma = numero + numero2;
           Console.WriteLine($"{numero} + {numero2} = {soma}");
           break;

        case "2":
           Console.WriteLine("Informe um número: ");
           numero = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Informe um segundo número: ");
           numero2 = Convert.ToDouble(Console.ReadLine()); 
           double subtracao = numero - numero2;
           Console.WriteLine($"{numero} - {numero2} = {subtracao}");
           break;

        case "3":
           Console.WriteLine("Informe um número: ");
           numero = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Informe um segundo número: ");
           numero2 = Convert.ToDouble(Console.ReadLine()); 
           double multiplicacao = numero * numero2;
           Console.WriteLine($"{numero} x {numero2} = {multiplicacao}");
           break;

        case "4":
           Console.WriteLine("Informe um número: ");
           numero = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Informe um segundo número: ");
           numero2 = Convert.ToDouble(Console.ReadLine()); 
           double divisao = numero / numero2;
           Console.WriteLine($"{numero} / {numero2} = {divisao}");
           break; 
        
        case "5":
           Console.WriteLine("Saindo da calculadora");
           calculo = false;
           break;

        default:
           Console.WriteLine("Informe uma opção válida para realizar a operação:");
           break;
}
}
