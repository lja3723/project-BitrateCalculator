using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrate_Calculator.src
{
    internal enum FilesizeUnit
    {
        MB, GB
    }

    internal class FilesizeConvert
    {
        public static string ToString(FilesizeUnit e)
        {
            return Enum.GetName(typeof(FilesizeUnit), e);
        }

        public static FilesizeUnit ToFilesizeUnit(string e)
        {
            return (FilesizeUnit)Enum.Parse(typeof(FilesizeUnit), e);
        }


        public static decimal ToValue(Enum e)
        {
            switch (e)
            {
                case FilesizeUnit.MB:
                    return 0;
                case FilesizeUnit.GB:
                    return 0;
            }
            throw new ArgumentException();
        }

        public static decimal ToValue(string s)
        {
            return ToValue(ToFilesizeUnit(s));
        }
    }
}
