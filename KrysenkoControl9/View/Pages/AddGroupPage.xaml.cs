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
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        public AddGroupPage()
        {
            InitializeComponent();

            SpecializationCmb.SelectedValuePath = "ID";
            SpecializationCmb.DisplayMemberPath = "Name";
            SpecializationCmb.ItemsSource = App.context.Specialization.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrEmpty(GroupTb.Text))
            {
                mes += "Введите название группы\n";
            }
            if (string.IsNullOrEmpty(SpecializationCmb.Text))
            {
                mes += "Выберите специальность группы\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Group group = new Group()
            {
                Name = GroupTb.Text,
                Specialization = SpecializationCmb.SelectedItem as Specialization
            };
            App.context.Group.Add(group);
            App.context.SaveChanges();
            MessageBox.Show("Группа добавлена");

            GroupTb.Text = "";
            SpecializationCmb.Text = "";
        }
    }
}
