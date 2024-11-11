using DesafioPOO.Models;
//Testes com as Classes devidamente estabelecidas.
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero: "9999-9999", modelo: "Modelo Indestrutivel", imei: "00000000", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone(numero: "6666-6666", modelo: "Modelo Quebra Fácil", imei: "111111111", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");