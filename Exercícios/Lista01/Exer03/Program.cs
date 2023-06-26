Console.WriteLine("Digite o seu salário:");
double salario = Convert.ToDouble(Console.ReadLine());

double salarioMinimo = 1212.00;

double salarioMinimoVezes = salario / salarioMinimo;

Console.WriteLine("Seu salário: " + salario.ToString("C"));
Console.WriteLine("Salário mínimo: " + salarioMinimo.ToString("C"));
Console.WriteLine("Você recebe " + salarioMinimoVezes.ToString("N1") + " vezes o salário mínimo");