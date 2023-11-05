using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade8
{
    /*
* PARTICIPANTES
* LUCAS HENRIQUE DE SOUZA SANTOS CB3012212
* KETHELEEN CRISTINE SIMÃO DOS SANTOS
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            var cadastro = new Cadastro();
            var seletor = new Seletor(cadastro);

            int opcao = -1;
            while (opcao != 0)
            {
                opcao = seletor.EscolherOpcao();
            }
        }
    }
}
