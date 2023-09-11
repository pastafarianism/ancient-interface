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

namespace ancientDee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter = 0;
        int counter2 = 0;
        int counter3 = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GreenSquare_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GreenSquare_PreviewMouseLeftButtonDown(sender, e, greenSquareCounter);
        }

        private void GreenSquare_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e, Label greenSquareCounter)
        {
            counter3++;
            greenSquareCounter.Content = counter3.ToString();
        }

        private void closer_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void YellowRhombus_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            counter2++;
            yellowRhombusCounter.Content = counter2.ToString();
        }

        private void BlueSquare_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            counter++;
            blueSquareCounter.Content = counter .ToString();

        }
    }
}