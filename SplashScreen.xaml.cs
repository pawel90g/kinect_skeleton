using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Microsoft.Samples.Kinect.SkeletonBasics
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {

        private MediaPlayer mediaPlayer;
        public SplashScreen()
        {
            InitializeComponent();
            
            FileInfo mp3File = new FileInfo("1.mp3");
            if (mp3File.Exists)
            {
                mediaPlayer = new MediaPlayer();
                mediaPlayer.MediaEnded += mediaPlayer_MediaEnded;
                mediaPlayer.Open(new Uri(mp3File.FullName));
                mediaPlayer.Play();
            }

        }

        void mediaPlayer_MediaEnded(object sender, EventArgs e)
        {
            mediaPlayer.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
