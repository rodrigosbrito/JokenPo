using System;

namespace JokenPo
{
    class Program
    {
        static int vitorias_jogador1 = 0;
        static int vitorias_jogador2 = 0;
        const char pedra = 'p';
        const char papel = 'f';
        const char tesoura = 't';

        static void Main(string[] args)
        {
            Console.WriteLine("Jokeeeeeen Po?");
            int rodadas_max = 3;
            int rodadas = 0;

            do
            {
                rodadas++;

                Console.WriteLine("#### Inicio Rodada " + rodadas + " ####");
                Console.WriteLine("Jogador 1 ('p' - pedra | 'f' - papel | 't' - tesoura):");
                ConsoleKeyInfo info = Console.ReadKey();
                Console.WriteLine();

                var jogador1 = info.KeyChar;
                Jogar(jogador1);

                Console.WriteLine("Jogador 2 ('p' - pedra | 'f' - papel | 't' - tesoura):");
                info = Console.ReadKey();
                Console.WriteLine();

                var jogador2 = info.KeyChar;
                Jogar(jogador2);

                var ganhador = Ganhador(jogador1, jogador2);

                Console.WriteLine("Vencedor da rodada " + rodadas + ": " + ganhador);
                Console.WriteLine("#### Fim da Rodada " + rodadas + " ####");

                if (vitorias_jogador1 > 1)
                {
                    Console.WriteLine("#### Fim de jogo! Jogador 1 VENCEU! ####");
                    Console.ReadKey();
                    break;
                }

                if (vitorias_jogador2 > 1)
                {
                    Console.WriteLine("#### Fim de jogo! Jogador 2 VENCEU! ####");
                    Console.ReadKey();
                    break;
                }

                if (rodadas == rodadas_max && (vitorias_jogador1 < 2 && vitorias_jogador2 < 2))
                {
                    Console.WriteLine("#### Fim de jogo! Ninguém venceu! ####");
                    Console.ReadKey();
                }

            }
            while (rodadas < rodadas_max);
        }

        public static char Jogar(char jogada)
        {
            switch (jogada)
            {
                case pedra:
                    Console.WriteLine("Pedra!");
                    break;
                case papel:
                    Console.WriteLine("Papel!");
                    break;
                case tesoura:
                    Console.WriteLine("Tesoura!");
                    break;
                default:
                    Console.WriteLine("Jogada inválida! Tente novamente!");
                    Console.Read();
                    break;
            }

            return jogada;
        }

        public static string Ganhador(char jogador1, char jogador2)
        {
            if (jogador1 == pedra && jogador2 == papel)//pedra perde para papel
            {
                vitorias_jogador2++;
                return "Jogador 2 - selecionou Papel!";
            }
            if (jogador1 == pedra && jogador2 == tesoura)//pedra ganha de tesoura
            {
                vitorias_jogador1++;
                return "Jogador 1 - selecionou Pedra!";
            }
            if (jogador1 == pedra && jogador2 == pedra)//pedra empata com pedra
            {
                return "Empate!";
            }
            
            if (jogador1 == papel && jogador2 == pedra)//papel ganha de pedra
            {
                vitorias_jogador1++;
                return "Jogador 1 - selecionou Papel!";
            }
            if (jogador1 == papel && jogador2 == tesoura)//papel perde para tesoura
            {
                vitorias_jogador2++;
                return "Jogador 2  - selecionou Tesoura!";
            }
            if (jogador1 == papel && jogador2 == papel)//papel empata com papel
            {
                return "Empate!";
            }
            
            if (jogador1 == tesoura && jogador2 == pedra)//tesoura perde para pedra
            {
                vitorias_jogador2++;
                return "Jogador 2 - selecionou Pedra!";
            }
            if (jogador1 == tesoura && jogador2 == papel)//tesoura ganha de papel
            {
                vitorias_jogador1++;
                return "Jogador 1 - selecionou Tesoura!";
            }
            if (jogador1 == tesoura && jogador2 == tesoura)//tesoura empata com tesoura
            {
                return "Empate!";
            }

            return "Empate";
        }

    }
}
