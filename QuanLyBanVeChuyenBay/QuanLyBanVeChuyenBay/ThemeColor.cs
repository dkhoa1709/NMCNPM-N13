using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeChuyenBay
{
    public static class ThemeColor
    {

        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>() { "#9BCCFE", "#004069", "#B2E2FF", "#74A6D6", "#6699C8" };

        public static Color ChangeColor(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
