using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAPACS.BLL
{
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
        //获取图片格式
        string GetImageFormat(string pathname);
    }
}
