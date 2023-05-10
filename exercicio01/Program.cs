// See https://aka.ms/new-console-template for more information

using exercicio01;

Pessoa pessoa = new Pessoa();
Pessoa pessoa2= new Pessoa();

Console.WriteLine(" Dados da primeira pessoa");

pessoa.name = Console.ReadLine();
pessoa.age=int.Parse(Console.ReadLine());


pessoa2.name = Console.ReadLine();
pessoa2.age = int.Parse(Console.ReadLine());

if (pessoa.age > pessoa.age) {
    Console.WriteLine(" A pessoa mais velha é "+pessoa.name);
}
else {
    Console.WriteLine(" a pessoa  mais velha é "+pessoa2.name);
}

