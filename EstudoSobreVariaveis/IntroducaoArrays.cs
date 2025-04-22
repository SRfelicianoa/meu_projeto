using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meu_projeto.EstudoSobreVariaveis
{
    internal class IntroducaoArrays
    {
        static void Main(string[] args)
        {
            string[] nomes = {"Rafael","Tamires","Matheus"};
            Console.WriteLine("Nome do N2: " + nomes[1]);
            nomes[2] = "Tamires Feliciano"; //Alterando o nome dentro do Array
            Console.WriteLine("Nome do N2 Alterado: " + nomes[2]);

        }
    }
}
