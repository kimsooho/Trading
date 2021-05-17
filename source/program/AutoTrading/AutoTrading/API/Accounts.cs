using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTrading.API
{
    class Accounts : RestApiBase
    {
        public Accounts(string accessKey, string secretKey) : base(accessKey, secretKey) { }
        public string GetAllAccounts()
        {
            var payload = new JwtPayload
        {
            { "access_key", AccessKey },
            { "nonce", Guid.NewGuid().ToString() },
            //{ "query_hash", queryHash },
            { "query_hash_alg", "SHA512" }
        };

            byte[] keyBytes = Encoding.Default.GetBytes(SecretKey);
            var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(keyBytes);
            var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(securityKey, "HS256");
            var header = new JwtHeader(credentials);
            var secToken = new JwtSecurityToken(header, payload);

            var jwtToken = new JwtSecurityTokenHandler().WriteToken(secToken);
            var authorizationToken = "Bearer " + jwtToken;
            return CallRestAPI("GET", "https://api.upbit.com/v1/status/wallet", authorizationToken);
        }
    }
}
