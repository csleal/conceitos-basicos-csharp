/*
1. Fazer um programa que leia três valores com ponto flutuante: A, B e C. Em seguida, calcule e mostre:
    
    a) a área do triângulo retângulo que tem A por base e C por altura. Fórmula: área = (base * altura) / 2
    b) a área do círculo de raio C. Fórmula: área = pi * raio²
    c) a área do trapézio que tem A e B por bases e C por altura. Fórmula: área = ((base1 + base2) * altura) / 2
    d) a área do quadrado que tem lado B. Fórmula: área = base²
    e) a área do retângulo que tem lados A e B. Fórmula: área = base * altura
*/

// System.Console.WriteLine("Digite três valores: ");
// double a = double.Parse(Console.ReadLine());
// double b = double.Parse(Console.ReadLine());
// double c = double.Parse(Console.ReadLine());

// System.Console.WriteLine("###################");
// System.Console.WriteLine("Área do triângulo retângulo que tem A por base e C por altura: " + (a * c) / 2 );
// System.Console.WriteLine("área do círculo de raio C: " + Math.PI * Math.Pow(c, c));
// System.Console.WriteLine("Área do trapézio que tem A e B por bases e C por altura: " + ( (a + b) * c ) / 2 );
// System.Console.WriteLine("Área do quadrado que tem lado B: " + Math.Pow(b, b) );
// System.Console.WriteLine("Área do retângulo que tem lados A e B: " + ( a * b ) );

/*
2. Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "São Múltiplos" ou "Não são
Multiplos", indicando se os valores lidos são múltiplos entre si.
*/

// System.Console.WriteLine("Digite dois números inteiros e descubra se são múltiplos: ");

// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());

// if (a % b == 0 )
// {
//     System.Console.WriteLine($"{a} e {b} São Múltiplos");
// }

// else
// {
//     System.Console.WriteLine($"{a} e {b} Não são Múltiplos");
// }

/*
3. A estimativa de três pontos (PERT) é uma técnica utilizada para calcular a duração de uma atividade baseada em
três valores:

    •A estimativa mais otimista;
    •A estimativa mais pessimista; e
    •A estimativa mais provável.

Para se calcular o tempo esperado para uma atividade, utiliza-se a seguinte fórmula:

    [Otimista + Pessimista + (4 x Mais Provável)] / 6

Crie um programa que leia a estimativa (em horas) otimista, a pessimista e a mais provável e exiba na tela o tempo
esperado, conforme a fórmula acima. Ex.:

    Otimista: 10
    Pessimista: 30
    Provavel: 15
    PERT = 16.66
*/

// System.Console.WriteLine("Estimativa de três pontos (em horas)");

// System.Console.WriteLine("Digite a estimativa otimista: ");
// double otimista = double.Parse(Console.ReadLine());

// System.Console.WriteLine("Digite a estimativa pessimista: ");
// double pessimista = double.Parse(Console.ReadLine());

// System.Console.WriteLine("Digite a estimativa mais provável: ");
// double provavel = double.Parse(Console.ReadLine());

// double estimativa = ( otimista + pessimista + (4 * provavel) ) / 6;

// System.Console.WriteLine($"Tempo esperado segundo a técnica de PERT: {estimativa:F2}");

/*
4. Escreva um programa que leia a nota de um aluno e imprima sua situação com base nas seguintes condições:

    a) Caso a nota seja >= 7: “Aprovado”
    b) Caso a nota seja < 7 e >= 4: “Em recuperação”
    c) Caso a nota seja < 4: “Reprovado”
*/

// System.Console.WriteLine("Digite a nota do Aluno: ");
// double nota = double.Parse(Console.ReadLine());

// if ( nota >= 7 )
// {
//     System.Console.WriteLine("Aprovado");
// }

// else if ( nota < 7 && nota >=4 )
// {
//     System.Console.WriteLine("Em recuperação");
// }

// else if ( nota < 4 )
// {
//     System.Console.WriteLine("Reprovado");
// }

// else
// {
//     System.Console.WriteLine("Nota Inválida");
// }

/*
5. Escreva um programa, utilizando a estrutura de decisão switch/case, que receba do usuário um número inteiro de 1
a 3 e imprima a mensagem na tela com base na resposta:

    1 -> “Bom dia”
    2 -> “Boa tarde”
    3 -> “Boa noite”
*/

// System.Console.Write("Digite um número inteiro entre 1 a 3: ");
// int numero = int.Parse(Console.ReadLine());

// switch(numero)
// {
//     case 1:
//         System.Console.WriteLine("Bom dia");
//         break;
    
//     case 2:
//         System.Console.WriteLine("Boa tarde");
//         break;

//     case 3:
//         System.Console.WriteLine("Boa noite");
//         break;

//     default:
//         System.Console.WriteLine("Número Inválido");
//         break;
// }

/*
6. Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
Lembrando que, por definição, fatorial de 0 é 1.
*/

// System.Console.Write("Digite o número para calcular seu fatorial: ");

// int numero = int.Parse(Console.ReadLine());
// int fatorial = 1;
// int contador = 0;

// if ( numero < 0 )
// {
//     System.Console.WriteLine("Número Inválido");
// }

// else if ( numero == 0 || numero == 1 )
// {
//     System.Console.WriteLine($"Fatorial de {numero} é 1");
// }

// else
// {
//     for (contador = numero; contador >=1 ; contador--)
//     {
//         System.Console.WriteLine($"Contador: {contador} e Variável fatorial: {fatorial}");
//         fatorial = fatorial * contador;
//     }
//     System.Console.WriteLine($"O fatorial de {numero} é {fatorial}.");
// }

/*
7. Escreva um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor. Ex.:
Entrada: 2
Saída:
111
2
48
*/

// System.Console.Write("Digite um número inteiro positivo: ");
// int num = int.Parse(Console.ReadLine());

// for (int i = 0; i < num; i++)
// {
//     System.Console.WriteLine($"{i+1}, {Math.Pow(i+1, 2)}, {Math.Pow(i+1, 3)}");
// }

/*
8. Escreva um programa que simule a urna eletrônica. A tela a ser apresentada deverá ser da seguinte forma:
As opções são:

    1. Candidato Chaves
    2. Candidata Chiquinha
    3. Candidato Quico
    4. Nulo/Branco
    5. Encerrar a votação

Entre com o seu voto:

O programa deverá ler os votos dos eleitores e, quando for entrado o número 5, apresentar as seguintes
informações:

    a) O número de votos de cada candidato;
    b) A porcentagem de votos nulos;
    c) A porcentagem de votos brancos;
    d) O candidato vencedor.
*/

int voto = 0;

int chaves, chiquinha, quico, nulo;
chaves = chiquinha = quico = nulo = 0;

while (voto != 5)
{
    System.Console.WriteLine("### Urna Eletrônica ###");
    System.Console.WriteLine();
    System.Console.WriteLine("  1. Candidato Chaves");
    System.Console.WriteLine("  2. Candidata Chiquinha");
    System.Console.WriteLine("  3. Candidato Quico");
    System.Console.WriteLine("  4. Nulo/Branco");
    System.Console.WriteLine("  5. Encerrar a votação");
    System.Console.WriteLine();
    System.Console.Write("Entre com o seu voto: ");

    voto = int.Parse(Console.ReadLine());

    switch(voto)
    {
        case 1:
            chaves++;
            break;
        
        case 2:
            chiquinha++;
            break;

        case 3:
            quico++;
            break;

        case 4:
            nulo++;
            break;

        case 5:
            break;
        
        default:
            Console.WriteLine("Digite um número válido!");
            break;
    }

    Console.Clear();
}

Console.WriteLine($"### Número de votos ###\n Chaves: {chaves}\n Chiquinha: {chiquinha}\n Quico: {quico}\n Nulos: {nulo}");
Console.WriteLine($"Procentagem de Votos Nulos: {(nulo / (chaves + chiquinha + quico + nulo)) * 100}%");
Console.WriteLine($"O cadidato vencendor é: {Math.Max(chaves, Math.Max(chiquinha, quico))}");