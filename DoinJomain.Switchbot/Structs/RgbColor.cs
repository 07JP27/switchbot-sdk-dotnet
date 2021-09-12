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
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}
