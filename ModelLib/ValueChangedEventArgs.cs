using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    class ValueChangedEventArgs : EventArgs
    {
        public double Val { get; set; }
    }
}
