// See https://aka.ms/new-console-template for more information


using exercicio03;
using System.Globalization;

Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Salário bruto: ");
double salarioBruto=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.Write("Imposto: ");

double imposto= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Funcionario f=new Funcionario(nome,salarioBruto,imposto);

Console.WriteLine("Funcionario: "+f);

f.AumentarSalario(10.0);
Console.WriteLine(f);

