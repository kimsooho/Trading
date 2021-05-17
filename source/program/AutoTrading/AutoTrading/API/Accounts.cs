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
            return CallRestAPI("GET", "https://api.upbit.com/v1/market/all?isDetails=false", MakeTocken());
        }
    }
}
