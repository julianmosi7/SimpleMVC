using System;

namespace ModelLib
{
    public class ValueModel
    {
        public event EventHandler<ValueChangedEventArgs> ValueChanged;

        private double val;

        public double Val
        {
            get => val;
            set
            {
                val = value;
                ValueChanged?.Invoke(this, new ValueChangedEventArgs { Val = val });
            }
        }

    }
}
