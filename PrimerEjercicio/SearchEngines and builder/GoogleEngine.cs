using System;
using PrimerEjercicio.Other_Classes;

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
            RestClient rClient = new RestClient();

            String key = "AIzaSyC3jtrl5twZMtc1EfCDsn2tRJxyo1MHzKk";
            String cx = "013958267844494911172:rxbzcq0xyzq";

            rClient.endPoint = "https://www.googleapis.com/customsearch/v1?key="+ key +"&cx="+ cx +"&q="+ query;

            string strJSON = string.Empty;

            strJSON = rClient.makeRequest();

            Console.Write(strJSON);

            return 48;
        }
    }
}
