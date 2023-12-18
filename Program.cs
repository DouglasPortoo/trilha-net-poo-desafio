using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero:"123456", modelo:"Modelo 1",imei:"1111111",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Zap Zap");

Iphone iphone = new Iphone(numero:"789456", modelo:"Modelo 2",imei:"22222",memoria:84);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

