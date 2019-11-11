using System;
using System.Windows.Media;

namespace ModelLib
{
    public class ValueModel
    {
        public event EventHandler<ValueChangedEventArgs> ValueChanged;
        public event EventHandler<ValueChangedEventArgs> ColorChanged;

        private double val = 10;

        public double Val
        {
            get => val;
            set
            {
                if (value <= MaxVal && value >= MinVal)
                {
                    val = value;
                    ValueChanged?.Invoke(this, new ValueChangedEventArgs { Val = val });
                }
            }
        }

        public int MinVal { get; set; } = 10;
        public int MaxVal { get; set; } = 70;

        private int colorval;

        public int ColorVal
        {
            get => colorval;
            set 
            {
                colorval = value;
                ColorChanged?.Invoke(this, new ValueChangedEventArgs { ColorVal = colorval });
            }
        }

        public int MinColor { get; set; }
        public int MaxColor { get; set; }              
        
    }
}
