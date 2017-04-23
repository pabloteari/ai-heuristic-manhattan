using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrabalhoDeIA
{
    class Program
    {
        static void Main(string[] args)
        {
		    var labirinto = Labirinto.getLabirinto();
			Posicao posicaoAtual = new Posicao(1, 1);
			
            Stack<String[,]> pilhaLabirinto = new Stack<String[,]>();
            Stack<Posicao> pilha = new Stack<Posicao>();

            do{
				var caminhos = Labirinto.CaminhosLivres(labirinto, posicaoAtual);

                if (caminhos.Count > 0)
                {
                    var min = caminhos.Min(a => a.DistanciaHipotenusa);
                    var caminhoEscolhido = caminhos.Where(a => a.DistanciaHipotenusa == min).FirstOrDefault();

                    if (caminhos.Count >= 2)
                        pilhaLabirinto.Push(labirinto);

                    caminhos.Remove(caminhoEscolhido);

                    foreach (var caminho in caminhos)
                        pilha.Push(caminho);
					Console.Clear();
                    Labirinto.Andar(labirinto, posicaoAtual, caminhoEscolhido);
                }
                else
                {
                    labirinto = pilhaLabirinto.Pop();
                    var caminhoEscolhido = pilha.Pop();
					Console.Clear();
                    Labirinto.Andar(labirinto, posicaoAtual, caminhoEscolhido);
                }
				Thread.Sleep(100);
               
			}while (labirinto[19, 19] != "C");
        }        
    }
}
