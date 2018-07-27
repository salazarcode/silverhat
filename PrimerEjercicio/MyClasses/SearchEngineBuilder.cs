using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEjercicio
{
    class SearchEngineBuilder : iSearchEngineBuilder
    {
        private String[] availableEngines = new String[] {
            "GOOGLE",
            "YAHOO"
        };

        public string[] getAvailableEngines()
        {
            return this.availableEngines;
        }

        public iSearchEngine getEngine(string name)
        {
            iSearchEngine engine;
            switch (name)
            {
                case "GOOGLE":
                    engine = GoogleEngine.Instance;
                    return engine;
                case "YAHOO":
                    engine = YahooEngine.Instance;
                    return engine;
                default:
                    return null;
            }
        }
    }
}
