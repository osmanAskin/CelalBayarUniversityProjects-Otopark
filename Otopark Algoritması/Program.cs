Console.WriteLine("Hoş Geldiniz Gir Araç Tür Otomobil[1]-Kamyon[2]-İşmakinasi[3] ");
var aracTuru = int.Parse(Console.ReadLine());

Console.WriteLine("Araciniz İçeride Kaç Saat Durdu Yaz");
var kalmaSuresi = int.Parse(Console.ReadLine());

int ucret = 0;

if(aracTuru == 1)
{
    if(kalmaSuresi <= 2)
    {
        ucret = 5;
    }

    else if (kalmaSuresi > 2 && kalmaSuresi < 8)
    {
        ucret = 5+ (kalmaSuresi - 2)*1 ;
    }

    else if (kalmaSuresi > 10)
    {
        ucret = 13;
    }
}
else if(aracTuru == 2)
{
     if (kalmaSuresi <= 2)
    {
        ucret = 8;
    }

     else if (kalmaSuresi > 2 && kalmaSuresi < 8)
    {
        ucret = 8 + (kalmaSuresi - 2) * 2;
    }
     else if (kalmaSuresi > 8)
    {
        ucret = 20;
    }
}
else if (aracTuru == 3)
{
    if (kalmaSuresi <= 2)
    {
        ucret = 12;
    }
    else if (kalmaSuresi > 2 && kalmaSuresi < 8)
    {
        ucret = 12 + (kalmaSuresi - 2) * 3;
    }
    else if (kalmaSuresi > 8)
    {
        ucret = 30;
    }
}

Console.WriteLine("Borcunuz : " + ucret + " TL'dir ");

