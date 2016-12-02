using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DAPACS.Util;
using DAPACS.DAL;

namespace DAPACS.BLL
{
    /// <summary>
    /// 引入了System.Drawing，来实现查看图片参数的方法
    /// </summary>
    class ImageInfoImpl:IImageInfo
    {
        //获取图片宽度
        public int GetWidth(string pathname)
        {
            Image img = Image.FromFile(pathname);
            return img.Width;
        }
        //获取图片高度
        public int GetHeight(string pathname)
        {
            Image img = Image.FromFile(pathname);
            return img.Height;
        }
        //获取图片横向分辨率
        public float GetDpiX(string pathname)
        {
            Image img = Image.FromFile(pathname);
            return img.HorizontalResolution;
        }
        //获取图片纵向分辨率
        public float GetDpiY(string pathname)
        {
            Image img = Image.FromFile(pathname);
            return img.VerticalResolution;
        }
        //获取图片色彩模式
        public string GetColorMode(string pathname)
        {
            Image img = Image.FromFile(pathname);
            return img.PixelFormat.ToString();
        }
    }
}
