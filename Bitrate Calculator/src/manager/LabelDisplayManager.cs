using System;
using System.Windows.Forms;

namespace Bitrate_Calculator.src
{
    //값 출력 목적 라벨을 관리함
    public class LabelDisplayManager
    {
        private readonly ResultPrecisionManager precision;

        private readonly Label valuePrint_Bitrate_최대영상비트레이트;
        private readonly Label valuePrint_Bitrate_예상출력영상크기;
        private readonly Label valuePrint_OutSizeBasedBitrate_예상영상비트레이트;
        private readonly Label valuePrint_ConvertResolution_현재해상도_가로;
        private readonly Label valuePrint_ConvertResolution_현재해상도_세로;
        private readonly Label valuePrint_ConvertResolution_변환예상해상도_가로;
        private readonly Label valuePrint_ConvertResolution_변환예상해상도_세로;
        private readonly Label valuePrint_ConvertResolution_변환예상크기;


        public decimal MaxBitrate //최대영상비트레이트
        {
            set
            {
                valuePrint_Bitrate_최대영상비트레이트.Text = value.ToString(precision.BitratePrecisionFormat);
            }
        }
        public decimal ExpectedOutputVidSize //예상출력영상크기
        {
            set
            {
                valuePrint_Bitrate_예상출력영상크기.Text = value.ToString(precision.CapacityPrecisionFormat);
            }
        }
        public decimal DesiredOutputBitrate //출력영상크기기준 예상영상비트레이트
        {
            set
            {
                valuePrint_OutSizeBasedBitrate_예상영상비트레이트.Text = value.ToString(precision.BitratePrecisionFormat);
            }
        }
        public uint Width //현재영상 해상도 가로
        {
            set
            {
                valuePrint_ConvertResolution_현재해상도_가로.Text = Convert.ToString(value);
            }
        }
        public uint Height //현재영상 해상도 세로
        {
            set
            {
                valuePrint_ConvertResolution_현재해상도_세로.Text = Convert.ToString(value);
            }
        }
        public uint ConvertedWidth //변환된영상 해상도 가로
        {
            set
            {
                valuePrint_ConvertResolution_변환예상해상도_가로.Text = value <= BitrateCalculator.ConvertedResolutionMaxRange ?
                    Convert.ToString(value) : "MAX";
            }
        }
        public uint ConvertedHeight //변환된영상 해상도 세로
        {
            set
            {
                valuePrint_ConvertResolution_변환예상해상도_세로.Text = value <= BitrateCalculator.ConvertedResolutionMaxRange ?
                    Convert.ToString(value) : "MAX";
            }
        }
        public decimal ConvertedVidSize //변환된 영상 크기
        {
            set
            {
                valuePrint_ConvertResolution_변환예상크기.Text = value.ToString(precision.CapacityPrecisionFormat);
            }
        }


        public void ClearAll()
        {
            MaxBitrate = 0;
            ExpectedOutputVidSize = 0;
            DesiredOutputBitrate = 0;
            Width = 0;
            Height = 0;
            ConvertedWidth = 0;
            ConvertedHeight = 0;
            ConvertedVidSize = 0;
        }


        public LabelDisplayManager(ResultPrecisionManager precision, Label valuePrint_Bitrate_최대영상비트레이트, Label valuePrint_Bitrate_예상출력영상크기, Label valuePrint_OutSizeBasedBitrate_예상영상비트레이트, Label valuePrint_ConvertResolution_현재해상도_가로, Label valuePrint_ConvertResolution_현재해상도_세로, Label valuePrint_ConvertResolution_변환예상해상도_가로, Label valuePrint_ConvertResolution_변환예상해상도_세로, Label valuePrint_ConvertResolution_변환예상크기)
        {
            this.precision = precision;
            this.valuePrint_Bitrate_최대영상비트레이트 = valuePrint_Bitrate_최대영상비트레이트;
            this.valuePrint_Bitrate_예상출력영상크기 = valuePrint_Bitrate_예상출력영상크기;
            this.valuePrint_OutSizeBasedBitrate_예상영상비트레이트 = valuePrint_OutSizeBasedBitrate_예상영상비트레이트;
            this.valuePrint_ConvertResolution_현재해상도_가로 = valuePrint_ConvertResolution_현재해상도_가로;
            this.valuePrint_ConvertResolution_현재해상도_세로 = valuePrint_ConvertResolution_현재해상도_세로;
            this.valuePrint_ConvertResolution_변환예상해상도_가로 = valuePrint_ConvertResolution_변환예상해상도_가로;
            this.valuePrint_ConvertResolution_변환예상해상도_세로 = valuePrint_ConvertResolution_변환예상해상도_세로;
            this.valuePrint_ConvertResolution_변환예상크기 = valuePrint_ConvertResolution_변환예상크기;
            ClearAll();
        }
    }
}
