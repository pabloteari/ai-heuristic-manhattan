using System;
namespace TrabalhoDeIA
{
	public struct Bifurcacao
	{
		public int Linha { get; private set; }
		public int Coluna { get; private set; }

		public Bifurcacao(int linha, int coluna)
		{
			Linha = linha;
			Coluna = coluna;
		}
	}
}
