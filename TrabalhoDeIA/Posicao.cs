using System;
namespace TrabalhoDeIA
{
	public class Posicao
	{
        public int Linha { get; set; }
        public int Coluna { get; set; }
		public double DistanciaHipotenusa { get; set; }

		public Posicao(int linha, int coluna)
		{
			Linha = linha;
			Coluna = coluna;
            DistanciaHipotenusa = Math.Sqrt((20 -linha) * (20 - linha) + ( 20 - coluna) * ( 20 - coluna));
		}

        public Posicao()
        {
           
        }
	}
}
