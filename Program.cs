using DesafioPOO.Models;

Console.WriteLine("REALIZAÇÃO DE TESTES PARA A ABSTRAÇÃO DE UM SMARTPHONE");
Console.WriteLine("\nTESTE 01 - SMARTPHONE NOKIA\n");
Nokia nokia = new Nokia("+55 21 96122-3341", "Lumia 950", "353612650656221", 128);
nokia.Informacoes();
nokia.Ligar();
nokia.InstalarAplicativo("Spotify");

Console.WriteLine("\nTESTE 02: SMARTPHONE IPHONE...\n");
Iphone iphone = new Iphone("+55 11 95154-4163", "Iphone 15 Pro", "353864165920218", 256);
iphone.Informacoes();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");