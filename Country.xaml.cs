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
    /// Interaction logic for Country.xaml
    /// </summary>
  
    public partial class Country : Window
    {

        public Country()
        {
            InitializeComponent();
        }


        private void Azerbaijan_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/azerbaijan-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "AZERBEJDŽAN";
            NameOfCity.Text = "Baku";
        }
        private void Albania_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/albania-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "ALBANIJA";
            NameOfCity.Text = "Tirana";
        }
        private void Andora_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/andorra-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "ANDORA";
            NameOfCity.Text = "Andora la Velja";
        }
        private void Austria_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/austria-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "AUSTRIJA";
            NameOfCity.Text = "Beč";
        }
        private void Belgium_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/belgium-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "BELGIJA";
            NameOfCity.Text = "Brisel";
        }
        private void Belarus_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/belarus-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "BJELORUSIJA";
            NameOfCity.Text = "Minsk";
        }
        private void BiH_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/bosnia-and-herzegovina-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "BOSNA I HERCEGOVINA";
            NameOfCity.Text = "Sarajevo";
        }
        private void Bulgaria_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/bulgaria-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "BUGARSKA";
            NameOfCity.Text = "Sofija";
        }
        private void Vatican_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/vatican-city-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "VATIKAN";
            NameOfCity.Text = "Vatikan";
        }
        private void Georgia_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/georgia-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "GRUZIJA";
            NameOfCity.Text = "Tbilisi";
        }
        private void Greece_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/greece-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "GRČKA";
            NameOfCity.Text = "Atina";
        }
        private void Denmark_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/denmark-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "DANSKA";
            NameOfCity.Text = "Kopenhagen";
        }
        private void Estonia_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/estonia-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "ESTONIJA";
            NameOfCity.Text = "Talin";
        }
        private void Ireland_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/ireland-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "IRSKA";
            NameOfCity.Text = "Dablin";
        }
        private void Iceland_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/iceland-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "ISLAND";
            NameOfCity.Text = "Rejkjavik";
        }
        private void Italy_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/italy-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "ITALIJA";
            NameOfCity.Text = "Rim";
        }
        private void Armenia_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/armenia-flag-medium.jpg", UriKind.Relative));
            NameOfCountry.Text = "JERMENIJA";
            NameOfCity.Text = "Jerevan";
        }
        private void Cyprus_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/cyprus-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "KIPAR";
            NameOfCity.Text = "Nikozija";
        }
        private void Latvia_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/latvia-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "LETONIJA";
            NameOfCity.Text = "Riga";
        }
        private void Lithuania_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/lithuania-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "LITVANIJA";
            NameOfCity.Text = "Vilnjus";
        }
        private void Liechtenstein_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/liechtenstein-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "LIHTENŠTAJN";
            NameOfCity.Text = "Vaduc";
        }
        private void Luxembourg_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/luxembourg-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "LUKSEMBURG";
            NameOfCity.Text = "Luksemburg";
        }
        private void Hungary_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/hungary-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "MAĐARSKA";
            NameOfCity.Text = "Budimpešta";
        }
        private void Malta_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/malta-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "MALTA";
            NameOfCity.Text = "Valeta";
        }
        private void Moldova_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/moldova-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "MOLDAVIJA";
            NameOfCity.Text = "Kišinjev";
        }
        private void Monako_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/monaco-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "MONAKO";
            NameOfCity.Text = "Monako";
        }
        private void Netherlands_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/netherlands-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "NIZOZEMSKA";
            NameOfCity.Text = "Amsterdam";
        }
        private void Norwey_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/norway-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "NORVEŠKA";
            NameOfCity.Text = "Oslo";
        }
        private void Gemany_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/germany-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "NJEMAČKA";
            NameOfCity.Text = "Berlin";
        }
        private void Poland_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/poland-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "POLJSKA";
            NameOfCity.Text = "Varšava";
        }
        private void Portugal_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/portugal-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "PORTUGAL";
            NameOfCity.Text = "Lisabon";
        }
        private void Romania_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/romania-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "RUMUNIJA";
            NameOfCity.Text = "Bukurešt";
        }
        private void Russia_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/russia-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "RUSIJA";
            NameOfCity.Text = "Moskva";
        }
        private void San_Marino_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/san-marino-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "SAN MARINO";
            NameOfCity.Text = "San Marino";
        }
        private void Macedonia_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/north-macedonia-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "SJEVERNA MAKEDONIJA";
            NameOfCity.Text = "Skoplje";
        }
        private void Slovakia_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/slovakia-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "SLOVAČKA";
            NameOfCity.Text = "Bratislava";
        }
        private void Slovenia_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/slovenia-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "SLOVENIJA";
            NameOfCity.Text = "Ljubljana";
        }
        private void Serbia_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/serbia-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "SRBIJA";
            NameOfCity.Text = "Beograd";
        }
        private void Turkey_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/turkey-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "TURSKA";
            NameOfCity.Text = "Ankara";
        }
        private void UK_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/united-kingdom-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "UJEDINJENO KRALJEVSTVO";
            NameOfCity.Text = "London";
        }
        private void Ukraine_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/ukraine-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "UKRAJINA";
            NameOfCity.Text = "Kijev";
        }
        private void Finland_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/finland-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "FINSKA";
            NameOfCity.Text = "Helsinki";
        }
        private void France_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/france-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "FRANCUSKA";
            NameOfCity.Text = "Pariz";
        }
        private void Croatia_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/croatia-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "HRVATSKA";
            NameOfCity.Text = "Zagreb";
        }
        private void Montenegro_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/montenegro-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "CRNA GORA";
            NameOfCity.Text = "Podgorica";
        }
        private void Czech_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/czech-republic-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "ČEŠKA REPUBLIKA";
            NameOfCity.Text = "Prag";
        }
        private void Switzerland_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/switzerland-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "ŠVAJCARSKA";
            NameOfCity.Text = "Bern";
        }
        private void Sweden_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/sweden-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "ŠVEDSKA";
            NameOfCity.Text = "Stokholm";
        }
        private void Spain_MouseEnter(object sender, MouseEventArgs e)
        {
            Flag.Source = new BitmapImage(new Uri(@"image/spain-flag-small.jpg", UriKind.Relative));
            NameOfCountry.Text = "ŠPANIJA";
            NameOfCity.Text = "Madrid";
        }
 
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow objSecond = new SecondWindow();
            this.Visibility = Visibility.Hidden;
            objSecond.Show();
        }
    }
}