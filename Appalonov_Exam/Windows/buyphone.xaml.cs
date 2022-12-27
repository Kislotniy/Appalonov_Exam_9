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
    /// Логика взаимодействия для buyphone.xaml
    /// </summary>
    public partial class buyphone : Window
    {
        int idclients;
        public buyphone(int id)
        {
            InitializeComponent();
            idclients= id;
            ListPhones.ItemsSource = null;
            ListPhones.ItemsSource = Connection.Connect.con.OrdersPhone.Where(z=>z.id_User == idclients).ToList();

        }
    }
}
