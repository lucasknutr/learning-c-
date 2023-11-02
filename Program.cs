using System.Linq.Expressions;
using FirstApp;

// Don't forget to use the M after a decimal number
decimal n1 = 25.32M;
int n2 = 14;

// String representation
string hey = "Hello, my name is Lucas";
string credentials = "I'm a web developer";

// Boolean representation
bool isItCool = false;

// String Concatenation
if (isItCool == false)
Console.WriteLine(n1 + n2);
// Console.WriteLine(string.Format("{0} - {0} - {1}", hey, credentials));
Console.WriteLine($"{hey}. {credentials}");

// var valorDoSaque2 = 200;
int valor = 200;

// For - Estrutura de repeticao
for (int i = 1; i <= 3; i++){
    Console.WriteLine($"Mês {i}: {valor}");
    valor += 200;
}

// Using classes
var pessoa = new Pessoa("Lucas", 1300);
Console.WriteLine($"Nome: {pessoa.Nome}, Saldo: {pessoa.Saldo}");

// Brazilian Portuguese
var userChoice = Console.ReadLine();

if (userChoice!.Length > 10)
{
    Console.WriteLine("Você digitou mais de 10 caracteres");
} else {
    Console.WriteLine("Você digitou menos de 10 caracteres");
}