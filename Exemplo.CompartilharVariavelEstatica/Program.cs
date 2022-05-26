using System;
using System.Threading;

namespace Exemplo.CompartilharVariavelEstatica
{
    internal class Program
    {
        private static bool _isImprimir = true;
        
        static void Main(string[] args)
        {
            var threadUm = new Thread(ImprimirNome);
            var threadDois = new Thread(ImprimirNome);

            threadUm.Start();

            threadDois.Start();
        }

        private static void ImprimirNome()
        {   
            if (!_isImprimir)
                return;

            _isImprimir = false;
            Console.WriteLine("Id atual da thread: " + $"{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Luan\n");
        }
    }
}
