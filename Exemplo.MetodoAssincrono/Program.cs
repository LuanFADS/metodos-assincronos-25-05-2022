using System;
using System.Threading;
using System.Threading.Tasks;

namespace Exemplo.MetodoAssincrono
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EscreverNomeAsync();
            EscreverNomeAguardandoAsync().GetAwaiter().GetResult();
            Console.WriteLine(ObterNomeAsync().GetAwaiter().GetResult());

            Console.ReadLine();
        }

        private static async void EscreverNomeAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                Console.WriteLine("Luan");
            });
        }

        private static async Task EscreverNomeAguardandoAsync()
        {
            await Task.Run(() => { 
                Thread.Sleep(TimeSpan.FromSeconds(3));
                Console.WriteLine("Luan");
            });
        }

        private static async Task<string> ObterNomeAsync()
        {
            var result = string.Empty;

            await Task.Run(() => 
            {
                Thread.Sleep(TimeSpan.FromSeconds(3));
                result = "Luan";
            });

            return result;
        }

    }
}
