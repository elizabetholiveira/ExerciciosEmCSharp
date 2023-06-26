
Console.WriteLine("Digite seu peso:");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua altura:");
double altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Peso: " + peso);
Console.WriteLine("Altura: " + altura);

double imc = peso / (altura * altura);

bool muitoAbaixo = imc < 16.9;
bool abaixo = imc >= 17 && imc < 18.4;
bool normal = imc >= 18.5 && imc < 24.9;
bool acima = imc >= 25 && imc < 29.9;
bool obesidade1 = imc >= 30 && imc < 34.9;
bool obesidade2 = imc >= 35 && imc < 40;
bool obesidade3 = imc >= 40;

Console.WriteLine("Seu IMC é de: " + imc.ToString("N1"));

if (muitoAbaixo) {
    Console.WriteLine("Peso muito abaixo do ideal");
} if (abaixo) {
    Console.WriteLine("Peso abaixo do ideal");
} if (normal) {
    Console.WriteLine("Peso ideal");
} if (acima) {
    Console.WriteLine("Peso acima do ideal");
} if (obesidade1) {
    Console.WriteLine("Obesidade Grau I");
} if (obesidade2) {
    Console.WriteLine("Obesidade Grau II");
} if (obesidade3) {
    Console.WriteLine("Obesidade Grau III");
}
