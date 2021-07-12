using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTrading.Events
{
    public class NodeMouseClickEventArgs : EventArgs
    {
        public string Key { get; private set; }
        public string Title { get; private set; }

        public NodeMouseClickEventArgs(string key, string title)
        {
            this.Key = key;
            this.Title = title;
        }
    }
}
