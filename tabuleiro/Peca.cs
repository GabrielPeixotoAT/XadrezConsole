namespace XadrezConsole.tabuleiro
{
    class Peca
    {
        public Posicao posicao {get; set;}
        public Cor cor {get; protected set;}
        public int qtdMovimentos {get; protected set;}
        public Tabuleiro tab {get; protected set;}

        public Peca(Tabuleiro tab, Cor cor)
        {
            posicao = null;
            this.tab = tab;
            this.cor = cor;
            qtdMovimentos = 0;
        }

        public void IncrementarQtdMovimentos()
        {
            qtdMovimentos++;
        }
    }
}