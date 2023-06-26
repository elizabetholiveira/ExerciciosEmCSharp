Console.WriteLine("Diga quantos anos, meses e dias de vida você tem");
int anos = Convert.ToInt32(Console.ReadLine());
int meses = Convert.ToInt32(Console.ReadLine());
int dias = Convert.ToInt32(Console.ReadLine());

int totalDias = (anos * 365) + (meses * 30) + (dias);

Console.WriteLine("Você tem um total de " + totalDias + " dias de idade");