using System;

namespace Bitrate_Calculator.src
{
    public enum ConvertResolutionBase
    {
        Vertical, Horizontal
    }

    public class ConvertResolutionBaseHelper
    {
        public const ConvertResolutionBase Default = ConvertResolutionBase.Horizontal;

        public static string ToString(ConvertResolutionBase e)
        {
            switch (e)
            {
                case ConvertResolutionBase.Vertical: return "세로";
                case ConvertResolutionBase.Horizontal: return "가로";
            }

            throw new ArgumentException();
        }

        public static ConvertResolutionBase ToConvertResolutionBase(string e)
        {
            switch (e)
            {
                case "세로": return ConvertResolutionBase.Vertical;
                case "가로": return ConvertResolutionBase.Horizontal;
            }

            throw new ArgumentException();
        }


        public static decimal ToValue(ConvertResolutionBase e)
        {
            switch (e)
            {
                case ConvertResolutionBase.Vertical: 
                    return 0;
                case ConvertResolutionBase.Horizontal:
                    return 0;
            }
            throw new ArgumentException();
        }

        public static decimal ToValue(string s)
        {
            return ToValue(ToConvertResolutionBase(s));
        }
    }
}
