using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Modelo 01", "11111111111", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Baixou o WhatsApp pela Play Store");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("987654321", "Modelo 10", "22222222222", 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Baixou o Telegram pelo App Store");
