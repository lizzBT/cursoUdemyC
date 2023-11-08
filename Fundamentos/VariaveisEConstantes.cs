using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Fundamentos {
    public class VariaveisEConstantes {
        public static void Executar() {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area + 1000);


            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45; // sem sinal
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // com sinal
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; //Mais usado dos inteiros
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; // sem sinal
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000; // sem sinal
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do Computador " + precoComputador);

            double valorDeMercadoDaApple = 100000000000000.00;
            Console.WriteLine("Valor de mercado da Apple " + valorDeMercadoDaApple); // mais usado dos reais!

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Isso é um texto";
            Console.WriteLine(texto);




        }

    }
}
