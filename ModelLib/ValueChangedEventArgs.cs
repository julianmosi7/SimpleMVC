using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace ModelLib
{
    public class ValueChangedEventArgs : EventArgs
    {
        public double Val { get; set; }
        public int ColorVal { get; set; }
        public SolidColorBrush getColor {
            get
            {
                double green = 255 - ColorVal;
                SolidColorBrush br = new SolidColorBrush(Color.FromRgb(byte.Parse(green.ToString()), (byte)ColorVal, 0));
                return br;
            }
        }
}
}
