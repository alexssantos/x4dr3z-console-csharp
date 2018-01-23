using tabuleiro;
using xadrez;
using System;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            #region try
            //try { 
            //    Tabuleiro tab = new Tabuleiro(8, 8);

            //    //colocar peça no tabuleiro.
            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            //    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 8));

            //    Tela.imprimirTabuleiro(tab);
            //}
            //catch(TabuleiroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            PosicaoXadrez posicaoPeca = new PosicaoXadrez('a', 1);
            Console.WriteLine(posicaoPeca.ConvParaPosicao());
            Console.WriteLine();

            Posicao pos = posicaoPeca.ConvParaPosicao();

            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(pos.linha, pos.coluna));
            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();


        }
    }
}
