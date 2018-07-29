using System;
using WatiN.Core;

namespace PrimerEjercicio
{
    sealed class GoogleEngine: iSearchEngine
    {
        static readonly GoogleEngine _instance = new GoogleEngine();

        public static GoogleEngine Instance
        {
            get
            {
                return _instance;
            }
        }

        public int queryString(String query)
        {
            //Searching for better implementation
            return 48;
        }
    }
}
