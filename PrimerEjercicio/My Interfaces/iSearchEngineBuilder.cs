using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerEjercicio.Other_Classes;

namespace PrimerEjercicio
{
    interface iSearchEngineBuilder
    {
        iSearchEngine getEngine(AvailableEngines ae);
    }
}
