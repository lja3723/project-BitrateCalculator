using Bitrate_Calculator.src.manager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bitrate_Calculator.src
{
    /// <summary>
    ///     정보 표시 컨트롤(텍스트박스 또는 콤보박스)의 값을 읽는 기능을 수행한다.
    /// </summary>
    public class InfoControlReader
    {
        private readonly InfoControlReference refer;


        public uint? Hour
        {
            get 
            {
                if (refer.originVidInfo_시간.Text.Length == 0) return null;
                return Convert.ToUInt32(refer.originVidInfo_시간.Text); 
            }
        }
        public uint? Min
        {
            get
            {
                if (refer.originVidInfo_분.Text.Length == 0) return null;
                return Convert.ToUInt32(refer.originVidInfo_분.Text); 
            }
        }
        public uint? Sec
        {
            get
            {
                if (refer.originVidInfo_초.Text.Length == 0) return null;
                return Convert.ToUInt32(refer.originVidInfo_초.Text); 
            }
        }
        public uint? Width
        {
            get
            {
                if (refer.originVidInfo_화면해상도_가로.Text.Length == 0) return null;
                return Convert.ToUInt32(refer.originVidInfo_화면해상도_가로.Text);
            }
        }
        public uint? Height
        {
            get
            {
                if (refer.originVidInfo_화면해상도_세로.Text.Length == 0) return null;
                return Convert.ToUInt32(refer.originVidInfo_화면해상도_세로.Text); 
            }
        }
        public uint? Fps
        {
            get
            {
                if (refer.originVidInfo_초당프레임.Text.Length == 0) return null;
                return Convert.ToUInt32(refer.originVidInfo_초당프레임.Text); 
            }
        }
        public uint? AudioBitrate
        {
            get
            {
                if (refer.originVidInfo_오디오비트레이트.Text.Length == 0) return null;
                return Convert.ToUInt32(refer.originVidInfo_오디오비트레이트.Text); 
            }
        }
        public Codecs Codec
        {
            get { return CodecsHelper.ToCodecs(refer.originVidInfo_적용코덱.Text); }
        }


        public PersecUnit MaxBitrateUnit
        {
            get { return PersecUnitHelper.ToPersecUnit(refer.bitrate_최대영상비트레이트.Text); }
        }
        public FilesizeUnit ExpectedOutputVidSizeUnit
        {
            get { return FilesizeUnitHelper.ToFilesizeUnit(refer.bitrate_예상출력영상크기.Text); }
        }


        public FilesizeUnit DesiredOutputVidSizeUnit
        {
            get { return FilesizeUnitHelper.ToFilesizeUnit(refer.outSizeBasedBitrate_원하는출력영상크기_단위.Text); }
        }
        public uint? DesiredOutputVidSize
        {
            get 
            {
                if (refer.outSizeBasedBitrate_원하는출력영상크기.Text.Length == 0) return null;
                return Convert.ToUInt32(refer.outSizeBasedBitrate_원하는출력영상크기.Text); 
            }
        }
        public PersecUnit DesiredOutputBitrateUnit
        {
            get { return PersecUnitHelper.ToPersecUnit(refer.outSizeBasedBitrate_예상영상비트레이트.Text); }
        }
        
        
        public ConvertResolutionBase ConvertResolutionBase
        {
            get { return ConvertResolutionBaseHelper.ToConvertResolutionBase(refer.convertResolution_변환기준_단위.Text); }
        }
        public uint? ConvertResolutionSize
        {
            get 
            {
                if (refer.convertResolution_변환기준.Text.Length == 0) return null;
                return Convert.ToUInt32(refer.convertResolution_변환기준.Text); 
            }
        }
        public FilesizeUnit ConvertedVidSizeUnit
        {
            get { return FilesizeUnitHelper.ToFilesizeUnit(refer.convertResolution_변환예상크기.Text); }
        }

        public InfoControlReader(InfoControlReference refer)
        {            
            this.refer = refer;
        }
    }
}
