namespace Bitrate_Calculator.src
{
    public class RealtimeManager
    {
        private readonly BitrateCalculator calc;
        private readonly InfoControlManager reader;
        private readonly LabelDisplayManager label;
        private readonly ButtonFunctionAccessor accessor;
        private readonly StatusStripManager stripManager;


        #region 프로그램 영역 업데이트
        //프로그램 새로고침
        public void RefreshProgram()
        {
            UpdateBitrateArea();
            UpdateOutsizeBasedBitrateArea();
            UpdateConvertedResolutionArea();
        }
        
        //어떤 필드든 상관 없이 항상 업데이트
        private void UpdateConditionless() 
        { 
            accessor.ClearAllEnabled = true;
            RefreshProgram();
        }

        //bitrate 영역 업데이트
        private void UpdateBitrateArea()
        {
            label.MaxBitrate = calc.MaxBitrate ?? 0;
            label.ExpectedOutputVidSize = calc.ExpectedOutputVidSize ?? 0;
        }

        //출력영상 기준 비트레이트 계산 영역 업데이트
        private void UpdateOutsizeBasedBitrateArea()
        {
            label.DesiredOutputBitrate = calc.DesiredOutputBitrate ?? 0;
        }

        //해상도 변환 영역 업데이트
        private void UpdateConvertedResolutionArea()
        {
            label.ConvertedWidth = calc.ConvertedWidth ?? 0;
            label.ConvertedHeight = calc.ConvertedHeight ?? 0;
            label.ConvertedVidSize = calc.ConvertedVidSize ?? 0;
        }
        #endregion


        #region Origin Video Field 업데이트
        private void UpdateOriginField()
        {
            accessor.ClearOriginVidFieldEnabled = true;
        }
        public void UpdateHour()
        {
            calc.Hour = reader.Hour;
            UpdateConditionless();
            UpdateOriginField();
        }
        public void UpdateMin()
        {
            calc.Min = reader.Min;
            UpdateConditionless();
            UpdateOriginField();
        }
        public void UpdateSec()
        {
            calc.Sec = reader.Sec;
            UpdateConditionless();
            UpdateOriginField();
        }
        public void UpdateWidth()
        {
            uint? width = reader.Width;
            calc.Width = width;
            label.Width = width ?? 0; //해상도변환 영역의 가로도 변경
            UpdateConditionless();
            UpdateOriginField();
        }
        public void UpdateHeight()
        {
            uint? height = reader.Height;
            calc.Height = height;
            label.Height = height ?? 0; //해상도변환 영역의 세로도 변경
            UpdateConditionless();
            UpdateOriginField();
        }
        public void UpdateFps()
        {
            calc.Fps = reader.Fps;
            UpdateConditionless();
            UpdateOriginField();
        }
        public void UpdateAudioBitrate()
        {
            calc.AudioBitrate = reader.AudioBitrate;
            UpdateConditionless();
            UpdateOriginField();
        }
        public void UpdateCodec()
        {
            calc.Codec = reader.Codec;
            UpdateConditionless();
            UpdateOriginField();
        }

        #endregion


        #region 비트레이트 Field / 출력영상크기 기준 비트레이트 Field 업데이트
        public void UpdateMaxBitrateUnit()
        {
            calc.MaxBitrateUnit = reader.MaxBitrateUnit;
            UpdateConditionless(); 
        }
        public void UpdateExpectedOutputVidSizeUnit()
        {
            calc.ExpectedOutputVidSizeUnit = reader.ExpectedOutputVidSizeUnit;
            UpdateConditionless(); 
        }
        public void UpdateDesiredOutputVidSizeUnit()
        {
            calc.DesiredOutputVidSizeUnit = reader.DesiredOutputVidSizeUnit;
            UpdateConditionless(); 
        }
        public void UpdateDesiredOutputVidSize()
        {
            calc.DesiredOutputVidSize = reader.DesiredOutputVidSize;
            UpdateConditionless(); 
        }
        public void UpdateDesiredOutputBitrateUnit()
        {
            calc.DesiredOutputBitrateUnit = reader.DesiredOutputBitrateUnit;
            UpdateConditionless(); 
        }
        #endregion


        #region 해상도 변환 Field 업데이트
        private void UpdateConvertResolutionField()
        {
            uint width = calc.ConvertedWidth ?? 0;
            uint height = calc.ConvertedHeight ?? 0;
            const uint MaxRange = BitrateCalculator.ConvertedResolutionMaxRange;

            //변환된 해상도가 정상 범위 내에 있음
            if (width <= MaxRange && height <= MaxRange)
            {
                accessor.ApplyConvertResolutionEnabled = true;
                return;
            }

            string name = "null";
            if (width > MaxRange)
                name = ConvertResolutionBaseHelper.ToString(ConvertResolutionBase.Horizontal);
            else if (height > MaxRange)
                name = ConvertResolutionBaseHelper.ToString(ConvertResolutionBase.Vertical);

            label.ConvertedVidSize = 0;
            accessor.ApplyConvertResolutionEnabled = false;
            stripManager.ShowErrorMessage("변환 예상 해상도의 " + name + " 길이가 최대 범위(" + MaxRange + ")를 벗어납니다.");
        }
        public void UpdateConvertResolutionBase()
        {
            calc.ConvertResolutionBase = reader.ConvertResolutionBase;
            UpdateConditionless(); 
            UpdateConvertResolutionField();
        }
        public void UpdateConvertResolutionSize()
        {
            uint? convertBase = reader.ConvertResolutionSize;
            calc.ConvertResolutionSize = convertBase;
            UpdateConditionless();
            UpdateConvertResolutionField();

            if (!convertBase.HasValue)
                accessor.ApplyConvertResolutionEnabled = false;
        }
        public void UpdateConvertedVidSizeUnit()
        {
            calc.ConvertedVidSizeUnit = reader.ConvertedVidSizeUnit;
            UpdateConditionless();
            UpdateConvertResolutionField();
        }
        #endregion


        public RealtimeManager(BitrateCalculator calc, InfoControlManager reader, LabelDisplayManager label, ButtonFunctionAccessor accessor, StatusStripManager stripManager)
        {
            this.calc = calc;
            this.reader = reader;
            this.label = label;
            this.accessor = accessor;
            this.stripManager = stripManager;
        }
    }
}
