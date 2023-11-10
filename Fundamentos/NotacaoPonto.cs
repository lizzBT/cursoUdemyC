using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Fundamentos {
    public class NotacaoPonto {
        public static void Executar() {
            var saudacao = "Olá".ToUpper().Insert(3, " World").Replace(" World", " Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length + " Caracteres");

            string valorImportante = null; //null - vazio
            Console.WriteLine(valorImportante?.Length);

        }
    }
}
