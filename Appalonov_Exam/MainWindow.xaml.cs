using Appalonov_Exam.Model;
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

using Appalonov_Exam.Connection;
using System.Windows.Interop;

namespace Appalonov_Exam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = new List<Users>(Connect.con.Users.ToList());
            var users = user.Where(z=>z.Name_User == TLogin.Text && z.Password_User == TPassword.Password).FirstOrDefault();
            if (users != null)
            {
                if (users.id_Role == 1)
                {
                    MessageBox.Show($"Привет {users.Name_User} {users.Roles.Name_Role}");
                    Windows.AdminWindow admin = new Windows.AdminWindow();
                    this.Close();
                    admin.ShowDialog();
                }
                if (users.id_Role == 2)
                {
                    MessageBox.Show($"Привет {users.Name_User} {users.Roles.Name_Role}");
                }
                if (users.id_Role == 3)
                {
                    MessageBox.Show($"Привет {users.Name_User} {users.Roles.Name_Role}");
                }
                if (users.id_Role == 4)
                {
                    MessageBox.Show($"Привет {users.Name_User} {users.Roles.Name_Role}");
                }
                if (users.id_Role == 5)
                {
                    MessageBox.Show($"Привет {users.Name_User} {users.Roles.Name_Role}");
                    Windows.ClientWindow client = new Windows.ClientWindow(users.id_User);
                    this.Close();
                    client.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Данный пользователь не найден!");
            }
        }
    }
}
