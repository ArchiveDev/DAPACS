using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaInfoNET;

namespace DAPACS.BLL
{
    class AVInfoImpl:AVInfo
    {
        #region 获取音视频文件名
        public string GetAVFileName(string pathname)
        {
            MediaFile avFile = new MediaFile(pathname);
            return avFile.Name;
        }
        #endregion

        #region 获取音视频文件格式
        public string GetAVFileFormat(string pathname)
        {
           MediaFile avFile = new MediaFile(pathname);
             return avFile.General.Format;
        }
        #endregion

        #region 获取音视频时长
        public string GetAVFileDuration(string pathname)
        {
              MediaFile avFile = new MediaFile(pathname);
             return avFile.General.DurationString;
        }
        #endregion

        #region 获取音视频文件大小
      
        public string GetAVFileSize(string pathname)
        {
            MediaFile avFile = new MediaFile(pathname);
            long i = avFile.FileSize;
            string j = Convert.ToString(i);
            return j;
        }
        #endregion

        #region 获取音频比特率
        public string GetAudioBitrate(string pathname)
        {
            MediaFile avFile = new MediaFile(pathname);
            int i = avFile.Audio[0].Bitrate;
            string j = Convert.ToString(i);
            return j;
        }
        #endregion

        #region 获取音频采样率
        public string GetAudioSimplingRate(string pathname)
        {
            MediaFile avFile = new MediaFile(pathname);
            int i = avFile.Audio[0].SamplingRate;
            string j = Convert.ToString(i);
            return j;
        }
        #endregion

        #region 获取视频码率
        public string GetVideoBitrate(string pathname)
        {
            MediaFile avFile = new MediaFile(pathname);
            int i = avFile.Video[0].Bitrate;
            string j = Convert.ToString(i);
            return j;
        }
        #endregion

    }
}
