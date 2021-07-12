using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTrading.Util
{
    class Column
    {
        public string Name { get; set; }
        public string Caption { get; set; }
        public bool Visible { get; set; }

        public Column(string name, string caption, bool visible = true)
        {
            this.Name = name;
            this.Caption = caption;
            this.Visible = visible;
        }
    }
}
