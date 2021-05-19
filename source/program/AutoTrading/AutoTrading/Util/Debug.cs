using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTrading.Util
{
    class Debug
    {
        protected static Debug Instance = null;
        public static Debug GetInstance()
        {
            if (Instance is null)
            {
                Instance = new Debug();
            }

            return Instance;
        }

        public void Log(String Message)
        {
            StackFrame CallStack = new StackFrame(1, true);

            // 더블 클릭 시 로그 찍은
            Console.WriteLine("{0}({1},{2}):[{3}] : {4}", CallStack.GetFileName(), CallStack.GetFileLineNumber(), CallStack.GetFileColumnNumber(), DateTime.Now.ToString("HH:mm:ss.ff"), Message);
            // Console.WriteLine("[" + DateTime.Now.ToString("HH:mm:ss.ff") + "Message : " + Message + CallStack.GetFileName() + "(" + CallStack.GetFileLineNumber() + "," +CallStack.GetFileColumnNumber() + ")" );
        }
    }
}
