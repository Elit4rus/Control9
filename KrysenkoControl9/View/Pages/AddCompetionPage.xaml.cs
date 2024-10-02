using KrysenkoControl9.Model;
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
    /// Логика взаимодействия для AddCompetionPage.xaml
    /// </summary>
    public partial class AddCompetionPage : Page
    {
        public AddCompetionPage()
        {
            InitializeComponent();

            DirectionCmb.SelectedValuePath = "ID";
            DirectionCmb.DisplayMemberPath = "Name";
            DirectionCmb.ItemsSource = App.context.Direction.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrEmpty(CompetionTb.Text))
            {
                mes += "Введите название соревнования\n";
            }
            if (string.IsNullOrEmpty(DirectionCmb.Text))
            {
                mes += "Выберите вид соревнования\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            TypeCompetion typeCompetion = new TypeCompetion()
            {
                Name = CompetionTb.Text,
                Direction = DirectionCmb.SelectedItem as Direction
            };
            App.context.TypeCompetion.Add(typeCompetion);
            App.context.SaveChanges();
            MessageBox.Show("Соревнование добавлено");

            CompetionTb.Text = "";
            DirectionCmb.Text = "";
        }
    }
}
