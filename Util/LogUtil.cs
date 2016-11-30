using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAPACS.Util
{
    #region
    /**
     * 日志工具类
     * 主要提供记录日志的公共方法，如输出到控制台，输出到文件日志等。
     * 
     */
    #endregion
    class LogUtil
    {
        public static void writeConsole(String msg)
        {
            Console.WriteLine(msg);
        }
    }
}
