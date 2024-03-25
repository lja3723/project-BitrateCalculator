using System.Windows.Forms;

namespace Bitrate_Calculator.src.manager
{
    /// <summary>
    ///     정보 표시 컨트롤(텍스트박스 또는 콤보박스)에 대한 참조를 제공한다.
    /// </summary>
    public class InfoControlReference
    {
        public readonly TextBox originVidInfo_시간;
        public readonly TextBox originVidInfo_분;
        public readonly TextBox originVidInfo_초;
        public readonly TextBox originVidInfo_화면해상도_가로;
        public readonly TextBox originVidInfo_화면해상도_세로;
        public readonly TextBox originVidInfo_초당프레임;
        public readonly TextBox originVidInfo_오디오비트레이트;
        public readonly ComboBox originVidInfo_적용코덱;

        public readonly ComboBox bitrate_최대영상비트레이트;
        public readonly ComboBox bitrate_예상출력영상크기;

        public readonly ComboBox outSizeBasedBitrate_원하는출력영상크기_단위;
        public readonly TextBox outSizeBasedBitrate_원하는출력영상크기;
        public readonly ComboBox outSizeBasedBitrate_예상영상비트레이트;

        public readonly ComboBox convertResolution_변환기준_단위;
        public readonly TextBox convertResolution_변환기준;
        public readonly ComboBox convertResolution_변환예상크기;

        public InfoControlReference(TextBox originVidInfo_시간, TextBox originVidInfo_분, TextBox originVidInfo_초, TextBox originVidInfo_화면해상도_가로, TextBox originVidInfo_화면해상도_세로, TextBox originVidInfo_초당프레임, TextBox originVidInfo_오디오비트레이트, ComboBox originVidInfo_적용코덱, ComboBox bitrate_최대영상비트레이트, ComboBox bitrate_예상출력영상크기, ComboBox outSizeBasedBitrate_원하는출력영상크기_단위, TextBox outSizeBasedBitrate_원하는출력영상크기, ComboBox outSizeBasedBitrate_예상영상비트레이트, ComboBox convertResolution_변환기준_단위, TextBox convertResolution_변환기준, ComboBox convertResolution_변환예상크기)
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
