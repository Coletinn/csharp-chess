using System;
using tabuleiro;
using xad;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('d', 5);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            
        }
    }
}
