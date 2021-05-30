using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTrading.API
{
    class Order : RestApiBase
    {
        public Order(string accessKey, string secretKey) : base(accessKey, secretKey) { }

        public string GetOrderInfo(string marketID)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("market", "KRW-BTC");

            return CallRestAPI("GET", "https://api.upbit.com/v1/orders/chance", param);
        }

        public string GetOrdersList(List<string> param)
        {
            //Dictionary<string, string> param = new Dictionary<string, string>();
            //param.Add("market", "KRW-BTC");

            return CallRestAPI("GET", "https://api.upbit.com/v1/orders", param);
        }
    }
}
