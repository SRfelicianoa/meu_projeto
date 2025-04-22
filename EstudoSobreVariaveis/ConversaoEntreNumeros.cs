using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meu_projeto.EstudoSobreVariaveis
{
    internal class ConversaoEntreNumeros
    {
        static void Main(string[] args)
        {
            short meuShort = 10;
            int meuInt = meuShort;
            long meuLong = meuInt;


            long mesLong = 10;
            int meuInt2 = System.Convert.ToInt32(mesLong);
            short meuShort2 = System.Convert.ToInt16(mesLong);

        }
    }
}
