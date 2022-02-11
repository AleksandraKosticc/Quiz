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
    /// Interaction logic for Level2.xaml
    /// </summary>
    public partial class Level2 : Window
    {
        string answer1 = null;
        string answer2 = null;
        string text = null;
        string image = null;
        int totalQuestion;
        int numberQuestion = 1;
        public static int numberCorrectQuestion = 0;
        int correctQuestion;
        List<string> list;
        Random rand = new Random();
        public static DispatcherTimer timer = new DispatcherTimer();
        public Level2()
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
            text = s.Split(';')[4];
       
            scoreText.Content = numberQuestion + "/" + totalQuestion;
            txtQuestion.Text = text;
            
            if (image == "portugal-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/portugal-flag-small.jpg", UriKind.Relative));
            else if (image == "finland-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/finland-flag-small.jpg", UriKind.Relative));
            else if (image == "iceland-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/iceland-flag-small.jpg", UriKind.Relative));
            else if (image == "poland-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/poland-flag-small.jpg", UriKind.Relative));
            else if (image == "ireland-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/ireland-flag-small.jpg", UriKind.Relative));
            else if (image == "lithuania-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/lithuania-flag-small.jpg", UriKind.Relative));
            else if (image == "malta-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/malta-flag-small.jpg", UriKind.Relative));
            else if (image == "bulgaria-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/bulgaria-flag-small.jpg", UriKind.Relative));
            else if (image == "slovakia-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/slovakia-flag-small.jpg", UriKind.Relative));
            else if (image == "luxembourg-flag")
                qImage.Source = new BitmapImage(new Uri(@"image/luxembourg-flag-small.jpg", UriKind.Relative));

            ans1.Content = answer1;
            ans2.Content = answer2;
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
            string[] unosi = File.ReadAllLines("da-ne.txt");
            list = unosi.ToList();

            totalQuestion = list.Count;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            RestartGame();
        }
    }
}