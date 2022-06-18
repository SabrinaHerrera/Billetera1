using Billetera1;

Console.WriteLine("Estas son nuestras billeteras");

//Primer Billetera

Billetera b1 = new Billetera();
b1.BilleteDe20 = 10;
b1.BilleteDe1000 = 1;

Console.WriteLine($"La billetera N° 1 tiene {b1.Total}");


//Segunda Billetera

Billetera b2 = new Billetera();
b2.BilleteDe50 = 10;
b2.BilleteDe500 = 2;
b2.BilleteDe1000 = 3;

//Terecer Billetera

Billetera b3 = b1.Combinar(b1);






