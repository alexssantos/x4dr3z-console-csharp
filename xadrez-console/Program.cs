using tabuleiro;
using xadrez;
using System;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);

            //colocar peça no tabuleiro.
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));


            Console.ReadLine();


        }
    }
}
