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

//string lerSalario, lerHoras, lerExtras;
float salario, horas, extras, salarioextra, pagamento;

Console.WriteLine("Seu salário por hora?:");
salario = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Quantas você trabalhou excluindo extras?");
horas = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Quantas horas extras você trabalhou?");
extras = Convert.ToSingle(Console.ReadLine());

salarioextra = (40 * salario) / 100;

pagamento = (salario * horas) + (extras * salarioextra);
Console.WriteLine($"Seu pagamento será: R${Math.Round(pagamento, 2)}");