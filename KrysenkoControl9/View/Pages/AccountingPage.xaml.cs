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
    /// Логика взаимодействия для AccountingPage.xaml
    /// </summary>
    public partial class AccountingPage : Page
    {
        public AccountingPage()
        {
            InitializeComponent();
            SpecialityCmb.SelectedValuePath = "ID";
            SpecialityCmb.DisplayMemberPath = "Name";
            SpecialityCmb.ItemsSource = App.context.Specialization.ToList();

            StatusCmb.SelectedValuePath = "ID";
            StatusCmb.DisplayMemberPath = "Name";
            StatusCmb.ItemsSource = App.context.Direction.ToList();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            CompetionCmb.SelectedValuePath = "ID";
            CompetionCmb.DisplayMemberPath = "Name";
            CompetionCmb.ItemsSource = App.context.TypeCompetion.ToList();
        }

        private void AccountingDg_Loaded(object sender, RoutedEventArgs e)
        {
            AccountingDg.ItemsSource = App.context.Accounting.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrEmpty(SpecialityCmb.Text))
            {
                mes += "Выберите специальность\n";
            }
            if (string.IsNullOrEmpty(StatusCmb.Text))
            {
                mes += "Выберите статус соревнования\n";
            }
            if (string.IsNullOrEmpty(GroupCmb.Text))
            {
                mes += "Выберите группу\n";
            }
            if (string.IsNullOrEmpty(CompetionCmb.Text))
            {
                mes += "Выберите соревнование\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Accounting accounting = new Accounting()
            {
                DateGame = (DateTime)CompetionDp.SelectedDate,
                Group = GroupCmb.SelectedItem as Group,
                TypeCompetion = CompetionCmb.SelectedItem as TypeCompetion,
                Mark = Convert.ToDecimal(MarkTb.Text)
            };

            App.context.Accounting.Add(accounting);
            App.context.SaveChanges();
            MessageBox.Show("Оценка добавлена");

            CompetionDp.Text = "";
            SpecialityCmb.Text = "";
            StatusCmb.Text = "";
            GroupCmb.Text = "";
            CompetionCmb.Text = "";
            MarkTb.Text = "";
        }
    }
}
