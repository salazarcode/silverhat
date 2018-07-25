using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using WatiN.Core;
using SHDocVw;

namespace PrimerEjercicio
{
    class GoogleEngine: iSearchEngine
    {
        public int queryString(String query)
        {
            try
            {
                Settings.Instance.MakeNewIeInstanceVisible = false;
                IE ie = new IE("https://www.google.com/search?source=hp&ei=3xBYW-TfMpH2swWT_oBA&q=.NET&oq=.NET&gs_l=psy-ab.3..0l10.4935.5547.0.5820.4.4.0.0.0.0.175.513.0j3.3.0....0...1c.1.64.psy-ab..1.3.511...0i131k1.0.cE7LSR_WHQc");
                ie.TextField(Find.ByName("q")).Value = query;
                ie.NativeDocument.Body.SetFocus();
                ie.Button(Find.ById("mKlEF")).Click();
                String result = ie.Div(Find.ById("resultStats")).Text;
                Char delimiter1 = ' ';
                Char delimiter2 = ',';

                String[] substrings = result.Split(delimiter1);
                result = substrings[2];
                substrings = null;

                substrings = result.Split(delimiter2);
                result = "";
                foreach(String elem in substrings)
                    result += elem;

                return Int32.Parse(result);              
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
