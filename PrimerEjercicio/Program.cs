using System;

namespace PrimerEjercicio
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            iSearchEngine engine = new GoogleEngine();
            int result = engine.queryString(".NET");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
