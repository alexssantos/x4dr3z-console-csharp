
namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get;  }
        public Tabuleiro tabuleiro { get; set; }

        public Peca (Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tabuleiro = tab;
            this.cor = cor;
            qteMovimentos = 0;
        }
    }
}
