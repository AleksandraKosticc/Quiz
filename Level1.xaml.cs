using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Kviz
{
    /// <summary>
    /// Interaction logic for Level1.xaml
    /// </summary>
    public partial class Level1 : Window
    {
        string answer1 = null;
        string answer2 = null;
        string answer3 = null;
        string answer4 = null;
        string image = null;
        int totalQuestion;
        int numberQuestion = 1;
        public static int numberCorrectQuestion = 0;
        int correctQuestion;
        List<string> list;
        Random rand = new Random();
        public static DispatcherTimer timer = new DispatcherTimer();
        public Level1()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            InitializeComponent();
            StartGame();
            NextQuestion();
        }

        private int increment = 60;
        void Timer_Tick(object sender, EventArgs e)
        {
            if (increment > 0)
            {
                increment--;
                TimerLabel.Content = increment.ToString();
            }
            else
            {
                timer.Stop();
                new Message().ShowDialog();
                this.Close();
                RestartGame();
            }
        }

        private void NextQuestion()
        {
            int i = rand.Next(1, list.Count) - 1;
            string s = list.ElementAt(i);
            image = s.Split(';')[0];
            correctQuestion = Int32.Parse(s.Split(';')[1]);
            answer1 = s.Split(';')[2];
            answer2 = s.Split(';')[3];
            answer3 = s.Split(';')[4];
            answer4 = s.Split(';')[5];

            scoreText.Content = numberQuestion + "/" + totalQuestion;

            if (image == "austria-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/austria-flag-small.jpg", UriKind.Relative));
            else if (image == "monaco-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/monaco-flag-small.jpg", UriKind.Relative));
            else if (image == "sweden-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/sweden-flag-small.jpg", UriKind.Relative));
            else if (image == "hungary-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/hungary-flag-small.jpg", UriKind.Relative));
            else if (image == "italy-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/italy-flag-small.jpg", UriKind.Relative));
            else if (image == "norway-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/norway-flag-small.jpg", UriKind.Relative));
            else if (image == "slovenia-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/slovenia-flag-small.jpg", UriKind.Relative));
            else if (image == "germany-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/germany-flag-small.jpg", UriKind.Relative));
            else if (image == "montenegro-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/montenegro-flag-small.jpg", UriKind.Relative));
            else if (image == "france-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/france-flag-small.jpg", UriKind.Relative));

            ans1.Content = answer1;
            ans2.Content = answer2;
            ans3.Content = answer3;
            ans4.Content = answer4;
            list.RemoveAt(i);
        }

        private void CheckAnswer1(object sender, RoutedEventArgs e)
        {
            if (correctQuestion == 1)
            {
                numberCorrectQuestion++;
                numberQuestion++;
                if (numberQuestion <= totalQuestion)
                    NextQuestion();
                else
                {
                    timer.Stop();
                    new SecondMessage().ShowDialog();
                    this.Close();
                    RestartGame();
                }
            }
            else if (heart1.Visibility == Visibility.Visible &&
                    heart2.Visibility == Visibility.Visible &&
                    heart3.Visibility == Visibility.Visible)
                heart1.Visibility = Visibility.Collapsed;
            else if (heart1.Visibility == Visibility.Collapsed &&
                    heart2.Visibility == Visibility.Visible &&
                    heart3.Visibility == Visibility.Visible)
                heart2.Visibility = Visibility.Collapsed;
            else if (heart1.Visibility == Visibility.Collapsed &&
                    heart2.Visibility == Visibility.Collapsed &&
                    heart3.Visibility == Visibility.Visible)
            {
                heart3.Visibility = Visibility.Collapsed;
                timer.Stop();
                new Message().ShowDialog();
                this.Close();
                RestartGame();
            }
        }

        private void CheckAnswer2(object sender, RoutedEventArgs e)
        {
            if (correctQuestion == 2)
            {
                numberCorrectQuestion++;
                numberQuestion++;
                if (numberQuestion <= totalQuestion)
                    NextQuestion();
                else
                {
                    timer.Stop();
                    new SecondMessage().ShowDialog();
                    this.Close();
                    RestartGame();
                }
            }
            else if (heart1.Visibility == Visibility.Visible &&
                    heart2.Visibility == Visibility.Visible &&
                    heart3.Visibility == Visibility.Visible)
                heart1.Visibility = Visibility.Collapsed;
            else if (heart1.Visibility == Visibility.Collapsed &&
                    heart2.Visibility == Visibility.Visible &&
                    heart3.Visibility == Visibility.Visible)
                heart2.Visibility = Visibility.Collapsed;
            else if (heart1.Visibility == Visibility.Collapsed &&
                    heart2.Visibility == Visibility.Collapsed &&
                    heart3.Visibility == Visibility.Visible)
            {
                heart3.Visibility = Visibility.Collapsed;
                timer.Stop();
                new Message().ShowDialog();
                this.Close();
                RestartGame();
            }
        }

        private void CheckAnswer3(object sender, RoutedEventArgs e)
        {
            if (correctQuestion == 3)
            {
                numberCorrectQuestion++;
                numberQuestion++;
                if (numberQuestion <= totalQuestion)
                    NextQuestion();
                else
                {
                    timer.Stop();
                    new SecondMessage().ShowDialog();
                    this.Close();
                    RestartGame();
                }
            }
            else if (heart1.Visibility == Visibility.Visible &&
                    heart2.Visibility == Visibility.Visible &&
                    heart3.Visibility == Visibility.Visible)
                heart1.Visibility = Visibility.Collapsed;
            else if (heart1.Visibility == Visibility.Collapsed &&
                    heart2.Visibility == Visibility.Visible &&
                    heart3.Visibility == Visibility.Visible)
                heart2.Visibility = Visibility.Collapsed;
            else if (heart1.Visibility == Visibility.Collapsed &&
                    heart2.Visibility == Visibility.Collapsed &&
                    heart3.Visibility == Visibility.Visible)
            {
                heart3.Visibility = Visibility.Collapsed;
                timer.Stop();
                new Message().ShowDialog();
                this.Close();
                RestartGame();
            }
        }

        private void CheckAnswer4(object sender, RoutedEventArgs e)
        {
            if (correctQuestion == 4)
            {
                numberCorrectQuestion++;
                numberQuestion++;
                if (numberQuestion <= totalQuestion)
                    NextQuestion();
                else
                {
                    timer.Stop();
                    new SecondMessage().ShowDialog();
                    this.Close();
                    RestartGame();
                }
            }
            else if (heart1.Visibility == Visibility.Visible &&
                    heart2.Visibility == Visibility.Visible &&
                    heart3.Visibility == Visibility.Visible)
                heart1.Visibility = Visibility.Collapsed;
            else if (heart1.Visibility == Visibility.Collapsed &&
                    heart2.Visibility == Visibility.Visible &&
                    heart3.Visibility == Visibility.Visible)
                heart2.Visibility = Visibility.Collapsed;
            else if (heart1.Visibility == Visibility.Collapsed &&
                    heart2.Visibility == Visibility.Collapsed &&
                    heart3.Visibility == Visibility.Visible)
            {
                heart3.Visibility = Visibility.Collapsed;
                timer.Stop();
                new Message().ShowDialog();
                this.Close();
                RestartGame();
            }
        }

        private void RestartGame()
        {
            numberCorrectQuestion = 0;
            increment = 60;

            SecondWindow objSecondWindow = new SecondWindow();
            this.Visibility = Visibility.Hidden;
            objSecondWindow.Show();
        }

        private void StartGame()
        {
            string[] unosi = File.ReadAllLines("drzave.txt");
            list = unosi.ToList();

            totalQuestion = list.Count;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            RestartGame();
        }
    }
}