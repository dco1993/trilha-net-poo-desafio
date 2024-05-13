using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456", "Modelo 1", "1234567890", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone("789123", "Modelo 2", "1234567891", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");