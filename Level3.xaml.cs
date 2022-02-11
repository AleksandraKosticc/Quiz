using System;
using System.Collections.Generic;
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
    /// Interaction logic for Level3.xaml
    /// </summary>
    public partial class Level3 : Window
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

        public Level3()
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

            if (image == "vatican-city-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/vatican-city-flag-small.jpg", UriKind.Relative));
            else if (image == "belarus-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/belarus-flag-small.jpg", UriKind.Relative));
            else if (image == "czech-republic-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/czech-republic-flag-small.jpg", UriKind.Relative));
            else if (image == "denmark-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/denmark-flag-small.jpg", UriKind.Relative));
            else if (image == "netherlands-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/netherlands-flag-small.jpg", UriKind.Relative));
            else if (image == "romania-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/romania-flag-small.jpg", UriKind.Relative));
            else if (image == "bosnia-and-herzegovina-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/bosnia-and-herzegovina-flag-small.jpg", UriKind.Relative));
            else if (image == "belgium-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/belgium-flag-small.jpg", UriKind.Relative));
            else if (image == "serbia-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/serbia-flag-small.jpg", UriKind.Relative));
            else if (image == "georgia-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/georgia-flag-small.jpg", UriKind.Relative));

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
            else if(heart1.Visibility == Visibility.Collapsed &&
                    heart2.Visibility == Visibility.Visible &&
                    heart3.Visibility == Visibility.Visible)
                        heart2.Visibility = Visibility.Collapsed;
            else if(heart1.Visibility == Visibility.Collapsed &&
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
            string[] unosi = File.ReadAllLines("glavnigradovi.txt");
            list = unosi.ToList();

            totalQuestion = list.Count;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            RestartGame();
        }
    }
}