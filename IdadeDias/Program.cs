using System;

    class IdadeDias
    {
        public static void Main(string[] args)
        {
            //  5 / 7 - Idade em Dias
            int idadeEmDias = int.Parse(Console.ReadLine());
            int anos = 0; // Implemente aqui o calculo dos anos
            int meses = 0; // Implemente aqui o calculo dos meses 
            int dias = 0; // Implemente aqui o calculo dos dias
            if (idadeEmDias < 30)
            {
                dias = idadeEmDias;
            }
            if (idadeEmDias >= 30)
            {
                meses = idadeEmDias / 30;

                dias = idadeEmDias % 30;
            }
            if (idadeEmDias >= 365 && meses >= 12)
            {
                anos = idadeEmDias / 365;
                meses = (idadeEmDias % 365) / 30;
                dias = (idadeEmDias % 365) % 30;
            }
            Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");

        }
    }
