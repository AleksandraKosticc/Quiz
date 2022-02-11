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
using System.Windows.Shapes;

namespace Kviz
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }

        private void OpenLevel1(object sender, RoutedEventArgs e)
        {
            Level1 objLevel1 = new Level1();
            this.Visibility = Visibility.Hidden;
            objLevel1.Show();
        }

        private void OpenLevel2(object sender, RoutedEventArgs e)
        {
            Level2 objLevel2 = new Level2();
            this.Visibility = Visibility.Hidden;
            objLevel2.Show();
        }

        private void OpenLevel3(object sender, RoutedEventArgs e)
        {
            Level3 objLevel3 = new Level3();
            this.Visibility = Visibility.Hidden;
            objLevel3.Show();
        }

        private void OpenCountry(object sender, RoutedEventArgs e)
        {
            Country objCountry = new Country();
            this.Visibility = Visibility.Hidden;
            objCountry.Show();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}