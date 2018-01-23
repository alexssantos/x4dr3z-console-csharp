using tabuleiro;
using System;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);

            //colocar peça no tabuleiro.
            tab.ColocarPeca(...., new Posicao(0, 0));
            tab.ColocarPeca(....., new Posicao(0, 0));
            tab.ColocarPeca(....., new Posicao(0, 0));


            Console.ReadLine();


        }
    }
}
