using System;
using XadrezConsole.tabuleiro;
using XadrezConsole.xadrez;

namespace XadrezConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            */
            try {
                PartidaXadrez partidaXadrez = new PartidaXadrez();

                while (!partidaXadrez.terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partidaXadrez.tab);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partidaXadrez.ExecutaMovimento(origem, destino);
                }
                
            }
            catch (TabuleiroExeption e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}