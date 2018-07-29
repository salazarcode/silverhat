using System;
using System.Collections.Generic;
using PrimerEjercicio.Other_Classes;

namespace PrimerEjercicio
{

    class Program
    {
        [STAThread]
        static void Main(string[] langs)
        {
            iSearchEngineBuilder engineBuilder = new SearchEngineBuilder();
            var data = new List<SearchResult>();

            //Cycle for getting the general query results
            foreach (var lang in langs)
            {
                //First, I find all the results for this word with all available engines
                var escalars = new List<EngineResult>();
                foreach (var engineInt in Enum.GetValues(typeof(AvailableEngines)))
                {
                    iSearchEngine engine = engineBuilder.getEngine((AvailableEngines)engineInt);
                    escalars.Add(new EngineResult
                    {
                        engine = ((AvailableEngines)engineInt).ToString(),
                        result = engine.queryString(lang)
                    });
                }


                //And finally I put together the results and the word
                data.Add(new SearchResult
                {
                    word = lang,
                    res = escalars
                });
            }



            //Results printing
            foreach (var item in data)
            {
                Console.Write(item.word + ": ");
                foreach (var elem in item.res)
                    Console.Write(elem.engine +": " + elem.result + " ");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
