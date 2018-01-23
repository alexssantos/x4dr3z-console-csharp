
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        //MATRIZ de peças.
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //Metodo pra acessar a MATRIZ
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        //Colocar uma peça no tabuleiro
        public void ColocarPeca(Peca p, Posicao pos)
        {
            //colocar a peça no tabuleiro com as corredenadas passadas no obj Posição.
            pecas[pos.linha, pos.coluna] = p;
            //Dizer à peça qual é a sua posição.
            p.posicao = pos;
        }
    }
}
