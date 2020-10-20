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

namespace _29.RadioButton_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rb_Click(object sender, RoutedEventArgs e)
        {
            if (rbRed.IsChecked == true)
            { 
               

                Red.Visibility = Visibility.Visible ;

                Yellow.Visibility = Visibility.Hidden;
                Green.Visibility = Visibility.Hidden;


            }

            if (rbYellow.IsChecked == true)
            {


                Yellow.Visibility = Visibility.Visible;
                Red.Visibility = Visibility.Hidden;
                Green.Visibility = Visibility.Hidden;
            }

            if (rbGreen.IsChecked == true)
            {


                Green.Visibility = Visibility.Visible;

                Yellow.Visibility = Visibility.Hidden;
                Red.Visibility = Visibility.Hidden;
            }
        }

    




    }
}
