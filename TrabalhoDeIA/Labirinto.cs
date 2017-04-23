using System;
using System.Collections.Generic;

namespace TrabalhoDeIA
{
	public static class Labirinto
	{
        public static void Andar(string[,] labirinto, Posicao posicaoAtual, Posicao posicaoEscolhida )
        {
            labirinto[posicaoAtual.Linha, posicaoAtual.Coluna] = "*";
            labirinto[posicaoEscolhida.Linha, posicaoEscolhida.Coluna] = "C";
            posicaoAtual.Linha = posicaoEscolhida.Linha;
            posicaoAtual.Coluna = posicaoEscolhida.Coluna;

            Imprime(labirinto);
        }


        public static List<Posicao> CaminhosLivres(string[,] posicaoAtual, Posicao coelho)
		{
			List<Posicao> caminho = new List<Posicao>();

			if (posicaoAtual[coelho.Linha, coelho.Coluna - 1] == " ")
                caminho.Add(new Posicao(coelho.Linha, coelho.Coluna - 1));

            if (posicaoAtual[coelho.Linha - 1, coelho.Coluna] == " ")
                caminho.Add(new Posicao(coelho.Linha - 1, coelho.Coluna));
                     
			if (posicaoAtual[coelho.Linha, coelho.Coluna + 1] == " ")
               	caminho.Add(new Posicao(coelho.Linha, coelho.Coluna + 1));
            
			if (posicaoAtual[coelho.Linha + 1, coelho.Coluna] == " ")
				caminho.Add(new Posicao(coelho.Linha + 1, coelho.Coluna));

			return caminho; 
		}

		public static void Imprime( string[,] labirinto ) 
		{
			for (int i = 0; i < 21; i++)
			{
				for (int j = 0; j < 21; j++)
				{
					if (labirinto[i, j] == "X")
					{
						Console.BackgroundColor = ConsoleColor.DarkGray;
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write("[" + labirinto[i, j] + "]");
						Console.ResetColor();
					}
                    else if (labirinto[i, j] == "C" || labirinto[i, j] == "*")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("[" + labirinto[i, j] + "]");
                        Console.ResetColor();
                    }
					else if (labirinto[i, j] == "E" || labirinto[i, j] == "S")
					{
                        Console.BackgroundColor = ConsoleColor.DarkRed;
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write("[" + labirinto[i, j] + "]");
						Console.ResetColor();
					}
					else
						Console.Write("[" + labirinto[i, j] + "]");

					if (j == 20)
						Console.Write("\n");

				}
			}
			Console.WriteLine("\n");
		}

		public static string[,] getLabirinto()
		{
			var Labirinto = new string[21, 21];

			Labirinto[0, 0] = "X";
			Labirinto[0, 1] = "X";
			Labirinto[0, 2] = "X";
			Labirinto[0, 3] = "X";
			Labirinto[0, 4] = "X";
			Labirinto[0, 5] = "X";
			Labirinto[0, 6] = "X";
			Labirinto[0, 7] = "X";
			Labirinto[0, 8] = "X";
			Labirinto[0, 9] = "X";
			Labirinto[0, 10] = "X";
			Labirinto[0, 11] = "X";
			Labirinto[0, 12] = "X";
			Labirinto[0, 13] = "X";
			Labirinto[0, 14] = "X";
			Labirinto[0, 15] = "X";
			Labirinto[0, 16] = "X";
			Labirinto[0, 17] = "X";
			Labirinto[0, 18] = "X";
			Labirinto[0, 19] = "X";
			Labirinto[0, 20] = "X";
			Labirinto[1, 0] = "E";
			Labirinto[1, 1] = " ";
			Labirinto[1, 2] = "X";
			Labirinto[1, 3] = " ";
			Labirinto[1, 4] = " ";
			Labirinto[1, 5] = " ";
			Labirinto[1, 6] = " ";
			Labirinto[1, 7] = " ";
			Labirinto[1, 8] = " ";
			Labirinto[1, 9] = " ";
			Labirinto[1, 10] = "X";
			Labirinto[1, 11] = " ";
			Labirinto[1, 12] = " ";
			Labirinto[1, 13] = " ";
			Labirinto[1, 14] = " ";
			Labirinto[1, 15] = " ";
			Labirinto[1, 16] = " ";
			Labirinto[1, 17] = " ";
			Labirinto[1, 18] = " ";
			Labirinto[1, 19] = " ";
			Labirinto[1, 20] = "X";
			Labirinto[2, 0] = "X";
			Labirinto[2, 1] = " ";
			Labirinto[2, 2] = "X";
			Labirinto[2, 3] = " ";
			Labirinto[2, 4] = "X";
			Labirinto[2, 5] = " ";
			Labirinto[2, 6] = "X";
			Labirinto[2, 7] = "X";
			Labirinto[2, 8] = "X";
			Labirinto[2, 9] = " ";
			Labirinto[2, 10] = "X";
			Labirinto[2, 11] = " ";
			Labirinto[2, 12] = "X";
			Labirinto[2, 13] = "X";
			Labirinto[2, 14] = "X";
			Labirinto[2, 15] = "X";
			Labirinto[2, 16] = "X";
			Labirinto[2, 17] = "X";
			Labirinto[2, 18] = "X";
			Labirinto[2, 19] = " ";
			Labirinto[2, 20] = "X";
			Labirinto[3, 0] = "X";
			Labirinto[3, 1] = " ";
			Labirinto[3, 2] = " ";
			Labirinto[3, 3] = " ";
			Labirinto[3, 4] = "X";
			Labirinto[3, 5] = " ";
			Labirinto[3, 6] = " ";
			Labirinto[3, 7] = " ";
			Labirinto[3, 8] = "X";
			Labirinto[3, 9] = " ";
			Labirinto[3, 10] = " ";
			Labirinto[3, 11] = " ";
			Labirinto[3, 12] = "X";
			Labirinto[3, 13] = " ";
			Labirinto[3, 14] = "X";
			Labirinto[3, 15] = " ";
			Labirinto[3, 16] = " ";
			Labirinto[3, 17] = " ";
			Labirinto[3, 18] = " ";
			Labirinto[3, 19] = " ";
			Labirinto[3, 20] = "X";
			Labirinto[4, 0] = "X";
			Labirinto[4, 1] = " ";
			Labirinto[4, 2] = "X";
			Labirinto[4, 3] = "X";
			Labirinto[4, 4] = "X";
			Labirinto[4, 5] = "X";
			Labirinto[4, 6] = "X";
			Labirinto[4, 7] = " ";
			Labirinto[4, 8] = "X";
			Labirinto[4, 9] = "X";
			Labirinto[4, 10] = "X";
			Labirinto[4, 11] = "X";
			Labirinto[4, 12] = "X";
			Labirinto[4, 13] = " ";
			Labirinto[4, 14] = "X";
			Labirinto[4, 15] = " ";
			Labirinto[4, 16] = "X";
			Labirinto[4, 17] = "X";
			Labirinto[4, 18] = "X";
			Labirinto[4, 19] = "X";
			Labirinto[4, 20] = "X";
			Labirinto[5, 0] = "X";
			Labirinto[5, 1] = " ";
			Labirinto[5, 2] = "X";
			Labirinto[5, 3] = " ";
			Labirinto[5, 4] = " ";
			Labirinto[5, 5] = " ";
			Labirinto[5, 6] = " ";
			Labirinto[5, 7] = " ";
			Labirinto[5, 8] = "X";
			Labirinto[5, 9] = " ";
			Labirinto[5, 10] = " ";
			Labirinto[5, 11] = " ";
			Labirinto[5, 12] = " ";
			Labirinto[5, 13] = " ";
			Labirinto[5, 14] = "X";
			Labirinto[5, 15] = " ";
			Labirinto[5, 16] = "X";
			Labirinto[5, 17] = " ";
			Labirinto[5, 18] = "X";
			Labirinto[5, 19] = " ";
			Labirinto[5, 20] = "X";
			Labirinto[6, 0] = "X";
			Labirinto[6, 1] = " ";
			Labirinto[6, 2] = "X";
			Labirinto[6, 3] = " ";
			Labirinto[6, 4] = "X";
			Labirinto[6, 5] = "X";
			Labirinto[6, 6] = "X";
			Labirinto[6, 7] = "X";
			Labirinto[6, 8] = "X";
			Labirinto[6, 9] = "X";
			Labirinto[6, 10] = "X";
			Labirinto[6, 11] = " ";
			Labirinto[6, 12] = "X";
			Labirinto[6, 13] = " ";
			Labirinto[6, 14] = "X";
			Labirinto[6, 15] = " ";
			Labirinto[6, 16] = "X";
			Labirinto[6, 17] = " ";
			Labirinto[6, 18] = "X";
			Labirinto[6, 19] = " ";
			Labirinto[6, 20] = "X";
			Labirinto[7, 0] = "X";
			Labirinto[7, 1] = " ";
			Labirinto[7, 2] = "X";
			Labirinto[7, 3] = " ";
			Labirinto[7, 4] = " ";
			Labirinto[7, 5] = " ";
			Labirinto[7, 6] = "X";
			Labirinto[7, 7] = " ";
			Labirinto[7, 8] = " ";
			Labirinto[7, 9] = " ";
			Labirinto[7, 10] = "X";
			Labirinto[7, 11] = " ";
			Labirinto[7, 12] = "X";
			Labirinto[7, 13] = " ";
			Labirinto[7, 14] = " ";
			Labirinto[7, 15] = " ";
			Labirinto[7, 16] = "X";
			Labirinto[7, 17] = " ";
			Labirinto[7, 18] = "X";
			Labirinto[7, 19] = " ";
			Labirinto[7, 20] = "X";
			Labirinto[8, 0] = "X";
			Labirinto[8, 1] = " ";
			Labirinto[8, 2] = "X";
			Labirinto[8, 3] = "X";
			Labirinto[8, 4] = "X";
			Labirinto[8, 5] = " ";
			Labirinto[8, 6] = "X";
			Labirinto[8, 7] = " ";
			Labirinto[8, 8] = "X";
			Labirinto[8, 9] = " ";
			Labirinto[8, 10] = "X";
			Labirinto[8, 11] = " ";
			Labirinto[8, 12] = "X";
			Labirinto[8, 13] = "X";
			Labirinto[8, 14] = "X";
			Labirinto[8, 15] = "X";
			Labirinto[8, 16] = "X";
			Labirinto[8, 17] = " ";
			Labirinto[8, 18] = "X";
			Labirinto[8, 19] = " ";
			Labirinto[8, 20] = "X";
			Labirinto[9, 0] = "X";
			Labirinto[9, 1] = " ";
			Labirinto[9, 2] = "X";
			Labirinto[9, 3] = " ";
			Labirinto[9, 4] = "X";
			Labirinto[9, 5] = " ";
			Labirinto[9, 6] = "X";
			Labirinto[9, 7] = " ";
			Labirinto[9, 8] = "X";
			Labirinto[9, 9] = " ";
			Labirinto[9, 10] = "X";
			Labirinto[9, 11] = " ";
			Labirinto[9, 12] = "X";
			Labirinto[9, 13] = " ";
			Labirinto[9, 14] = " ";
			Labirinto[9, 15] = " ";
			Labirinto[9, 16] = " ";
			Labirinto[9, 17] = " ";
			Labirinto[9, 18] = "X";
			Labirinto[9, 19] = " ";
			Labirinto[9, 20] = "X";
			Labirinto[10, 0] = "X";
			Labirinto[10, 1] = " ";
			Labirinto[10, 2] = "X";
			Labirinto[10, 3] = " ";
			Labirinto[10, 4] = "X";
			Labirinto[10, 5] = " ";
			Labirinto[10, 6] = "X";
			Labirinto[10, 7] = " ";
			Labirinto[10, 8] = "X";
			Labirinto[10, 9] = " ";
			Labirinto[10, 10] = "X";
			Labirinto[10, 11] = " ";
			Labirinto[10, 12] = "X";
			Labirinto[10, 13] = "X";
			Labirinto[10, 14] = "X";
			Labirinto[10, 15] = " ";
			Labirinto[10, 16] = "X";
			Labirinto[10, 17] = " ";
			Labirinto[10, 18] = "X";
			Labirinto[10, 19] = " ";
			Labirinto[10, 20] = "X";
			Labirinto[11, 0] = "X";
			Labirinto[11, 1] = " ";
			Labirinto[11, 2] = " ";
			Labirinto[11, 3] = " ";
			Labirinto[11, 4] = "X";
			Labirinto[11, 5] = " ";
			Labirinto[11, 6] = "X";
			Labirinto[11, 7] = " ";
			Labirinto[11, 8] = "X";
			Labirinto[11, 9] = " ";
			Labirinto[11, 10] = "X";
			Labirinto[11, 11] = " ";
			Labirinto[11, 12] = " ";
			Labirinto[11, 13] = " ";
			Labirinto[11, 14] = " ";
			Labirinto[11, 15] = " ";
			Labirinto[11, 16] = "X";
			Labirinto[11, 17] = " ";
			Labirinto[11, 18] = "X";
			Labirinto[11, 19] = " ";
			Labirinto[11, 20] = "X";
			Labirinto[12, 0] = "X";
			Labirinto[12, 1] = "X";
			Labirinto[12, 2] = "X";
			Labirinto[12, 3] = " ";
			Labirinto[12, 4] = "X";
			Labirinto[12, 5] = " ";
			Labirinto[12, 6] = "X";
			Labirinto[12, 7] = " ";
			Labirinto[12, 8] = "X";
			Labirinto[12, 9] = " ";
			Labirinto[12, 10] = "X";
			Labirinto[12, 11] = "X";
			Labirinto[12, 12] = "X";
			Labirinto[12, 13] = "X";
			Labirinto[12, 14] = "X";
			Labirinto[12, 15] = "X";
			Labirinto[12, 16] = "X";
			Labirinto[12, 17] = "X";
			Labirinto[12, 18] = "X";
			Labirinto[12, 19] = " ";
			Labirinto[12, 20] = "X";
			Labirinto[13, 0] = "X";
			Labirinto[13, 1] = " ";
			Labirinto[13, 2] = " ";
			Labirinto[13, 3] = " ";
			Labirinto[13, 4] = "X";
			Labirinto[13, 5] = " ";
			Labirinto[13, 6] = " ";
			Labirinto[13, 7] = " ";
			Labirinto[13, 8] = "X";
			Labirinto[13, 9] = " ";
			Labirinto[13, 10] = " ";
			Labirinto[13, 11] = " ";
			Labirinto[13, 12] = " ";
			Labirinto[13, 13] = " ";
			Labirinto[13, 14] = " ";
			Labirinto[13, 15] = " ";
			Labirinto[13, 16] = " ";
			Labirinto[13, 17] = " ";
			Labirinto[13, 18] = " ";
			Labirinto[13, 19] = " ";
			Labirinto[13, 20] = "X";
			Labirinto[14, 0] = "X";
			Labirinto[14, 1] = " ";
			Labirinto[14, 2] = "X";
			Labirinto[14, 3] = "X";
			Labirinto[14, 4] = "X";
			Labirinto[14, 5] = "X";
			Labirinto[14, 6] = "X";
			Labirinto[14, 7] = "X";
			Labirinto[14, 8] = "X";
			Labirinto[14, 9] = "X";
			Labirinto[14, 10] = "X";
			Labirinto[14, 11] = "X";
			Labirinto[14, 12] = "X";
			Labirinto[14, 13] = "X";
			Labirinto[14, 14] = "X";
			Labirinto[14, 15] = "X";
			Labirinto[14, 16] = "X";
			Labirinto[14, 17] = "X";
			Labirinto[14, 18] = "X";
			Labirinto[14, 19] = "X";
			Labirinto[14, 20] = "X";
			Labirinto[15, 0] = "X";
			Labirinto[15, 1] = " ";
			Labirinto[15, 2] = " ";
			Labirinto[15, 3] = " ";
			Labirinto[15, 4] = "X";
			Labirinto[15, 5] = " ";
			Labirinto[15, 6] = " ";
			Labirinto[15, 7] = " ";
			Labirinto[15, 8] = " ";
			Labirinto[15, 9] = " ";
			Labirinto[15, 10] = " ";
			Labirinto[15, 11] = " ";
			Labirinto[15, 12] = "X";
			Labirinto[15, 13] = " ";
			Labirinto[15, 14] = " ";
			Labirinto[15, 15] = " ";
			Labirinto[15, 16] = " ";
			Labirinto[15, 17] = " ";
			Labirinto[15, 18] = " ";
			Labirinto[15, 19] = " ";
			Labirinto[15, 20] = "X";
			Labirinto[16, 0] = "X";
			Labirinto[16, 1] = "X";
			Labirinto[16, 2] = "X";
			Labirinto[16, 3] = " ";
			Labirinto[16, 4] = "X";
			Labirinto[16, 5] = "X";
			Labirinto[16, 6] = "X";
			Labirinto[16, 7] = " ";
			Labirinto[16, 8] = "X";
			Labirinto[16, 9] = "X";
			Labirinto[16, 10] = "X";
			Labirinto[16, 11] = " ";
			Labirinto[16, 12] = "X";
			Labirinto[16, 13] = " ";
			Labirinto[16, 14] = "X";
			Labirinto[16, 15] = " ";
			Labirinto[16, 16] = "X";
			Labirinto[16, 17] = "X";
			Labirinto[16, 18] = "X";
			Labirinto[16, 19] = " ";
			Labirinto[16, 20] = "X";
			Labirinto[17, 0] = "X";
			Labirinto[17, 1] = " ";
			Labirinto[17, 2] = "X";
			Labirinto[17, 3] = " ";
			Labirinto[17, 4] = " ";
			Labirinto[17, 5] = " ";
			Labirinto[17, 6] = "X";
			Labirinto[17, 7] = " ";
			Labirinto[17, 8] = " ";
			Labirinto[17, 9] = " ";
			Labirinto[17, 10] = "X";
			Labirinto[17, 11] = " ";
			Labirinto[17, 12] = "X";
			Labirinto[17, 13] = " ";
			Labirinto[17, 14] = "X";
			Labirinto[17, 15] = " ";
			Labirinto[17, 16] = " ";
			Labirinto[17, 17] = " ";
			Labirinto[17, 18] = "X";
			Labirinto[17, 19] = " ";
			Labirinto[17, 20] = "X";
			Labirinto[18, 0] = "X";
			Labirinto[18, 1] = " ";
			Labirinto[18, 2] = "X";
			Labirinto[18, 3] = "X";
			Labirinto[18, 4] = "X";
			Labirinto[18, 5] = " ";
			Labirinto[18, 6] = "X";
			Labirinto[18, 7] = "X";
			Labirinto[18, 8] = "X";
			Labirinto[18, 9] = " ";
			Labirinto[18, 10] = "X";
			Labirinto[18, 11] = " ";
			Labirinto[18, 12] = "X";
			Labirinto[18, 13] = "X";
			Labirinto[18, 14] = "X";
			Labirinto[18, 15] = "X";
			Labirinto[18, 16] = "X";
			Labirinto[18, 17] = " ";
			Labirinto[18, 18] = "X";
			Labirinto[18, 19] = " ";
			Labirinto[18, 20] = "X";
			Labirinto[19, 0] = "X";
			Labirinto[19, 1] = " ";
			Labirinto[19, 2] = " ";
			Labirinto[19, 3] = " ";
			Labirinto[19, 4] = " ";
			Labirinto[19, 5] = " ";
			Labirinto[19, 6] = " ";
			Labirinto[19, 7] = " ";
			Labirinto[19, 8] = " ";
			Labirinto[19, 9] = " ";
			Labirinto[19, 10] = "X";
			Labirinto[19, 11] = " ";
			Labirinto[19, 12] = " ";
			Labirinto[19, 13] = " ";
			Labirinto[19, 14] = " ";
			Labirinto[19, 15] = " ";
			Labirinto[19, 16] = " ";
			Labirinto[19, 17] = " ";
			Labirinto[19, 18] = "X";
			Labirinto[19, 19] = " ";
			Labirinto[19, 20] = "S";
			Labirinto[20, 0] = "X";
			Labirinto[20, 1] = "X";
			Labirinto[20, 2] = "X";
			Labirinto[20, 3] = "X";
			Labirinto[20, 4] = "X";
			Labirinto[20, 5] = "X";
			Labirinto[20, 6] = "X";
			Labirinto[20, 7] = "X";
			Labirinto[20, 8] = "X";
			Labirinto[20, 9] = "X";
			Labirinto[20, 10] = "X";
			Labirinto[20, 11] = "X";
			Labirinto[20, 12] = "X";
			Labirinto[20, 13] = "X";
			Labirinto[20, 14] = "X";
			Labirinto[20, 15] = "X";
			Labirinto[20, 16] = "X";
			Labirinto[20, 17] = "X";
			Labirinto[20, 18] = "X";
			Labirinto[20, 19] = "X";
			Labirinto[20, 20] = "X";

			return Labirinto;
		}
	}
}
