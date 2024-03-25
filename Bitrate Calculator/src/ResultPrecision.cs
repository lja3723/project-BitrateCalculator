namespace Bitrate_Calculator.src
{
    /// <summary>
    ///     결과 소수점 정밀도를 관리한다.
    /// </summary>
    public class ResultPrecision
    {
        //영상 비트레이트 소수점 정밀도
        public uint BitrateField { get; set; }
        public string BitrateFieldFormat
        {
            get { return GetFormatString(BitrateField); }
        }

        //용량 소수점 정밀도
        public uint CapacityField { get; set; }
        public string CapacityFieldFormat 
        {
            get { return GetFormatString(CapacityField); }
        }

        private string GetFormatString(uint n)
        {
            return "N" + n.ToString();
        }
    }
}
