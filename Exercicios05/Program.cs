// See https://aka.ms/new-console-template for more information


using Exercicios05;
using System.Globalization;

double cot, quant;
Console.WriteLine("Qual é a cotação do dolar?");
cot=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Quantos dólares você vai comprar?");
quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("valor a ser pago em reais");
Console.WriteLine((ConversorDEMoeda.Cotacao(cot,quant)+ ConversorDEMoeda.Cotacao(cot, quant)*0.06).ToString("F2",CultureInfo.InvariantCulture));
