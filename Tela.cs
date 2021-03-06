using System;
using XadrezConsole.tabuleiro;
using XadrezConsole.xadrez;

namespace XadrezConsole
{
    class Tela
    {

        public static void ImprimirTabuleiro(Tabuleiro tab) 
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write((8 - i) + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.GetPeca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.GetPeca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branco)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1].ToString());
            return new PosicaoXadrez(coluna, linha);
        }
    }
}