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
            //Searching for better implementation
            return 65;
        }
    }
}
