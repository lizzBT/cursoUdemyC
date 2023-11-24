using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Fundamentos {
    public class OperadoresAtribuicao {
        public static void Executar() {
            var num1 = 3;
            num1 = 7;
            num1 += 10;
            num1 -= 3;
            num1 *= 5;
            num1 /= 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++;
            b--;

            Console.WriteLine($"{a} {b}");

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "Lizz";

            dynamic d = c;

            d.nome = "Lucas";

            Console.WriteLine(c.nome);

        }
    }
}
