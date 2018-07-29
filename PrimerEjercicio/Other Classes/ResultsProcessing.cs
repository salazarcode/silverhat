using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEjercicio.MyClasses
{
    class ResultsProcessing
    {
        static ResumeWord getSearchEngineWinner(String engine, List<SearchResult> data)
        {
            List<ResumeWord> resume = new List<ResumeWord>();
            foreach (SearchResult item in data)
            {
                EngineResult target = item.res.Find(x => x.engine == engine);
                resume.Add(new ResumeWord {
                    word = item.word,
                    res = target.result
                });
            }
            ResumeWord currentUpper = resume[0];
            foreach (ResumeWord item in resume)
            {
                if (item.res > currentUpper.res)
                {
                    currentUpper.word = item.word;
                    currentUpper.res = item.res;
                }
            }
            return currentUpper;
        }
    }
}
