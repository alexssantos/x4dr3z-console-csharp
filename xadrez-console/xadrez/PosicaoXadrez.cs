using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        
        public char coluna { get; set; }
        public int linha { get; set; }
        //LINHAS = NUMEROS, COLUNAS = LETRAS.

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        //MAPEAMENTO DE POSIÇÔES: converte char e int em numeros para a matriz pos_peças_tab
        public Posicao ConvParaPosicao()
        {
            //Matriz conta as linhas de cima pra baixo.
            //sequencia de char 'a' = x, 'b' = x+1, 'c'= x+2, etc.
            //ordem tabuleiro deve ficar: linha da Esq para Dir (A-H), coluna de baixo para cima(1-8).
            Posicao pos = new Posicao(8 - linha, coluna - 'a' );
            return pos;

        }

        public override string ToString()
        {
            return $"{(coluna).ToString().ToUpper()}{(linha).ToString().ToUpper()}";
        }
    }
}
