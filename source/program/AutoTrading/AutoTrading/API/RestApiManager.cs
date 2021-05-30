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
        private Order Order;
        private Withdraw Withdraw;
        private Deposit Deposit;
        private Status Status;
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
            Order = new Order(accessKey, secretKey);
            Withdraw = new Withdraw(accessKey, secretKey);
            Deposit = new Deposit(accessKey, secretKey);
            Status = new Status(accessKey, secretKey);
        }

        public Accounts GetAccounts() { return Accounts; }
        public Order GetOrder() { return Order; }
        public Withdraw GetWithdraw() { return Withdraw; }
        public Deposit GetDeposit() { return Deposit; }
        public Status GetStatus() { return Status; }
    }
}
