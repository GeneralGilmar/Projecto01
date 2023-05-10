// See https://aka.ms/new-console-template for more information
using Pratica02;
using System.Globalization;




Produto p = new Produto();

string nome;
Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preço: ");
p.Preco= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Quantidade em estoque: ");
p.Quantidade=int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto :" + p);
Console.Write("digite o número de produtos a ser adicionado ao estoque: ");
p.AdicionarPruduto(int.Parse(Console.ReadLine()));
Console.WriteLine("Dados do produto :"+ p);


p.RemoverProdutos(int.Parse(Console.ReadLine()));
Console.WriteLine("Dados do produto :" + p);


