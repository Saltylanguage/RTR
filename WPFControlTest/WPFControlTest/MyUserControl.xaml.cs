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

namespace WPFControlTest
{
    /// <summary>
    /// Interaction logic for MyUserControl.xaml
    /// </summary>
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        private void colorPicker_1_ValueChanged(object sender, RoutedEventArgs e)
        {

            Color adjustedColor = colorPicker_1.SelectedColor.GetValueOrDefault();
            colorPicker_1.Background = new SolidColorBrush(adjustedColor);
            Redvalue.Text = adjustedColor.R.ToString();
            GreenValue.Text = adjustedColor.G.ToString();
            BlueValue.Text = adjustedColor.B.ToString();
            AlphaValue.Text = adjustedColor.A.ToString();
            //colorPicker_1.Background = new SolidColorBrush(colorPicker_1.SelectedColor.GetValueOrDefault());

            //Redvalue.Text
        }

        private void RedValue_TextChanged(object sender, TextChangedEventArgs e)
        {

            Color myColor = colorPicker_1.SelectedColor.GetValueOrDefault();

            if (Redvalue.Text != null)
            {
                myColor.R = Convert.ToByte(Redvalue.Text);
                colorPicker_1.SelectedColor = myColor;
            }
        }

        private void GreenValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            Color myColor = colorPicker_1.SelectedColor.GetValueOrDefault();

            if (Redvalue.Text != null)
            {
                myColor.G = Convert.ToByte(GreenValue.Text);
                colorPicker_1.SelectedColor = myColor;
            }
        }

        private void BlueValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            Color myColor = colorPicker_1.SelectedColor.GetValueOrDefault();

            if (Redvalue.Text != null)
            {
                myColor.B = Convert.ToByte(BlueValue.Text);
                colorPicker_1.SelectedColor = myColor;
            }
        }

        private void AlphaValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            Color myColor = colorPicker_1.SelectedColor.GetValueOrDefault();

            if (Redvalue.Text != null)
            {
                myColor.A = Convert.ToByte(AlphaValue.Text);
                colorPicker_1.SelectedColor = myColor;
            }
        }
    }
}
