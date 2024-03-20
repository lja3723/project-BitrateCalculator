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
        private VisualStorage storage;

        private TextBox originVidInfo_시간;
        private TextBox originVidInfo_분;
        private TextBox originVidInfo_초;
        private TextBox originVidInfo_화면해상도_가로;
        private TextBox originVidInfo_화면해상도_세로;
        private TextBox originVidInfo_초당프레임;
        private TextBox originVidInfo_오디오비트레이트;
        private ComboBox originVidInfo_적용코덱;

        private ComboBox bitrate_최대영상비트레이트;
        private ComboBox bitrate_예상출력영상크기;

        private ComboBox outSizeBasedBitrate_원하는출력영상크기_단위;
        private TextBox outSizeBasedBitrate_원하는출력영상크기;
        private ComboBox outSizeBasedBitrate_예상영상비트레이트;

        private ComboBox convertResolution_변환기준_단위;
        private TextBox convertResolution_변환기준;
        private ComboBox convertResolution_변환예상크기;

        private Label valuePrint_Bitrate_최대영상비트레이트;
        private Label valuePrint_Bitrate_예상출력영상크기;
        private Label valuePrint_OutSizeBasedBitrate_예상영상비트레이트;
        private Label valuePrint_ConvertResolution_현재해상도_가로;
        private Label valuePrint_ConvertResolution_현재해상도_세로;
        private Label valuePrint_ConvertResolution_변환예상해상도_가로;
        private Label valuePrint_ConvertResolution_변환예상해상도_세로;
        private Label valuePrint_ConvertResolution_변환예상크기;



        public int 시간
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public int 분
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public int 초
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public int 화면해상도_가로
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public int 화면해상도_세로
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public int 초당프레임
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public int 오디오비트레이트
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public Codecs 적용코덱
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }

        public PersecUnit 최대영상비트레이트
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public FilesizeUnit 예상출력영상크기
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }

        public FilesizeUnit 원하는출력영상크기_단위
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public int 원하는출력영상크기
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public PersecUnit 예상영상비트레이트
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public bool 변환기준_단위
        {
            get
            {
                return true;
            }
            set
            {

            }
        }

        public int 변환기준
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public FilesizeUnit 변환예상크기
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }

        public decimal ValuePrint_최대영상비트레이트
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public decimal ValuePrint_예상출력영상크기
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public decimal ValuePrin_예상영상비트레이트
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public int ValuePrint_현재해상도_가로
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public int ValuePrint_현재해상도_세로
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public int ValuePrint_변환예상해상도_가로
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public int ValuePrint_변환예상해상도_세로
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }
        public decimal ValuePrint_변환예상크기
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }



        public VisualManager(TextBox originVidInfo_시간, TextBox originVidInfo_분, TextBox originVidInfo_초, TextBox originVidInfo_화면해상도_가로, TextBox originVidInfo_화면해상도_세로, TextBox originVidInfo_초당프레임, TextBox originVidInfo_오디오비트레이트, ComboBox originVidInfo_적용코덱, ComboBox bitrate_최대영상비트레이트, ComboBox bitrate_예상출력영상크기, ComboBox outSizeBasedBitrate_원하는출력영상크기_단위, TextBox outSizeBasedBitrate_원하는출력영상크기, ComboBox outSizeBasedBitrate_예상영상비트레이트, ComboBox convertResolution_변환기준_단위, TextBox convertResolution_변환기준, ComboBox convertResolution_변환예상크기, Label valuePrint_Bitrate_최대영상비트레이트, Label valuePrint_Bitrate_예상출력영상크기, Label valuePrint_OutSizeBasedBitrate_예상영상비트레이트, Label valuePrint_ConvertResolution_현재해상도_가로, Label valuePrint_ConvertResolution_현재해상도_세로, Label valuePrint_ConvertResolution_변환예상해상도_가로, Label valuePrint_ConvertResolution_변환예상해상도_세로, Label valuePrint_ConvertResolution_변환예상크기)
        {
            storage = new VisualStorage();
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

    internal class VisualStorage
    {

    }

}
