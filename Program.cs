Console.Clear();
/*
Salário hora base
total de horas trabalhadas
horas extras feitas
cada hora extra +40%salario

salario = 100
salariox = 40

100x = 40 * salario
x = (40 * salario) / 100
*/

string lerSalario, lerHoras, lerExtras;
float salario, horas, extras, salarioextra, pagamento;

Console.WriteLine("Seu salário por hora?:");
lerSalario = Console.ReadLine()!;

while (!(Single.TryParse(lerSalario, out float teste)))
{
    Console.WriteLine("Não é um número! Tente novamente.");
    lerSalario = Console.ReadLine()!;
}

Console.WriteLine("Quantas você trabalhou excluindo extras?");
lerHoras = Console.ReadLine()!;

while (!(Single.TryParse(lerHoras, out float teste)))
{
    Console.WriteLine("Não é um número! Tente novamente.");
    lerHoras = Console.ReadLine()!;
}

Console.WriteLine("Quantas horas extras você trabalhou?");
lerExtras = Console.ReadLine()!;

while (!(Single.TryParse(lerExtras, out float teste)))
{
    Console.WriteLine("Não é um número! Tente novamente.");
    lerExtras = Console.ReadLine()!;
}

salario = Convert.ToSingle(lerSalario);
horas = Convert.ToSingle(lerHoras);
extras = Convert.ToSingle(lerExtras);

salarioextra = (40 * salario) / 100;

pagamento = (salario * horas) + (extras * salarioextra);
Console.WriteLine($"Seu pagamento será: R${Math.Round(pagamento, 2)}");
