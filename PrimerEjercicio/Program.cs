using System;

namespace PrimerEjercicio
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            String query = ".NET";

            iSearchEngineBuilder engineBuilder = new SearchEngineBuilder();
            String[] availableEngines = engineBuilder.getAvailableEngines();

            foreach (String item in availableEngines)
            {
                iSearchEngine engine = engineBuilder.getEngine(item);
                int result = engine.queryString(query);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
