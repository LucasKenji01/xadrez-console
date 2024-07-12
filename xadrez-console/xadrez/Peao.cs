using System.Runtime.ConstrainedExecution;
using tabuleiro;

namespace xadrez
{

    class Peao : Peca
    {

        public Peao(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "P";
        }

        private bool ExisteInimigo(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);
            return peca != null && peca.Cor != Cor;
        }

        private bool Livre(Posicao posicao)
        {
            return Tabuleiro.Peca(posicao) == null;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao posicao = new Posicao(0, 0);

            if (Cor == Cor.Branca)
            {
                posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(posicao) && Livre(posicao))
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }
                posicao.DefinirValores(Posicao.Linha - 2, Posicao.Coluna);
                Posicao p2 = new Posicao(posicao.Linha - 1, posicao.Coluna);
                if (Tabuleiro.PosicaoValida(p2) && Livre(p2) && Tabuleiro.PosicaoValida(posicao) && Livre(posicao) && QteMovimentos == 0)
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }
                posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }
                posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }
            }
            else
            {
                posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(posicao) && Livre(posicao))
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }
                posicao.DefinirValores(Posicao.Linha + 2, Posicao.Coluna);
                Posicao p2 = new Posicao(Posicao.Linha + 1, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(p2) && Livre(p2) && Tabuleiro.PosicaoValida(posicao) && Livre(posicao) && QteMovimentos == 0)
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }
                posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }
                posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }
            }

            return mat;
        }
    }
}