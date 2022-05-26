using Microsoft.AspNetCore.Components;
using System;
using System.Threading;

namespace Exemplo.Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region thread principal
            Console.WriteLine("Chamada Síncrona: ");
            EscreverData();
            Console.WriteLine($"Código Thread Primária: " + $"{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Chamada por Thread: ");
            #endregion fim thread principal

            #region thread secundaria
            Thread threadUm = new Thread(EscreverData);
            threadUm.Start();
            Console.WriteLine($"Código Thread Secundária: " + $"{threadUm.ManagedThreadId}");
            Console.ReadLine();
            #endregion fim thread secundaria

            #region thread terciaria
            Thread threadDois = new Thread(EscreverNome);
            threadDois.Start();
            Console.WriteLine($"Código Thread Terciária: " + $"{threadDois.ManagedThreadId}");
            Console.ReadLine();
            #endregion fim thread terciaria
        }

        private static void EscreverData()
        {
            Console.WriteLine($"Data Hora: {DateTime.Now}");
        }

        private static void EscreverNome()
        {
            var nome = Console.ReadLine();
            Console.WriteLine($"Nome: {nome}");
        }
    }
}
