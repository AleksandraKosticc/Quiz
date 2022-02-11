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
    /// Interaction logic for SecondMessage.xaml
    /// </summary>
    public partial class SecondMessage : Window
    {
        public SecondMessage()
        {
            InitializeComponent();

            picture.Source = new BitmapImage(new Uri("image/ostalo/happy-face.png", UriKind.Relative));
        }
    }
}