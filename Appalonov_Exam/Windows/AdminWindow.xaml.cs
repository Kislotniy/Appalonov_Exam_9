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

namespace Appalonov_Exam.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
        private void Refresh() 
        {
            ListPhones.ItemsSource = null;
            ListPhones.ItemsSource = Connection.Connect.con.Users.Where(z => z.id_Role ==5).ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Connection.Connect.con.SaveChanges();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }
    }
}
