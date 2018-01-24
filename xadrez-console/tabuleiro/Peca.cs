
namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public Tabuleiro tabuleiro { get; set; }
        public int qteMovimentos { get; set; }
        
        //Peça sempre criada com 1 posição, 1 tabuleiro e 1 cor.
        public Peca (Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tabuleiro = tab;
            this.cor = cor;
            qteMovimentos = 0;
        }

        public void incremetarQteMovimentos()
        {
            qteMovimentos++;
        }
    }
}
