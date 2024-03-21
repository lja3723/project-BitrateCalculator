using System;

namespace Bitrate_Calculator.src
{
    public enum Codecs
    {
        H263,   //H.263
        H264,   //H.264
        X264,   //X264 
        MPEG4,  //MPEG-4
        MPEG2,  //MPEG-2
        Xvid,   //Xvid
        DivX    //DivX
    }

    public static class CodecsHelper
    {
        public const Codecs Default = Codecs.H263;

        public static string ToString(Codecs codecs)
        {
            switch(codecs)
            {
                case Codecs.H263: return "H.263";
                case Codecs.H264: return "H.264";
                case Codecs.X264: return "X264";
                case Codecs.MPEG4: return "MPEG-4";
                case Codecs.MPEG2: return "MPEG-2";
                case Codecs.Xvid: return "Xvid";
                case Codecs.DivX: return "DivX";
            }
            throw new ArgumentException();
        }

        public static Codecs ToCodecs(string codecs)
        {
            switch (codecs)
            {
                case "H.263": return Codecs.H263;
                case "H.264": return Codecs.H264;
                case "X264": return Codecs.X264;
                case "MPEG-4": return Codecs.MPEG4;
                case "MPEG-2": return Codecs.MPEG2;
                case "Xvid": return Codecs.Xvid;
                case "DivX": return Codecs.DivX;
            }
            throw new ArgumentException();
        }


        public static decimal ToValue(Codecs codecs)
        {
            switch (codecs)
            {
                case Codecs.H263:
                case Codecs.H264:
                case Codecs.X264:
                case Codecs.MPEG4:
                    return 0.17m;
                case Codecs.MPEG2:
                case Codecs.Xvid:
                case Codecs.DivX:
                    return 0.27m;
            }
            throw new ArgumentException();
        }

        public static decimal ToValue(string codecs)
        {
            return ToValue(ToCodecs(codecs));
        }
    }
}
