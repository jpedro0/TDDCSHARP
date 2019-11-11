using Alura.LeilaoOnline.Core;
using System;

namespace Alura.LeilaoOnline.ConsoleApp
{
    class Program
    {
        private static void LeilaoComVariosLances()
        {
            //Arranje
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);


            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);

            //Action
            leilao.TerminaPregao();

            //Assert
            Verifica(1000, leilao.Ganhador.Valor);
        }
        private static void LeilaoComApenasUmLance()
        {
            //Arranje
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);


            leilao.RecebeLance(fulano, 800);

            //Action
            leilao.TerminaPregao();

            //Assert
            Verifica(800, leilao.Ganhador.Valor);

        }
        private static void Verifica(double esperado, double obtido)
        {
            var cor = Console.ForegroundColor;
            if (obtido.Equals(esperado))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TESTE OK");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"TESTE FALHOU Esperado:{esperado}, Obtido: {obtido}");
            }
            Console.ForegroundColor = cor;
        }
        static void Main()
        {
            LeilaoComVariosLances();
            LeilaoComApenasUmLance();
        }
    }
}
