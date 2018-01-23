
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
    }
}
