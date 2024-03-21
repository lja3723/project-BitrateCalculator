using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrate_Calculator.src
{
    public class ResultPrecisionManager
    {
        #region SetDecimalPoint 관련 메서드 (모듈화 필요)

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

        //문자열 실수 숫자에 콤마 제거
        private string RemoveDigitSeparator(string number)
        {
            string tmpString = number;
            tmpString = tmpString.Replace(",", "");
            return tmpString;
        }
        #endregion

    }
}
