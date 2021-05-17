using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AutoTrading.API
{
    class RestApiBase
    {
        protected string AccessKey;
        protected string SecretKey;

        protected RestApiBase(string accessKey, string secretKey)
        {
            AccessKey = accessKey;
            SecretKey = secretKey;
        }

        protected string CallRestAPI(string methodType, string URL, string tocken)
        {
            string responseFromServer = string.Empty;

            try
            {

                WebRequest request = WebRequest.Create(URL);
                request.Method = methodType;
                request.ContentType = "application/json";
                request.Headers.Add(string.Format("Authorization:{0}", tocken));

                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    responseFromServer = reader.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return responseFromServer;
        }
    }
}
