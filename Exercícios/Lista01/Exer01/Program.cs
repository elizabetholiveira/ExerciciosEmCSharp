double pesoMax = 50;
double multa = 4.00;

Console.WriteLine("Quantos quilos de peixe você pegou?");
double pesoPeixe = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Você pegou: " + pesoPeixe + " quilos de peixe");

Console.WriteLine();

if (pesoPeixe > pesoMax){
    double excesso = pesoPeixe - pesoMax;
    double multaPagar = excesso * multa;
    Console.WriteLine("O peso do peixe ultrapassou o limite em: " + excesso + " quilos");
    Console.WriteLine("Você deverá pagar " + multaPagar + " reais de multa!");
} else if (pesoPeixe <= pesoMax){
    Console.WriteLine("Você está dentro do peso permitido");
}

Console.WriteLine();
Console.WriteLine("Tenha um bom dia!");