using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEjercicio
{
    interface iSearchEngineBuilder
    {
        String[] getAvailableEngines();
        iSearchEngine getEngine(String name);
    }
}
