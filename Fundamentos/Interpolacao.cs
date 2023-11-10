using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Fundamentos {
    public class Interpolacao {
        public static void Executar() {
            string name = "notebook gamer";
            var marca = "dell";
            double preco = 5800.00;

            Console.WriteLine("O " + name + " da marca " + marca + " custa " + preco + ".");

            Console.WriteLine("O {0} da marca {1} custa {2}.", name, marca, preco);

            Console.WriteLine($"A marca {marca} é legal.");

        }

    }
}
