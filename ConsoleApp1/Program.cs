// See https://aka.ms/new-console-template for more information
using System.Globalization;


Console.WriteLine("Entre com seu nome");
string s= Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa");
int nQuartos=int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o seu preço de um produto:");
double pProduto=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Entre seu último nome, idade e altura");
string[] en = Console.ReadLine().Split(" ");

string lastName = en[0];
int idade = int.Parse(en[1]);
double altura = double.Parse(en[2], CultureInfo.InvariantCulture);

Console.WriteLine(s);
Console.WriteLine(nQuartos);
Console.WriteLine(pProduto);
Console.WriteLine(lastName);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));