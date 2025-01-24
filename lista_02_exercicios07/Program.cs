/*7) Um ciclista deseja saber a distancia total que percorreu.
 * Para isso, o aluno deve solicitar que o usuario insira as distancias percorridas em cada dia até que um valor negativo seja digitado.
 * A soma das distancias deve ser calculada e exibida utilizando while, do while e for.
 * */

double distancia = 0;
double distanciaTotal = 0;

////while
while (distancia >= 0)
{
    Console.WriteLine("Digite a distancia percorrida: ");
    distancia = Convert.ToDouble(Console.ReadLine());
    if (distancia >= 0) distanciaTotal += distancia;
}

//do while
do
{
    Console.WriteLine("Digite a distancia percorrida: ");
    distancia = Convert.ToDouble(Console.ReadLine());
    if (distancia >= 0) distanciaTotal += distancia;
} while (distancia >= 0);

//for
for (int i = 0; distancia >= 0; i++)
{
    Console.WriteLine("Digite a distancia percorrida: ");
    distancia = Convert.ToDouble(Console.ReadLine());
    if (distancia >= 0) distanciaTotal += distancia;
}

Console.WriteLine($"Distancia total percorrida é de {distanciaTotal}.");