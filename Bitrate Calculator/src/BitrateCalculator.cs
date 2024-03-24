using System;

namespace Bitrate_Calculator.src
{
    public class BitrateCalculator
    {
        #region 원본영상 파일정보 Field
        public uint? Hour { private get; set; } //시간
        public uint? Min { private get; set; } //분
        public uint? Sec { private get; set; } //초
        public uint? Width { private get; set; } //화면해상도_가로
        public uint? Height { private get; set; } //화면해상도_세로
        public uint? Fps { private get; set; } //초당프레임
        public uint? AudioBitrate { private get; set; } //오디오비트레이트
        public Codecs Codec { private get; set; } //적용코덱
        #endregion


        #region 영상 비트레이트 Field
        public PersecUnit MaxBitrateUnit { private get; set; } //최대영상비트레이트 단위
        public decimal? MaxBitrate //최대영상비트레이트
        {
            get { return CalcBitrate(Width, Height, MaxBitrateUnit); }
        }
        public FilesizeUnit ExpectedOutputVidSizeUnit { private get; set; } //예상출력영상크기단위
        public decimal? ExpectedOutputVidSize //예상출력영상크기
        {
            get { return CalcCapacity(MaxBitrate, MaxBitrateUnit, ExpectedOutputVidSizeUnit); }
        }
        #endregion


        #region 출력 영상 크기 기준 영상 비트레이트 계산 Field
        public FilesizeUnit DesiredOutputVidSizeUnit { private get; set; } //원하는출력영상크기단위
        public uint? DesiredOutputVidSize { private get; set; } //원하는출력영상크기
        public PersecUnit DesiredOutputBitrateUnit { private get; set; } //예상영상비트레이트단위
        public decimal? DesiredOutputBitrate //출력영상크기기준 예상영상비트레이트
        {
            get
            {
                //출력 영상 크기 기준 예상 영상비트레이트를 계산해서 반환함
                //계산 필요조건 불충족시 null 반환
                if (!TotalSeconds.HasValue || TotalSeconds == 0) return null;
                if (!DesiredOutputVidSize.HasValue) return null;
                if (!AudioBitrate.HasValue) return null;

                decimal seconds = TotalSeconds.Value; //총 시간(초)
                uint desiredSize = DesiredOutputVidSize.Value; //원하는 출력영상 크기
                uint audBitrate = AudioBitrate.Value; //오디오 비트레이트

                int filesizeFactor = FilesizeUnitHelper.ToValue(DesiredOutputVidSizeUnit);
                int persecFactor = PersecUnitHelper.ToValue(DesiredOutputBitrateUnit) >> 10/*div by 1024*/;

                return Math.Max(0, (((desiredSize << 3/*mul by 8*/) * filesizeFactor / seconds) - audBitrate) / persecFactor);
            }
        }
        #endregion


        #region 해상도 변환 Field
        public ConvertResolutionBase ConvertResolutionBase { private get; set; } //변환기준단위
        public uint? ConvertResolutionSize { private get; set; } //변환기준
        public uint? ConvertedWidth //변환예상해상도_가로
        {
            get
            {
                switch(ConvertResolutionBase)
                {
                    case ConvertResolutionBase.Horizontal: return ConvertResolutionSize;
                    case ConvertResolutionBase.Vertical: return CalcConvertResolution(Height, Width);
                    default: throw new ArgumentException();
                }
            }
        }
        public uint? ConvertedHeight //변환예상해상도_세로
        {
            get
            {
                switch (ConvertResolutionBase)
                {
                    case ConvertResolutionBase.Horizontal: return CalcConvertResolution(Width, Height);
                    case ConvertResolutionBase.Vertical: return ConvertResolutionSize;
                    default: throw new ArgumentException();
                }
            }
        }
        public FilesizeUnit ConvertedVidSizeUnit { private get; set; } //변환예상 비디오 크기단위
        public decimal? ConvertedVidSize //변환예상 비디오 크기
        {
            get { return CalcCapacity(CalcBitrate(ConvertedWidth, ConvertedHeight, MaxBitrateUnit), MaxBitrateUnit, ConvertedVidSizeUnit); }
        }
        public const int ConvertedResolutionMaxRange = 9999;
        #endregion


        #region 비즈니스 로직
        private uint? TotalSeconds
        {
            get 
            { 
                if (!Hour.HasValue || !Min.HasValue || !Sec.HasValue) return null;
                return 3600 * Hour + 60 * Min + Sec; 
            }
        }

        //영상 비트레이트 계산
        private decimal? CalcBitrate(uint? width, uint? height, PersecUnit unit)
        {
            if (!width.HasValue) return null;
            if (!height.HasValue) return null;
            if (!Fps.HasValue) return null;

            decimal codecVal = CodecsHelper.ToValue(Codec);
            decimal persecFactor = PersecUnitHelper.ToValue(unit);

            return codecVal * width * height * Fps / persecFactor;
        }

        //영상 용량 계산
        private decimal? CalcCapacity(decimal? bitrate, PersecUnit bitrateUnit, FilesizeUnit filesizeUnit)
        {
            if (!TotalSeconds.HasValue) return null;
            if (!AudioBitrate.HasValue) return null;
            if (!bitrate.HasValue) return null;

            int bitrateFactor = PersecUnitHelper.ToValue(bitrateUnit) >> 10/*div by 1024*/;
            int filesizeFactor = FilesizeUnitHelper.ToValue(filesizeUnit);

            return (AudioBitrate + bitrate * bitrateFactor) / (filesizeFactor << 3/*mul by 8*/) * TotalSeconds;
        }

        //해상도 변환
        //baseSide가 ConvertResolutionSize로 변화할 때의 변화한 otherSide 값을 반환
        private uint? CalcConvertResolution(uint? baseSide, uint? otherSide)
        {
            if (!baseSide.HasValue || baseSide == 0) return null;
            if (!otherSide.HasValue) return null;
            if (!ConvertResolutionSize.HasValue) return null;

            //변화한 otherSide 값 계산
            decimal? convertedOtherSide = (decimal)otherSide * ConvertResolutionSize / baseSide;
            return (uint)Math.Round(convertedOtherSide ?? 0);
        }
        #endregion


        public BitrateCalculator()
        {
            Hour = null;
            Min = null;
            Sec = null;
            Width = null;
            Height = null;
            Fps = null;
            AudioBitrate = null;
            Codec = CodecsHelper.Default;

            MaxBitrateUnit = PersecUnitHelper.Default;
            ExpectedOutputVidSizeUnit = FilesizeUnitHelper.Default;

            DesiredOutputVidSizeUnit = FilesizeUnitHelper.Default;
            DesiredOutputVidSize = null;
            DesiredOutputBitrateUnit = PersecUnitHelper.Default;

            ConvertResolutionBase = ConvertResolutionBaseHelper.Default;
            ConvertResolutionSize = null;
            ConvertedVidSizeUnit = FilesizeUnitHelper.Default;
        }
    }
}
