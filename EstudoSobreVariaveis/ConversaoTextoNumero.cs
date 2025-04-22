using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meu_projeto.EstudoSobreVariaveis
{
    internal class ConversaoTextoNumero
    {
        static void Main(string[] args)
        {
            string NumeroTexto = "30";
            int Numero1 = int.Parse(NumeroTexto); //Convertendo Texto para Numerico
            int Numero = 30;

            Console.Write("O Resulta da Soma é: " + (Numero1 + Numero));
            Console.ReadKey();
        }
    }
}
