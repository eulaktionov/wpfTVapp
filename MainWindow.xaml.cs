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

namespace TVapp
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

        void powerChecked(object sender, RoutedEventArgs e)
        {
            play.IsEnabled = true;
        }

        void powerUnchecked(object sender, RoutedEventArgs e)
        {
            video.Close();

            play.IsChecked = false;
            pause.IsChecked = false;
            stop.IsChecked = false;

            play.IsEnabled = false;
            pause.IsEnabled = false;
            stop.IsEnabled = false;
        }

        void playChecked(object sender, RoutedEventArgs e)
        {
            video.Play();
            pause.IsEnabled = true;
            stop.IsEnabled = true;
        }

        void pauseChecked(object sender, RoutedEventArgs e)
        {
            video.Pause();
        }
        void stopChecked(object sender, RoutedEventArgs e)
        {
            video.Close();
            pause.IsEnabled = false;
        }
    }
}
