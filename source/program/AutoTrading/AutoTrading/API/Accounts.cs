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
            return CallRestAPI("GET", "https://api.upbit.com/v1/market/all?isDetails=false");
        }

        public string Test()
        {
            /*
             * 파라미터가 있을 경우 테스트 코드
             */

            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("market", "KRW-BTC");

            return CallRestAPI("GET", "https://api.upbit.com/v1/orders/chance", param);
        }
    }
}
