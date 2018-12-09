using tabuleiro;
using System;
using xadrez;

namespace Jogo_de_Xadrez_em_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i=0; i< tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    

                    if (tab.peca(i, j) == null)
                    {

                        Console.Write("- ");

                    }
                    else
                    {

                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                        //Console.Write(tab.peca(i, j) + " ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            //int linha = int.Parse(s[1].ToString()); converter char para string para converter para int
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha); 
        }
        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                Console.Write(peca);

            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            
        }
    }
}
