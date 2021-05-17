using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
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
        /// <summary>
        /// API에 파라미터가 필요한 경우, Dic에 key, value로 넣어서 함수 호출하셈.
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        protected string CallRestAPI(string methodType, string URL, Dictionary<string, string> param = null)
        {
            string responseFromServer = string.Empty;
            string queryString = string.Empty;

            if (!(param is null))
            {
                StringBuilder builder = new StringBuilder();
                foreach (KeyValuePair<string, string> pair in param)
                {
                    builder.Append(pair.Key).Append("=").Append(pair.Value).Append("&");
                }
                queryString = builder.ToString().TrimEnd('&');

                URL = string.Format("{0}?{1}", URL, queryString);
            }

            try
            {
                WebRequest request = WebRequest.Create(URL);
                request.Method = methodType;
                request.ContentType = "application/json";
                request.Headers.Add(string.Format("Authorization:{0}", MakeTocken(queryString)));

                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    responseFromServer = reader.ReadToEnd();
                }

            }
            catch (WebException e)
            {
                using (Stream dataStream = e.Response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    responseFromServer = reader.ReadToEnd();
                }
            }

            return responseFromServer;
        }

        private string MakeTocken(string queryString)
        {
            SHA512 sha512 = SHA512.Create();
            byte[] queryHashByteArray = sha512.ComputeHash(Encoding.UTF8.GetBytes(queryString));
            string queryHash = BitConverter.ToString(queryHashByteArray).Replace("-", "").ToLower();

            var payload = new JwtPayload
            {
                { "access_key", AccessKey },
                { "nonce", Guid.NewGuid().ToString() },
                { "query_hash", queryHash },
                { "query_hash_alg", "SHA512" }
            };

            byte[] keyBytes = Encoding.Default.GetBytes(SecretKey);
            var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(keyBytes);
            var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(securityKey, "HS256");
            var header = new JwtHeader(credentials);
            var secToken = new JwtSecurityToken(header, payload);

            var jwtToken = new JwtSecurityTokenHandler().WriteToken(secToken);
            var authorizationToken = "Bearer " + jwtToken;

            return authorizationToken;
        }
    }
}
