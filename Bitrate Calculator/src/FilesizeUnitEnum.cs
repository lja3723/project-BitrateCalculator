using System;

namespace Bitrate_Calculator.src
{
    public enum FilesizeUnit
    {
        MB, GB
    }

    public class FilesizeUnitHelper
    {
        public const FilesizeUnit Default = FilesizeUnit.MB;

        public static string ToString(FilesizeUnit e)
        {
            return Enum.GetName(typeof(FilesizeUnit), e);
        }

        public static FilesizeUnit ToFilesizeUnit(string e)
        {
            return (FilesizeUnit)Enum.Parse(typeof(FilesizeUnit), e);
        }


        public static int ToValue(FilesizeUnit e)
        {
            switch (e)
            {
                case FilesizeUnit.MB: return 1024;
                case FilesizeUnit.GB: return 1024 * 1024;
            }
            throw new ArgumentException();
        }

        public static decimal ToValue(string s)
        {
            return ToValue(ToFilesizeUnit(s));
        }
    }
}
