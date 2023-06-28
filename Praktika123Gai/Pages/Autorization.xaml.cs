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
using System.Windows.Threading;

namespace Praktika123Gai.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {
        GaiBD_123Entities context;
        DispatcherTimer timer;
        public Autorization(GaiBD_123Entities cont)
        {
            InitializeComponent();
            context = cont;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 30);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            buttonEnter.IsEnabled = true;
            timer.Stop();
        }

        int countClick = 0;
        private void EnterClick(object sender, RoutedEventArgs e)
        {
            countClick++;
            string log = loginBox.Text;
            string pass = passwordBox.Text;
            User user = context.User.Find(log);
            //User u = context.User.ToList().Find(x  => x.age == 48);
            if (user != null )
            {
                if (user.password.Equals(pass))
                {
                    MessageBox.Show("Вы успешно авторизованы!!!");
                    countClick = 0;
                }
                else
                {
                    MessageBox.Show("Вы ввели неверный пароль!!!");
                    if (countClick>=3)
                    {
                        remeberBtn.Visibility= Visibility.Visible;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует!!!");
                if (countClick >= 3)
                {
                    remeberBtn.Visibility = Visibility.Visible;
                }
            }
        }

        private void RegistrationClick(object sender, RoutedEventArgs e)
        {
            // Registration regWindow = new Registration(context);
            // regWindow.Show();
            
            
        }

        private void RememberPassClick(object sender, RoutedEventArgs e)
        {
           
        }

    }
}
