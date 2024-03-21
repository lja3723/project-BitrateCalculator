using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrate_Calculator.src
{
    internal enum PersecUnit
    {
        Kbps, Mbps
    }

    internal class PersecUnitHelper
    {
        public const PersecUnit Default = PersecUnit.Kbps;

        public static string ToString(PersecUnit e)
        {
            return Enum.GetName(typeof(PersecUnit), e);
        }

        public static PersecUnit ToPersecUnit(string e)
        {
            return (PersecUnit)Enum.Parse(typeof(PersecUnit), e);
        }

        public static int ToValue(PersecUnit e)
        {
            switch (e)
            {
                case PersecUnit.Kbps:
                    return 1024;
                case PersecUnit.Mbps:
                    return 1024 * 1024;
            }
            throw new ArgumentException();
        }

        public static int ToValue(string s)
        {
            return ToValue(ToPersecUnit(s));
        }
    }
}
