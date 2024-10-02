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

namespace KrysenkoControl9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClassFrame.FrameBody = FrameMainBody;
            FrameMainBody.Navigate(new View.Pages.PicturesPage());

            ClassFrame.FrameMenu = FrameMainMenu;
            FrameMainMenu.Navigate(new View.Pages.MenuPage());
        }
    }
}
