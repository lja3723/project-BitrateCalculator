namespace Bitrate_Calculator.src
{
    public class ResultPrecisionManager
    {
        //영상 비트레이트 소수점 정밀도
        public uint BitratePrecision { get; set; }
        public string BitratePrecisionFormat
        {
            get { return GetFormatString(BitratePrecision); }
        }

        //용량 소수점 정밀도
        public uint CapacityPrecision { get; set; }
        public string CapacityPrecisionFormat 
        {
            get { return GetFormatString(CapacityPrecision); }
        }

        private string GetFormatString(uint n)
        {
            return "N" + n.ToString();
        }
    }
}
