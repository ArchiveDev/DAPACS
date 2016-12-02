using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAPACS.BLL
{
    /// <summary>
    /// 传入图片路径字符串，调用不同方法输出参数
    /// </summary>
    interface IImageInfo
    {
        //获取像素尺寸
        int GetWidth(string pathname);
        int GetHeight(string pathname);
        //获取分辨率
        float GetDpiX(string pathname);
        float GetDpiY(string pathname);
        //获取色彩模式
        string GetColorMode(string pathname);
    }
}
