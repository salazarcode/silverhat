using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerEjercicio.Other_Classes;

namespace PrimerEjercicio
{
    class SearchEngineBuilder : iSearchEngineBuilder
    {
        public iSearchEngine getEngine(AvailableEngines ae)
        {
            iSearchEngine engine;
            switch (ae)
            {
                case AvailableEngines.GOOGLE:
                    engine = GoogleEngine.Instance;
                    return engine;
                case AvailableEngines.YAHOO:
                    engine = YahooEngine.Instance;
                    return engine;
                default:
                    return null;
            }
        }
    }
}
