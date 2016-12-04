using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAPACS.Util;
using DAPACS.DAL;
using System.Drawing;

namespace DAPACS.BLL
{
    class ImageInfoImpl:IImageInfo
    {
        /// <summary>
    /// 使用时传入参数为图片地址，不同函数返回不同的参数值
    /// 转成字符串可显示在前端界面
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
        //获取图片格式
         public string GetImageFormat(string pathname)
        {
            Image img = Image.FromFile(pathname);
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
            {
                return "JPEG";
            }
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp))
            {
                return "BMP";
            }
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
            {
                return "PNG";
            }
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Tiff))
            {
                return "TIFF";
            }
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
            {
                return "GIFF";
            }
            return "未知格式";
        }
    }
