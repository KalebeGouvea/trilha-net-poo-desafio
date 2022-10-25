using DesafioPOO.Models;

// Realizando os testes com as classes Nokia e Iphone

Console.WriteLine("Instanciando a classe do smartphone Nokia");
Smartphone nokia = new Nokia(numero: "99 99999-9999", modelo: "C20", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo(nomeApp: "WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Instanciando a classe do smartphone iPhone");
Smartphone iphone = new Iphone(numero: "33 33333-3333", modelo: "13", imei: "99999999", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo(nomeApp: "TikTok");