using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xad
{
    class PosicaoXadrez
    {
        public int linha { get; set; }
        public char coluna { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
