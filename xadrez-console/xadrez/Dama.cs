﻿using tabuleiro;

namespace xadrez
{
    internal class Dama : Peca
    {
        public Dama(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override string ToString()
        {
            return "D";
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);
            return peca == null || peca.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao posicao = new Posicao(0, 0);

            //Esquerda
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.DefinirValores(posicao.Linha, posicao.Coluna - 1);
            }

            //Direita
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.DefinirValores(posicao.Linha, posicao.Coluna + 1);
            }

            //Acima
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna);
            }

            //Abaixo
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna);
            }

            //NO
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
            }

            //NE
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
            }

            //SE
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
            }

            //SO
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
            }

            return mat;
        }
    }
}
