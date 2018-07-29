using System;
using WatiN.Core;

namespace PrimerEjercicio
{
    sealed class YahooEngine : iSearchEngine
    {
        static readonly YahooEngine _instance = new YahooEngine();

        public static YahooEngine Instance
        {
            get
            {
                return _instance;
            }
        }
        public int queryString(string query)
        {
            WatiN.Core.Settings.Instance.MakeNewIeInstanceVisible = false;

            String[] substrings, numberSubStrings;
            String number, finalStringResult;
            int parsedResult;

            try
            {
                IE ie = new IE("https://ve.search.yahoo.com/search?p=" + query);
                String res = (ie.Span(Find.BySelector("div.compPagination span"))).InnerHtml;
                ie = null;
                substrings = res.Split(' ');
                number = substrings[0];
                numberSubStrings = number.Split(',');
                finalStringResult = String.Join("", numberSubStrings);
                parsedResult = Convert.ToInt32(finalStringResult);
            }
            catch (Exception)
            {
                throw;
            }
            return parsedResult;
        }
    }
}
