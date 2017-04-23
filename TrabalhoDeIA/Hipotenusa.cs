using System;
namespace TrabalhoDeIA
{
	public class Hipotenusa
	{
		public int A {get; set;}
		public int B { get; set; }
		public double hipotenusa { get; set; }

		public void getHipotenusa(int a, int b)
		{            
			hipotenusa = Math.Sqrt(a * a + b * b);
		}
	}
}
