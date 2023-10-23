

int sıcaklık = 32;

if (sıcaklık <= (int)HavaDurumu.Normal)
    Console.WriteLine("Hava sıcak olmayabilir.");
else if (sıcaklık >= (int)HavaDurumu.Sıcak)
    Console.WriteLine("Hava çok sıcak.");
else if (sıcaklık >= (int)HavaDurumu.CokSıcak)
    Console.WriteLine("Hava fazla sıcak.");



enum Gunler
{
    Pazartesi = 1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma = 23,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk = 5,
    Normal = 20,
    Sıcak = 25,
    CokSıcak = 30
}