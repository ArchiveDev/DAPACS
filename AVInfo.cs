using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaInfoNET;

namespace DAPACS.BLL
{
    interface AVInfo
    {
        //获取音视频文件名
        string GetAVFileName(string pathname);
        //获取音视频文件格式
        string GetAVFileFormat(string pathname);
        //获取音视频文件时长
        string GetAVFileDuration(string pathname);
        //获取音视频文件大小
        string GetAVFileSize(string pathname);
        //获取音频比特率
        string GetAudioBitrate(string pathname);
        //获取音频采样率
        string GetAudioSimplingRate(string pathname);
        //获取视频码率
        string GetVideoBitrate(string pathname);
    }
}
