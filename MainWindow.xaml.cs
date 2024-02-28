using Microsoft.Win32;
using System.Windows;

namespace YouTube{
    public partial class MainWindow : Window{
        public MainWindow(){
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();


            if (play.Content.ToString() == "Play")
            {
                video1.Play();
                play.Content = "Pause";
            }
            else
            {
                video1.Pause();
                play.Content = "Play";
            }
        }
    }
}