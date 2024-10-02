using KrysenkoControl9.Class;
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

namespace KrysenkoControl9.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }


        private void GroupHl_Click(object sender, RoutedEventArgs e)
        {
            // Открываем страницу AddGroupPage.xaml
            ClassFrame.FrameBody.Navigate(new View.Pages.AddGroupPage());
        }

        private void CompetionHl_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.AddCompetionPage());
        }

        private void AccountingHl_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.AccountingPage());
        }
    }
}
