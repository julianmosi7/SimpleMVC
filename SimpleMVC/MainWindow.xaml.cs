using ModelLib;
using System;
using System.Collections.Generic;
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

namespace SimpleMVC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ValueModel model = new ValueModel();

        public MainWindow()
        {
            InitializeComponent();
        }  

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            model.ValueChanged += Model_ValueChanged;
            model.MinVal = 10;
            model.MaxVal = 70;
            buttonlabel1.ChangeStep = 10;
            buttonlabel2.ChangeStep = 20;

            foreach (var control in panMain.Children)
            {
                if (control is UserControlLib.ButtonLabel buttonlabel) buttonlabel.Model = model;
            }
        }

        private void Model_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double val = e.Val;
            lblVal.Content = val;
        }

        private void slide_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            model.ColorVal = (int) e.NewValue;    
        }
    }
}
