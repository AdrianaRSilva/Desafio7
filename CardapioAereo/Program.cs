using System;

class Desafio
{
    static void Main(string[] args)
    {
        //   2 / 7 - Cardápio Aéreo
        string[] entrada1 = Console.ReadLine().Split(" ");
        int Ca = int.Parse(entrada1[0]);
        int Ba = int.Parse(entrada1[1]);
        int Pa = int.Parse(entrada1[2]);
        string[] entrada2 = Console.ReadLine().Split(" ");
        int Cr = int.Parse(entrada2[0]);
        int Br = int.Parse(entrada2[1]);
        int Pr = int.Parse(entrada2[2]);
        int refeicao = 0;
        if (Ca < Cr)
            refeicao += Cr - Ca;
        if (Ba < Br)
            refeicao += Br - Ba;
        if (Pa < Pr)
            refeicao += Pr - Pa;
        Console.WriteLine(refeicao);
    }
}