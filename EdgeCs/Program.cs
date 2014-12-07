

using System;
using System.Threading.Tasks;
using EdgeJs;

namespace EgdeCs
{
    class Program
    {
        static void Main(string[] args)
        {
           Edgy.Start(Console.WriteLine).Wait();
            Console.WriteLine("Any Key To Exit");
            Console.ReadKey();
        }
    }

    public class Edgy
    {       
        public static async Task Start(Action<object> callback)
        {
           // var script = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +"\\..\\..\\"+"script.cs");

            var func = Edge.Func(@"return require('../../../script')");
         
            dynamic result = await func(null);
            
            callback(result.Data);
        }
    }
}
