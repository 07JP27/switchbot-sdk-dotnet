using System;
using System.Collections.Generic;
using System.Text;

namespace DoinJomain.Switchbot.Structs
{
    public struct RgbColor
    {
        public int Red { get; }
        public int Green { get; }
        public int Blue { get; }

        public RgbColor(int red, int green, int blue)
        {
            if (red < 0 || red > 255) throw new ArgumentOutOfRangeException(nameof(red));
            if (green < 0 || green > 255) throw new ArgumentOutOfRangeException(nameof(green));
            if (blue < 0 || blue > 255) throw new ArgumentOutOfRangeException(nameof(blue));
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}
