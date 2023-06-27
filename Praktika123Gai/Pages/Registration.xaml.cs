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

namespace Praktika123Gai.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        GaiBD_123Entities context;
        public Registration(GaiBD_123Entities cont)
        {
            InitializeComponent();
            context = cont;
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            Users user = new Users()
            {
                FIO = FIOBox.Text,
                password = passwordBox.Text,
                login = loginBox.Text,
                Tablnomer = Convert.ToInt32(TablnomerBox.Text),
                
            };
            context.Users.Add(user);
            context.SaveChanges();
            this.Close();
        }
    }
}
