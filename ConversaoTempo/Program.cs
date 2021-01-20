using System;
class Desafio
{
    static void Main(string[] args)
    {
        int Tempo, Hs, Min, Seg;
        Tempo = int.Parse(Console.ReadLine());
        Hs = Tempo / 3600;
        Min = Tempo % 3600 / 60;
        Seg = Tempo % 60;
        Console.WriteLine(Hs + ":" + Min + ":" + Seg);
    }
}