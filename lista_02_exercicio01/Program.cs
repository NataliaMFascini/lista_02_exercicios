/*1) Um funcionário deseja contar quantos dias de trabalho ele teve em um mês.
 * Para isso, ele deve inserir os dias trabalhados (de 1 a 31) até que digite 0, que indica que terminou de informar os dias.
 * O aluno deve implementar essa contagem utilizando estruturas de repetição while, do while e for.
 */

int dias = 1;
int diasTrabalhados = 0;

while (dias != 0)
{ 
    Console.WriteLine("Quantos dias foram trabalhados?");
    dias = Convert.ToInt32(Console.ReadLine());
    diasTrabalhados++;
}

Console.WriteLine($"A quantidade de dias trabalhados foi {diasTrabalhados}");
