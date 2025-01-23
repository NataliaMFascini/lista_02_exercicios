/*4) Um grupo de amigos deseja calcular as idade média deles.
 * Para isso, o aluno deve pedir que o usuário insira as idades e calcule a média até que o usuário digite 0.
 * A solução deve ser implementada usando while, do while e for.
 */

using System;

int idade = 1;
int media = 0;

//while
while(idade != 0)
{
    Console.WriteLine("Digite a idade: ");
    idade = Convert.ToInt32(Console.ReadLine());


    if (idade == 0)
    {
        Console.WriteLine($"A média das idades é: {media}");
    }
    else
    {
        media += idade;
        idade = 1;
    }
}

//do while
do
{
    Console.WriteLine("Digite a idade: ");
    idade = Convert.ToInt32(Console.ReadLine());


    if (idade == 0)
    {
        Console.WriteLine($"A média das idades é: {media}");
    }
    else
    {
        media += idade;
        idade = 1;
    }
}while(idade != 0);

//for
for(int i = 0; i != 0; i++)
{
    Console.WriteLine("Digite a idade: ");
    i = Convert.ToInt32(Console.ReadLine());


    if (i == 0)
    {
        Console.WriteLine($"A média das idades é: {media}");
    }
    else
    {
        media += i;
        i = 1;
    }
}