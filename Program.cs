string Nome, Sobrenome;

Console.Write("Escreva seu Primeiro Nome:");
Nome=Console.ReadLine();

Console.Write("Escreva seu Sobrenome:");
Sobrenome=Console.ReadLine();

Console.WriteLine($"{Nome} {Sobrenome}");
Console.WriteLine($"{Sobrenome.ToUpper()}, {Nome}");