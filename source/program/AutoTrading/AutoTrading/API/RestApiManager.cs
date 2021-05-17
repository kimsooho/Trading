using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTrading.API
{
    class RestApiManager
    {
        protected static RestApiManager Instance = null;

        private Accounts Accounts;
        /// <summary>
        /// Singleton
        /// </summary>          
        public static RestApiManager GetInstance()
        {
            if(Instance is null)
            {
                Instance = new RestApiManager();
            }

            return Instance;
        }

        public void SetKeys(string accessKey, string secretKey)
        {
            Accounts = new Accounts(accessKey, secretKey);
        }

        public Accounts GetAccounts() { return Accounts; }
    }
}
