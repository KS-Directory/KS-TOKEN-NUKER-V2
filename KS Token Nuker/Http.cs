using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KS_Token_Nuker
{
    class Http
    {
        public static byte[] Post(string uri, NameValueCollection pairs)
        {
            using (WebClient webclient = new WebClient())
                return webclient.UploadValues(uri, pairs);
        }
    }
}
