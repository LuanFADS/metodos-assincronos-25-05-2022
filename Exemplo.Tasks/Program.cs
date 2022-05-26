using System;
using System.Threading.Tasks;

namespace Exemplo.Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task = new Task<string>(() => 
            { 
                try
                {
                    return "Luan";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            });
            
            var result = task.GetAwaiter().GetResult();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
