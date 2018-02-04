using tabuleiro;
using xadrez;
using System;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Terminado Parte1

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                Tela.imprimirTabuleiro(partida.tab);


                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    //pega posição de Xadrez e converte em posição matriz
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().ConvParaPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ConvParaPosicao();

                    partida.executaMovimento(origem, destino);
                }



            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
                      
            Console.ReadLine();


        }
    }
}
