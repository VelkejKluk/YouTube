using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace YouTube{
    public partial class MainWindow : Window{
        public MainWindow(){
            InitializeComponent();
            
        }

        int check = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWin.Background = Brushes.Black;
            MainWin.Foreground = Brushes.White;
            butn1.Visibility = Visibility.Hidden;
            butn2.Visibility = Visibility.Visible;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWin.Background = Brushes.White;
            MainWin.Foreground = Brushes.Black;
            butn1.Visibility = Visibility.Visible;
            butn2.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (check == 0)
            {
                video1.LoadedBehavior = MediaState.Pause;
                video2.LoadedBehavior = MediaState.Pause;
                video3.LoadedBehavior = MediaState.Pause;
                video4.LoadedBehavior = MediaState.Pause;
                check = 1;
            }
            else if(check == 1)
            {
                video1.LoadedBehavior = MediaState.Play;
                video2.LoadedBehavior = MediaState.Play;
                video3.LoadedBehavior = MediaState.Play;
                video4.LoadedBehavior = MediaState.Play;
                check = 0;
            }

            
        }
    }
}