using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new("88 9 8888-8888", "ASD", "1111-1111", 4);
Console.WriteLine($"Nokia {nokia.Numero}:");
nokia.Ligar();
nokia.InstalarAplicativo("Gmail");

Console.WriteLine();

Iphone iphone = new("88 9 7777-7777", "QWE", "2222-2222", 2);
Console.WriteLine($"Iphone {iphone.Numero}:");
iphone.Ligar();
iphone.InstalarAplicativo("Hotmail");