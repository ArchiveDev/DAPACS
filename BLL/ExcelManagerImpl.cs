using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAPACS.Util;
using DAPACS.DAL;

namespace DAPACS.BLL
{

    /**
     * 业务逻辑层实现类
     * 这里主要处理业务逻辑，比如对Excel的处理，需要调用DAL层获取
     * Excel对象，然后在该层做一些操作（输出Excel的行数，列数等等）
     * 
     */
    class ExcelManagerImpl : IExcelManager
    {
        private DBAcess db = new DBAcess();

        //显示实现
        /* void IExcelManager.test()
        {
            LogUtil.writeConsole(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }*/

        //隐式实现
        public void test()
        {
            LogUtil.writeConsole(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        public bool checkSheetCount()
        {
            return db.getExcel().Columns.Count == 1 ? true : false;
        }
    }
}
