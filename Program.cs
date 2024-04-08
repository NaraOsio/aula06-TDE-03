//1- Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior
// Encontre o maior dentre 3 números:
// Primeiro Número : 65465
// Segundo Número : 64658
// Terceiro Número : 65464
// O primeiro número : 65465 é o maior

// Console.WriteLine("Digite o primeiro número inteiro:");
// int numero1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Digite o segundo número inteiro:");
// int numero2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Digite o terceiro número inteiro:");
// int numero3 = Convert.ToInt32(Console.ReadLine());


// if(numero1 > numero2 && numero1 > numero3)
// {
//     Console.WriteLine("O número " + numero1 + " é o maior número");
// } 
// else if(numero2 > numero1 && numero2 > numero3)
// {
//     Console.WriteLine("O número " + numero2 + " é o maior número");
// }
// else if(numero3 > numero1 && numero3 > numero2)
// {
//     Console.WriteLine("O número " + numero3 + " é o maior número");
// }



// 2- Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop 
// while, do-while e for.
// Os 10 primeiros números naturais são :
// 1 2 3 4 5 6 7 8 9 10
// A soma dos números é : 55


// Console.WriteLine("10 primeiros números naturais:");
// var numero = 1;
// var soma = 0;
// while(numero <= 10)
// {
//     Console.WriteLine(numero);
//     soma = soma + numero;
//     numero++;
// }
// Console.WriteLine("A soma dos números é: " + soma);



// Console.WriteLine("10 primeiros números naturais:");
// var numero = 1;
// var soma = 0;

// do {
//     System.Console.WriteLine(numero);
//     soma = soma + numero;
//     numero = numero + 1;
// }
// while(numero <= 10);
// Console.WriteLine("A soma dos números é: " + soma);



// var soma = 0;
// for(var i = 1; i <= 10; i++)
// {
//     Console.WriteLine(i);
//     soma += i;
// }
// Console.WriteLine("A soma dos números é: " + soma);



// 3- Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero 
// recebido via teclado 
// - Verifique se o número é maior que zero e emita uma mensagem
// - Considere a tabela de multiplicação de 1 até 10
// - Após exibir a tabela torne a solicitar outro número 
// - Para sair do loop defina uma condição de saída 
// Dica: Use os loop while e for e para sair a instrução break;


// int num = 0;
// do {
//     Console.Write("Digite um número natural maior que zero ou digite 99 para sair: ");
//     num = int.Parse(Console.ReadLine());

//     if(num == 99)
//         break;

//     if (num <= 0)
//     {
//         Console.WriteLine("Digite um número maior que zero.");
//         return;
//     }

//     Console.WriteLine($"Tabela de multiplicação de {num}:");

//     for (int i = 1; i <= 10; i++)
//     {
//         Console.WriteLine($"{num} * {i} = {num * i}");
//     }
// } while(num != 99);




// 4- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 
// maneiras diferentes:
// - Incrementando 2 em cada passo
// - Incrementando 1 em cada passo 
// - Com e loop infinito (use "break" e "continue")

// for(int i = 10; i <= 20; i+=2)
// {
//     if(i != 16)
//         Console.WriteLine(i);
// }

// for(int i = 10; i <= 20; i+=1)
// {
//     if(i % 2 == 0 && i != 16)
//         Console.WriteLine(i);
// }

// var numero = 10;
// while(true)
// {
//     if(numero > 20)
//         break;

//     if(numero != 16)
//         Console.WriteLine(numero);

//     numero = numero + 2;
// }




// 5 - Escreva um programa para calcular o fatorial de um número inteiro. 
// O fatorial de um número é representado por : n! => n * (n – 1) * (n – 2) ....2*1 
// Exemplo : fatorial de 6 é representado por 6! = 6*5*4*3*2*1

// Console.WriteLine("Digite um número para calcular o fatorial");
// var numero = int.Parse(Console.ReadLine());
// var total = numero;
// for(int i = numero - 1; i > 0; i--)
// {
//     total = total * i;
// }
// Console.WriteLine("Resultado: " + total);



// 6 - Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado

// int numeroTabuada = 2;
// do {

//     var numero = 0;
//     do {
//         System.Console.WriteLine(numeroTabuada + " x " + numero + " = " + numero * numeroTabuada);
//         numero++;
//     }
//     while (numero <= 10);

//     numeroTabuada += 1;
// }
// while (numeroTabuada <= 6);





//  7 - Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de 
// um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a 
// instrução switch, break e default em um loop infinito e defina uma condição de saida.)



// Console.WriteLine("Digite a nota do aluno (entre 0 e 10):");
// int nota = int.Parse(Console.ReadLine());

// switch (nota)
// {
//     case 0:
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//         Console.WriteLine("Nota: F");
//         break;
//     case 5:
//         Console.WriteLine("E");
//          break;
//     case 6:
//         Console.WriteLine("C");
//         break;
//     case 7:
//     case 8:
//         Console.WriteLine("B");
//         break;
//     case 9:
//         Console.WriteLine("A");
//         break;
//     case 10:
//          Console.WriteLine("A+");
//         break;
//     default:
//         Console.WriteLine("Nota inválida");
//         break;
// }




// 8 - Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números 
// inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e 
// quando isso ocorrer exibir uma mensagem de alerta

// Console.WriteLine("Digite o primeiro número");
// int primeiroNumero = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite o segundo número");
// int segundoNumero = int.Parse(Console.ReadLine());

// Console.WriteLine("Resultado adição: " + (primeiroNumero + segundoNumero));
// Console.WriteLine($"Resultado subtração: " + (primeiroNumero - segundoNumero ));
// Console.WriteLine($"Resultado multiplicação: " + (primeiroNumero * segundoNumero ));

// if(segundoNumero == 0){
//     Console.WriteLine("Não é possivel dividir por 0");
// }
// else{
//     Console.WriteLine($"Resultado divisão: " + (primeiroNumero / segundoNumero ));
// }