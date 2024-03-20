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

    internal class PersecUnitConvert
    {
        public static string ToString(PersecUnit e)
        {
            return Enum.GetName(typeof(PersecUnit), e);
        }

        public static PersecUnit ToPersecUnit(string e)
        {
            return (PersecUnit)Enum.Parse(typeof(PersecUnit), e);
        }

        public static decimal ToValue(PersecUnit e)
        {
            switch (e)
            {
                case PersecUnit.Kbps:
                    return 0;
                case PersecUnit.Mbps:
                    return 0;
            }
            throw new ArgumentException();
        }

        public static decimal ToValue(string s)
        {
            return ToValue(ToPersecUnit(s));
        }
    }
}
