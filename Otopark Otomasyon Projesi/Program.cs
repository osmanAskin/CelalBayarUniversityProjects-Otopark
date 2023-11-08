using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aracınızın türünü giriniz [otomobil] - [kamyon] veya [iş makinası]: ");
        string aracTuru = Console.ReadLine();

        Console.WriteLine("Otoparkta kalma süresini girin [saat olarak]: ");
        int kalanSaat = int.Parse(Console.ReadLine());

        double cikisUcreti = HesaplaCikisUcreti(aracTuru, kalanSaat);
        Console.WriteLine($"{aracTuru} için çıkış ücreti: {cikisUcreti} TL");
    }

    static double HesaplaCikisUcreti(string aracTuru, int kalanSaat)
    {
        double ucret = 0;

        if (aracTuru == "otomobil")
        {
            if (kalanSaat <= 2)
            {
                ucret = 5;
            }
            else if (kalanSaat <= 10)
            {
                ucret = 5 + (kalanSaat - 2);
            }
            else
            {
                ucret = 5 + 8 + (kalanSaat - 10);
            }
        }
        else if (aracTuru == "kamyon")
        {
            if (kalanSaat <= 2)
            {
                ucret = 8;
            }
            else if (kalanSaat <= 8)
            {
                ucret = 8 + (kalanSaat - 2) * 2;
            }
            else
            {
                ucret = 8 + 12 + (kalanSaat - 8);
            }
        }
        else if (aracTuru == "iş makinası")
        {
            if (kalanSaat <= 2)
            {
                ucret = 12;
            }
            else
            {
                ucret = 12 + (kalanSaat - 2) * 3;
            }
        }

        
        if (kalanSaat > 8)
        {
            ucret += SabitUcretHesapla(aracTuru);
        }

        return ucret;
    }

    static double SabitUcretHesapla(string aracTuru)
    {
        double sabitucret = 0;

        switch (aracTuru)
        {
            case "otomobil":
                sabitucret = 10;
                break;
            case "kamyon":
                sabitucret = 20;
                break;
            case "iş makinası":
                sabitucret = 30;
                break;
        }

        return sabitucret;
    }
}

