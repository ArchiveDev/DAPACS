using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAPACS.Util;

namespace DAPACS.BLL
{
    class ExcelManagerImpl : IExcelManager
    {
        //显示实现
        void IExcelManager.test()
        {
            LogUtil.writeConsole(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
