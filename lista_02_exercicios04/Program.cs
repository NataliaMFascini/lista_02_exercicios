/*4) Um grupo de amigos deseja calcular as idade média deles.
 * Para isso, o aluno deve pedir que o usuário insira as idades e calcule a média até que o usuário digite 0.
 * A solução deve ser implementada usando while, do while e for.
 */

using System;

int idade = 1;
int soma = 0;
int media = 0;
int quantidade = 0;

////while
while (idade != 0)
{
    Console.WriteLine("Digite a idade: ");
    idade = Convert.ToInt32(Console.ReadLine());


    if (idade == 0)
    {
        media = soma / quantidade;
        Console.WriteLine($"A média das idades é: {media}");
    }
    else
    {
        soma += idade;
        idade = 1;
        quantidade++;
    }
}

////do while
do
{
    Console.WriteLine("Digite a idade: ");
    idade = Convert.ToInt32(Console.ReadLine());


    if (idade == 0)
    {
        media = soma / quantidade;
        Console.WriteLine($"A média das idades é: {media}");
    }
    else
    {
        soma += idade;
        idade = 1;
        quantidade++;
    }
} while (idade != 0);

//for
for (quantidade = 0; idade != 0; quantidade++)
{
    Console.WriteLine("Digite a idade: ");
    idade = Convert.ToInt32(Console.ReadLine());

    if (idade == 0)
    {
        media = soma / quantidade;
        Console.WriteLine($"A média das idades é: {media}");
    }
    soma += idade;
}