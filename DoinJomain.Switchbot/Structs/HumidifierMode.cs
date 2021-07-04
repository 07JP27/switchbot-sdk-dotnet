using System;
using System.Collections.Generic;
using System.Text;

namespace DoinJomain.Switchbot.Structs
{
    public struct HumidifierMode
    {
        private static HumidifierMode s_auto = new HumidifierMode("auto");
        private static HumidifierMode s_101 = new HumidifierMode("101");
        private static HumidifierMode s_102 = new HumidifierMode("102");
        private static HumidifierMode s_103 = new HumidifierMode("103");
        public string Value { get; }

        HumidifierMode(string value)
        {
            Value = value;
        }

        public static HumidifierMode Percentage(int percentage)
        {
            if (percentage < 0 || percentage > 100) throw new ArgumentOutOfRangeException(nameof(percentage));
            return new HumidifierMode(percentage.ToString());
        }
        public static HumidifierMode Auto => s_auto;
        public static HumidifierMode Percent34 => s_101;
        public static HumidifierMode Percent67 => s_102;
        public static HumidifierMode Percent100 => s_103;
    }
}
