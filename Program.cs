using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Começando");

Nokia nk = new Nokia("9999-9999","Nokia","seilaImei",64);
nk.Ligar();
nk.InstalarAplicativo("Novo appp");

Console.WriteLine("\n");

Iphone iphone = new Iphone("88888-8888", "Iphone", "seilaImei", 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Novo appp");
