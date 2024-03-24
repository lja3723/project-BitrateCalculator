using System;
using System.Windows.Forms;

namespace Bitrate_Calculator.src
{
    //텍스트박스 or 콤보박스의 값을 실제 데이터로 읽는 기능을 담당
    public class InfoControlManager
    {
        #region Field References
        private readonly TextBox originVidInfo_시간;
        private readonly TextBox originVidInfo_분;
        private readonly TextBox originVidInfo_초;
        private readonly TextBox originVidInfo_화면해상도_가로;
        private readonly TextBox originVidInfo_화면해상도_세로;
        private readonly TextBox originVidInfo_초당프레임;
        private readonly TextBox originVidInfo_오디오비트레이트;
        private readonly ComboBox originVidInfo_적용코덱;

        private readonly ComboBox bitrate_최대영상비트레이트;
        private readonly ComboBox bitrate_예상출력영상크기;

        private readonly ComboBox outSizeBasedBitrate_원하는출력영상크기_단위;
        private readonly TextBox outSizeBasedBitrate_원하는출력영상크기;
        private readonly ComboBox outSizeBasedBitrate_예상영상비트레이트;

        private readonly ComboBox convertResolution_변환기준_단위;
        private readonly TextBox convertResolution_변환기준;
        private readonly ComboBox convertResolution_변환예상크기;
        #endregion


        #region Properties / Getter만 존재
        public uint? Hour
        {
            get 
            {
                if (originVidInfo_시간.Text.Length == 0) return null;
                return Convert.ToUInt32(originVidInfo_시간.Text); 
            }
        }
        public uint? Min
        {
            get
            {
                if (originVidInfo_분.Text.Length == 0) return null;
                return Convert.ToUInt32(originVidInfo_분.Text); 
            }
        }
        public uint? Sec
        {
            get
            {
                if (originVidInfo_초.Text.Length == 0) return null;
                return Convert.ToUInt32(originVidInfo_초.Text); 
            }
        }
        public uint? Width
        {
            get
            {
                if (originVidInfo_화면해상도_가로.Text.Length == 0) return null;
                return Convert.ToUInt32(originVidInfo_화면해상도_가로.Text);
            }
        }
        public uint? Height
        {
            get
            {
                if (originVidInfo_화면해상도_세로.Text.Length == 0) return null;
                return Convert.ToUInt32(originVidInfo_화면해상도_세로.Text); 
            }
        }
        public uint? Fps
        {
            get
            {
                if (originVidInfo_초당프레임.Text.Length == 0) return null;
                return Convert.ToUInt32(originVidInfo_초당프레임.Text); 
            }
        }
        public uint? AudioBitrate
        {
            get
            {
                if (originVidInfo_오디오비트레이트.Text.Length == 0) return null;
                return Convert.ToUInt32(originVidInfo_오디오비트레이트.Text); 
            }
        }
        public Codecs Codec
        {
            get { return CodecsHelper.ToCodecs(originVidInfo_적용코덱.Text); }
        }


        public PersecUnit MaxBitrateUnit
        {
            get { return PersecUnitHelper.ToPersecUnit(bitrate_최대영상비트레이트.Text); }
        }
        public FilesizeUnit ExpectedOutputVidSizeUnit
        {
            get { return FilesizeUnitHelper.ToFilesizeUnit(bitrate_예상출력영상크기.Text); }
        }


        public FilesizeUnit DesiredOutputVidSizeUnit
        {
            get { return FilesizeUnitHelper.ToFilesizeUnit(outSizeBasedBitrate_원하는출력영상크기_단위.Text); }
        }
        public uint? DesiredOutputVidSize
        {
            get 
            {
                if (outSizeBasedBitrate_원하는출력영상크기.Text.Length == 0) return null;
                return Convert.ToUInt32(outSizeBasedBitrate_원하는출력영상크기.Text); 
            }
        }
        public PersecUnit DesiredOutputBitrateUnit
        {
            get { return PersecUnitHelper.ToPersecUnit(outSizeBasedBitrate_예상영상비트레이트.Text); }
        }
        
        
        public ConvertResolutionBase ConvertResolutionBase
        {
            get { return ConvertResolutionBaseHelper.ToConvertResolutionBase(convertResolution_변환기준_단위.Text); }
        }
        public uint? ConvertResolutionSize
        {
            get 
            {
                if (convertResolution_변환기준.Text.Length == 0) return null;
                return Convert.ToUInt32(convertResolution_변환기준.Text); 
            }
        }
        public FilesizeUnit ConvertedVidSizeUnit
        {
            get { return FilesizeUnitHelper.ToFilesizeUnit(convertResolution_변환예상크기.Text); }
        }
        #endregion


        #region Field Clear
        public void ClearOriginVidFields(ButtonFunctionAccessor accessor, StatusStripManager statusManager)
        {
            originVidInfo_시간.Clear();
            originVidInfo_분.Clear();
            originVidInfo_초.Clear();
            originVidInfo_화면해상도_가로.Clear();
            originVidInfo_화면해상도_세로.Clear();
            originVidInfo_초당프레임.Clear();
            originVidInfo_오디오비트레이트.Clear();
            originVidInfo_적용코덱.Text = CodecsHelper.ToString(CodecsHelper.Default);

            accessor.ClearOriginVidFieldEnabled = false;
            statusManager.ShowMessage("원본 영상 파일 정보가 초기화되었습니다.");
        }

        public void ApplyConvertResolution(ButtonFunctionAccessor accessor, StatusStripManager statusManager, BitrateCalculator calculator)
        {
            originVidInfo_화면해상도_가로.Text = calculator.ConvertedWidth.ToString();
            originVidInfo_화면해상도_세로.Text = calculator.ConvertedHeight.ToString();

            convertResolution_변환기준.Clear();
            convertResolution_변환기준_단위.Text = ConvertResolutionBaseHelper.ToString(ConvertResolutionBaseHelper.Default);
            convertResolution_변환예상크기.Text = FilesizeUnitHelper.ToString(FilesizeUnitHelper.Default);

            accessor.ApplyConvertResolutionEnabled = false;
            statusManager.ShowMessage("변환된 해상도가 적용되었습니다.");
        }

        public void ClearAll(ButtonFunctionAccessor accessor, StatusStripManager statusManager, LabelDisplayManager label)
        {
            ClearOriginVidFields(accessor, statusManager);

            bitrate_최대영상비트레이트.Text = PersecUnitHelper.ToString(PersecUnitHelper.Default);
            bitrate_예상출력영상크기.Text = FilesizeUnitHelper.ToString(FilesizeUnitHelper.Default);

            outSizeBasedBitrate_원하는출력영상크기_단위.Text = FilesizeUnitHelper.ToString(FilesizeUnitHelper.Default);
            outSizeBasedBitrate_원하는출력영상크기.Clear();
            outSizeBasedBitrate_예상영상비트레이트.Text = PersecUnitHelper.ToString(PersecUnitHelper.Default);

            convertResolution_변환기준_단위.Text = ConvertResolutionBaseHelper.ToString(ConvertResolutionBaseHelper.Default);
            convertResolution_변환기준.Clear();
            convertResolution_변환예상크기.Text = FilesizeUnitHelper.ToString(FilesizeUnitHelper.Default);

            label.ClearAll();

            accessor.ApplyConvertResolutionEnabled = false;
            accessor.ClearAllEnabled = false;
            statusManager.ShowMessage("모두 초기화되었습니다.");
        }

        #endregion



        public InfoControlManager(TextBox originVidInfo_시간, TextBox originVidInfo_분, TextBox originVidInfo_초, TextBox originVidInfo_화면해상도_가로, TextBox originVidInfo_화면해상도_세로, TextBox originVidInfo_초당프레임, TextBox originVidInfo_오디오비트레이트, ComboBox originVidInfo_적용코덱, ComboBox bitrate_최대영상비트레이트, ComboBox bitrate_예상출력영상크기, ComboBox outSizeBasedBitrate_원하는출력영상크기_단위, TextBox outSizeBasedBitrate_원하는출력영상크기, ComboBox outSizeBasedBitrate_예상영상비트레이트, ComboBox convertResolution_변환기준_단위, TextBox convertResolution_변환기준, ComboBox convertResolution_변환예상크기)
        {
            this.originVidInfo_시간 = originVidInfo_시간;
            this.originVidInfo_분 = originVidInfo_분;
            this.originVidInfo_초 = originVidInfo_초;
            this.originVidInfo_화면해상도_가로 = originVidInfo_화면해상도_가로;
            this.originVidInfo_화면해상도_세로 = originVidInfo_화면해상도_세로;
            this.originVidInfo_초당프레임 = originVidInfo_초당프레임;
            this.originVidInfo_오디오비트레이트 = originVidInfo_오디오비트레이트;
            this.originVidInfo_적용코덱 = originVidInfo_적용코덱;
            this.bitrate_최대영상비트레이트 = bitrate_최대영상비트레이트;
            this.bitrate_예상출력영상크기 = bitrate_예상출력영상크기;
            this.outSizeBasedBitrate_원하는출력영상크기_단위 = outSizeBasedBitrate_원하는출력영상크기_단위;
            this.outSizeBasedBitrate_원하는출력영상크기 = outSizeBasedBitrate_원하는출력영상크기;
            this.outSizeBasedBitrate_예상영상비트레이트 = outSizeBasedBitrate_예상영상비트레이트;
            this.convertResolution_변환기준_단위 = convertResolution_변환기준_단위;
            this.convertResolution_변환기준 = convertResolution_변환기준;
            this.convertResolution_변환예상크기 = convertResolution_변환예상크기;
        }
    }
}
