using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez(7, 'c');

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());

            Console.WriteLine();
        }
    }
}
