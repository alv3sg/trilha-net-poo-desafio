using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("+351927383060", "A34", "123A5", 16);
Iphone iphone = new Iphone("+351927383052", "XS", "123AS", 16);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");