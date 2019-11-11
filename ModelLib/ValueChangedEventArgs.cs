using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class ValueChangedEventArgs : EventArgs
    {
        public double Val { get; set; }
        public int ColorVal { get; set; }
    }
}
