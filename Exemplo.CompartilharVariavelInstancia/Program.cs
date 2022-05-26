using System;
using System.Threading;

namespace Exemplo.CompartilharVariavelInstancia
{
    internal class Program
    {
        private bool _isImprimir = true;

        static void Main(string[] args)
        {
            var program = new Program();

            var threadUm = new Thread(program.EscreverNome);
            var threadDois = new Thread(program.EscreverNome);

            var threadTres = new Thread(new Program().EscreverNome);
            var threadQuatro = new Thread(new Program().EscreverNome);

            threadUm.Start();
            threadDois.Start();

            threadTres.Start();
            threadQuatro.Start();

            Console.ReadLine();
        }

        private void EscreverNome()
        {
            if (!_isImprimir)
                return;

            _isImprimir = false;
            Console.WriteLine("Luan");
        }
    }
}
