using ModelLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserControlLib
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ButtonLabel : UserControl
    {
        public ButtonLabel()
        {
            InitializeComponent();
        }

        private ValueModel model;

        public ValueModel Model
        {
            get => model;
            set 
            {
                model = value;
                model.ValueChanged += Model_ValueChanged;
                model.ColorChanged += Model_ColorChanged;
            }
        }

        private void Model_ColorChanged(object sender, ValueChangedEventArgs e)
        {            
            Console.WriteLine(e.getColor);
            lblVal.Background = e.getColor;
        }

        [Category("Data"), Description("Change step")]
        public int ChangeStep
        {
            get => Int32.Parse(buttonUp.Content.ToString());
            set
            {
                buttonUp.Content = $"+{value}";
                buttonDown.Content = $"-{value}";
            }
        }

        private void Model_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.Val;            
            lblVal.Content = value;
        }

        private void buttonUp_Click(object sender, RoutedEventArgs e)
        {
            model.Val = model.Val + Int32.Parse(buttonUp.Content.ToString().Substring(1, buttonUp.Content.ToString().Length - 1));
        }

        private void buttonDown_Click(object sender, RoutedEventArgs e)
        {
            model.Val = model.Val - Int32.Parse(buttonUp.Content.ToString().Substring(1, buttonDown.Content.ToString().Length - 1));
        }
    }
}
