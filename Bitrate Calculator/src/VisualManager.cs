using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitrate_Calculator.src
{
    internal class VisualManager
    {
        private readonly Storage storage;
        private readonly ResultPrecisionManager precision;

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

        private readonly Label valuePrint_Bitrate_최대영상비트레이트;
        private readonly Label valuePrint_Bitrate_예상출력영상크기;
        private readonly Label valuePrint_OutSizeBasedBitrate_예상영상비트레이트;
        private readonly Label valuePrint_ConvertResolution_현재해상도_가로;
        private readonly Label valuePrint_ConvertResolution_현재해상도_세로;
        private readonly Label valuePrint_ConvertResolution_변환예상해상도_가로;
        private readonly Label valuePrint_ConvertResolution_변환예상해상도_세로;
        private readonly Label valuePrint_ConvertResolution_변환예상크기;


        public int 시간
        {
            get 
            {
                if (originVidInfo_시간.Text.Length == 0) return -1; //값이 0이 아닌 아예 null 의미
                return Convert.ToInt32(originVidInfo_시간.Text); 
            }
        }
        public int 분
        {
            get
            {
                if (originVidInfo_분.Text.Length == 0) return -1;
                return Convert.ToInt32(originVidInfo_분.Text); 
            }
        }
        public int 초
        {
            get
            {
                if (originVidInfo_초.Text.Length == 0) return -1;
                return Convert.ToInt32(originVidInfo_초.Text); 
            }
        }
        public int 화면해상도_가로
        {
            get
            {
                if (originVidInfo_화면해상도_가로.Text.Length == 0) return -1;
                return Convert.ToInt32(originVidInfo_화면해상도_가로.Text);
            }
        }
        public int 화면해상도_세로
        {
            get
            {
                if (originVidInfo_화면해상도_세로.Text.Length == 0) return -1;
                return Convert.ToInt32(originVidInfo_화면해상도_세로.Text); 
            }
        }
        public int 초당프레임
        {
            get
            {
                if (originVidInfo_초당프레임.Text.Length == 0) return -1;
                return Convert.ToInt32(originVidInfo_초당프레임.Text); 
            }
        }
        public int 오디오비트레이트
        {
            get
            {
                if (originVidInfo_오디오비트레이트.Text.Length == 0) return -1;
                return Convert.ToInt32(originVidInfo_오디오비트레이트.Text); 
            }
        }
        public Codecs 적용코덱
        {
            get { return CodecsHelper.ToCodecs(originVidInfo_적용코덱.Text); }
        }


        public PersecUnit 최대영상비트레이트
        {
            get { return PersecUnitHelper.ToPersecUnit(bitrate_최대영상비트레이트.Text); }
        }
        public FilesizeUnit 예상출력영상크기
        {
            get { return FilesizeUnitHelper.ToFilesizeUnit(bitrate_예상출력영상크기.Text); }
        }


        public FilesizeUnit 원하는출력영상크기_단위
        {
            get { return FilesizeUnitHelper.ToFilesizeUnit(outSizeBasedBitrate_원하는출력영상크기_단위.Text); }
        }
        public int 원하는출력영상크기
        {
            get 
            {
                if (outSizeBasedBitrate_원하는출력영상크기.Text.Length == 0) return -1;
                return Convert.ToInt32(outSizeBasedBitrate_원하는출력영상크기.Text); 
            }
        }
        public PersecUnit 예상영상비트레이트
        {
            get { return PersecUnitHelper.ToPersecUnit(outSizeBasedBitrate_예상영상비트레이트.Text); }
        }
        
        
        public ConvertResolutionBase 변환기준_단위
        {
            get { return ConvertResolutionBaseHelper.ToConvertResolutionBase(convertResolution_변환기준_단위.Text); }
        }
        public int 변환기준
        {
            get 
            {
                if (convertResolution_변환기준.Text.Length == 0) return -1;
                return Convert.ToInt32(convertResolution_변환기준.Text); 
            }
        }
        public FilesizeUnit 변환예상크기
        {
            get { return FilesizeUnitHelper.ToFilesizeUnit(convertResolution_변환예상크기.Text); }
        }


        public decimal ValueLabel최대영상비트레이트
        {

            get //임시구현
            {
                return Convert.ToDecimal(valuePrint_Bitrate_최대영상비트레이트.Text);
            }
            set 
            { 
                //3자리씩 끊는 로직 추가 필요
                valuePrint_Bitrate_최대영상비트레이트.Text = value.ToString(precision.BitratePrecisionFormat); 
            }
        }
        public decimal ValueLabel예상출력영상크기
        {
            set
            {
                valuePrint_Bitrate_예상출력영상크기.Text = value.ToString(precision.CapacityPrecisionFormat);
            }
        }
        public decimal ValueLabel예상영상비트레이트
        {

            get //임시구현
            {
                return Convert.ToDecimal(valuePrint_OutSizeBasedBitrate_예상영상비트레이트.Text);
            }
            set
            {
                valuePrint_OutSizeBasedBitrate_예상영상비트레이트.Text = value.ToString(precision.BitratePrecisionFormat);
            }
        }
        public int ValueLabel현재해상도_가로
        {
            set
            {
                valuePrint_ConvertResolution_현재해상도_가로.Text = Convert.ToString(value);
            }
        }
        public int ValueLabel현재해상도_세로
        {
            set
            {
                valuePrint_ConvertResolution_현재해상도_세로.Text = Convert.ToString(value);
            }
        }
        public int ValueLabel변환예상해상도_가로
        {

            get //임시구현
            {
                if (valuePrint_ConvertResolution_변환예상해상도_가로.Text == "MAX") return -1;
                return Convert.ToInt32(valuePrint_ConvertResolution_변환예상해상도_가로.Text);
            }
            set
            {
                valuePrint_ConvertResolution_변환예상해상도_가로.Text = value <= 변환예상해상도_최대범위 ?
                    Convert.ToString(value) : "MAX";
            }
        }
        public int ValueLabel변환예상해상도_세로
        {
            get //임시구현
            {
                if (valuePrint_ConvertResolution_변환예상해상도_세로.Text == "MAX") return -1;
                return Convert.ToInt32(valuePrint_ConvertResolution_변환예상해상도_세로.Text);
            }
            set
            {
                valuePrint_ConvertResolution_변환예상해상도_세로.Text = value <= 변환예상해상도_최대범위 ?
                    Convert.ToString(value) : "MAX";
            }
        }
        public decimal ValueLabel변환예상크기
        {
            set
            {
                valuePrint_ConvertResolution_변환예상크기.Text = value.ToString(precision.CapacityPrecisionFormat);
            }
        }

        public const int 변환예상해상도_최대범위 = 9999;


        public VisualManager(ResultPrecisionManager precision, TextBox originVidInfo_시간, TextBox originVidInfo_분, TextBox originVidInfo_초, TextBox originVidInfo_화면해상도_가로, TextBox originVidInfo_화면해상도_세로, TextBox originVidInfo_초당프레임, TextBox originVidInfo_오디오비트레이트, ComboBox originVidInfo_적용코덱, ComboBox bitrate_최대영상비트레이트, ComboBox bitrate_예상출력영상크기, ComboBox outSizeBasedBitrate_원하는출력영상크기_단위, TextBox outSizeBasedBitrate_원하는출력영상크기, ComboBox outSizeBasedBitrate_예상영상비트레이트, ComboBox convertResolution_변환기준_단위, TextBox convertResolution_변환기준, ComboBox convertResolution_변환예상크기, Label valuePrint_Bitrate_최대영상비트레이트, Label valuePrint_Bitrate_예상출력영상크기, Label valuePrint_OutSizeBasedBitrate_예상영상비트레이트, Label valuePrint_ConvertResolution_현재해상도_가로, Label valuePrint_ConvertResolution_현재해상도_세로, Label valuePrint_ConvertResolution_변환예상해상도_가로, Label valuePrint_ConvertResolution_변환예상해상도_세로, Label valuePrint_ConvertResolution_변환예상크기)
        {
            storage = new Storage();
            this.precision = precision;
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
            this.valuePrint_Bitrate_최대영상비트레이트 = valuePrint_Bitrate_최대영상비트레이트;
            this.valuePrint_Bitrate_예상출력영상크기 = valuePrint_Bitrate_예상출력영상크기;
            this.valuePrint_OutSizeBasedBitrate_예상영상비트레이트 = valuePrint_OutSizeBasedBitrate_예상영상비트레이트;
            this.valuePrint_ConvertResolution_현재해상도_가로 = valuePrint_ConvertResolution_현재해상도_가로;
            this.valuePrint_ConvertResolution_현재해상도_세로 = valuePrint_ConvertResolution_현재해상도_세로;
            this.valuePrint_ConvertResolution_변환예상해상도_가로 = valuePrint_ConvertResolution_변환예상해상도_가로;
            this.valuePrint_ConvertResolution_변환예상해상도_세로 = valuePrint_ConvertResolution_변환예상해상도_세로;
            this.valuePrint_ConvertResolution_변환예상크기 = valuePrint_ConvertResolution_변환예상크기;
        }
    }
}
