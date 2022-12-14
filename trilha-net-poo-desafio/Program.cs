using DesafioPOO.Models;
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "A22", imei: "987654321", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine("\n\nSmartphone Iphone");
Smartphone iphone = new Iphone(numero: "123456", modelo: "14s", imei: "987654321", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");


// TODO: Realizar os testes com as classes Nokia e Iphone