using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAPACS.BLL
{
    #region
    /**
     * 业务逻辑层接口
     * 这里主要处理业务逻辑，比如对Excel的处理，需要调用DAL层获取
     * Excel对象，然后在该层做一些操作（输出Excel的行数，列数等等）
     * 
     */
    #endregion
    interface IExcelManager
    {
        //默认公有方法
        void test();

        int getSheetCount();
    }
}
