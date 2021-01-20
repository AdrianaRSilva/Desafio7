using System;

namespace TempoDobby
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] line = Console.ReadLine().Split(" ");
            int A = int.Parse(line[0]);
            int B = int.Parse(line[1]);

            if ((A + B) > N) { Console.Write("Deixa para amanha!"); }
            else { Console.Write("Farei hoje!"); }
        }
    }
}
