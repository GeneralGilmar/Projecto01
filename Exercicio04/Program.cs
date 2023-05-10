// See https://aka.ms/new-console-template for more information
using Exercicio04;
using System.Globalization;

Console.Write("Nome do aluno: ");

string Nome=Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno");

Aluno a = new Aluno(Nome,double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture),
    double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine("Nota Final "+a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

if (a.IsAproved()) {
    Console.WriteLine("Aprovado");
}
else {
    Console.WriteLine("Reprovado");
    Console.WriteLine("Faltaram "+a.Falta().ToString("F2",CultureInfo.InvariantCulture));
}


