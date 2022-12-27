using Appalonov_Exam.Connection;
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
using System.Windows.Shapes;

namespace Appalonov_Exam.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TName.Text !=null && TPassword.Text !=null && TPhone.Text != null)
            {
                MessageBox.Show("Добавленно!");
                //var adduser = new List<Users>(Connect.con.Users).ToList();
                //var add = Connection.Connect.con.Users.FirstOrDefault();
                //add.Name_User = TbName.Text;
                //add.id_Role = 5;
                //add.Password_User = TbPassword.Text;
                //add.Phone_User = TbPhone.Text;
                //adduser.Add(add);
                
            }
            else
            {
                MessageBox.Show("Заолните все поля!");
            }

        }
    }
}
