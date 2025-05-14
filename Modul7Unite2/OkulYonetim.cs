using System;

interface IInsan
{
    void Buyu();
}

class Ogrenci : OkuyanInsan, IInsan
{
    public void Buyu()
    {
        Console.WriteLine("Hızlı büyüdüm.");
    }
}

class Ogretmen : OkuyanInsan, IInsan
{
    public void Buyu()
    {
        Console.WriteLine("Yavaş büyüdüm.");
    }
}

abstract class OkuyanInsan
{
    public void Oku()
    {
        Console.WriteLine("Okudum.");
    }
}
