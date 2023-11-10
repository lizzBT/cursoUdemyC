using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoUdemy.Fundamentos {
    public class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C")); //moeda real
            Console.WriteLine(valor.ToString("P")); //porcentagem
            Console.WriteLine(valor.ToString("#.##"));

            //configurar a lingua de padronização,
            //nesse caso valores numéricos
            CultureInfo cultura = new CultureInfo("en-us"); 
            Console.WriteLine(valor.ToString("C0" , cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // colocar zeros a esquerda
        }
    }
}
