using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace Bitrate_Calculator.src.manager
{
    /// <summary>
    ///     정보 표시 컨트롤(텍스트박스 또는 콤보박스)의 값을 조정하는 기능을 수행한다.
    /// </summary>
    internal class InfoControlAdjuster
    {
        private readonly InfoControlReference refer;

        public void ClearOriginVidFields(ButtonFunctionAccessor accessor, StatusBar statusBar)
        {
            refer.originVidInfo_시간.Clear();
            refer.originVidInfo_분.Clear();
            refer.originVidInfo_초.Clear();
            refer.originVidInfo_화면해상도_가로.Clear();
            refer.originVidInfo_화면해상도_세로.Clear();
            refer.originVidInfo_초당프레임.Clear();
            refer.originVidInfo_오디오비트레이트.Clear();
            refer.originVidInfo_적용코덱.Text = CodecsHelper.ToString(CodecsHelper.Default);

            accessor.ClearOriginVidFieldEnabled = false;
            statusBar.ShowMessage("원본 영상 파일 정보가 초기화되었습니다.");
        }

        public void ApplyConvertResolution(ButtonFunctionAccessor accessor, StatusBar statusBar, BitrateCalculator calculator)
        {
            refer.originVidInfo_화면해상도_가로.Text = calculator.ConvertedWidth.ToString();
            refer.originVidInfo_화면해상도_세로.Text = calculator.ConvertedHeight.ToString();

            refer.convertResolution_변환기준.Clear();
            refer.convertResolution_변환기준_단위.Text = ConvertResolutionBaseHelper.ToString(ConvertResolutionBaseHelper.Default);
            refer.convertResolution_변환예상크기.Text = FilesizeUnitHelper.ToString(FilesizeUnitHelper.Default);

            accessor.ApplyConvertResolutionEnabled = false;
            statusBar.ShowMessage("변환된 해상도가 적용되었습니다.");
        }

        public void ClearAll(ButtonFunctionAccessor accessor, StatusBar statusBar, LabelDisplay label)
        {
            ClearOriginVidFields(accessor, statusBar);

            refer.bitrate_최대영상비트레이트.Text = PersecUnitHelper.ToString(PersecUnitHelper.Default);
            refer.bitrate_예상출력영상크기.Text = FilesizeUnitHelper.ToString(FilesizeUnitHelper.Default);

            refer.outSizeBasedBitrate_원하는출력영상크기_단위.Text = FilesizeUnitHelper.ToString(FilesizeUnitHelper.Default);
            refer.outSizeBasedBitrate_원하는출력영상크기.Clear();
            refer.outSizeBasedBitrate_예상영상비트레이트.Text = PersecUnitHelper.ToString(PersecUnitHelper.Default);

            refer.convertResolution_변환기준_단위.Text = ConvertResolutionBaseHelper.ToString(ConvertResolutionBaseHelper.Default);
            refer.convertResolution_변환기준.Clear();
            refer.convertResolution_변환예상크기.Text = FilesizeUnitHelper.ToString(FilesizeUnitHelper.Default);

            label.ClearAll();

            accessor.ApplyConvertResolutionEnabled = false;
            accessor.ClearAllEnabled = false;
            statusBar.ShowMessage("모두 초기화되었습니다.");
        }

        private void SetTextboxMargin()
        {
            //텍스트박스 크기 초기화
            int textBoxHeight = 27;
            double textBoxWidth = 9.8;
            int textBoxWidthMargin = 10;

            foreach (TextBox t in new List<TextBox>() {
                refer.originVidInfo_시간,
                refer.originVidInfo_분,
                refer.originVidInfo_초,
                refer.originVidInfo_화면해상도_가로,
                refer.originVidInfo_화면해상도_세로,
                refer.originVidInfo_초당프레임,
                refer.originVidInfo_오디오비트레이트,
                refer.outSizeBasedBitrate_원하는출력영상크기,
                refer.convertResolution_변환기준
            })
            {
                t.Height = textBoxHeight;
                t.Width = (int)Math.Round(t.MaxLength * textBoxWidth + textBoxWidthMargin);
            }
        }

        public InfoControlAdjuster(InfoControlReference refer)
        {
            this.refer = refer;

            SetTextboxMargin();
        }
    }
}
