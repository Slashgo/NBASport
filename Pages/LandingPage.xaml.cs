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

namespace NBAsport.Pages
{
    /// <summary>
    /// Логика взаимодействия для LandingPage.xaml
    /// </summary>
    public partial class LandingPage : Page
    {
        MainWindow main = new MainWindow();
        public LandingPage()
        {
            InitializeComponent();
        }

        private void Visitor_Click(object sender, RoutedEventArgs e)
        {
            main.Nav.Source = new Uri("Pages/TeamsPage.xaml",UriKind.Relative);
        }


    }
}
