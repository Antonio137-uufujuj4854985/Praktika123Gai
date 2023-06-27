using System;
using System.Collections.Generic;
using System.IO;
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

namespace Praktika123Gai
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        GaiBD_123Entities context;
        public MainWindow()
        {
            InitializeComponent();
            context = new GaiBD_123Entities();
            myFrame.Navigate(new Pages.Autorization(context));
        }

       
        
        
        
        // public void DownloadPictures()
       // {
         //   using (GaiBD_123Entities context = new GaiBD_123Entities())
         //   {

           //     foreach (var item in context.Car.ToList())
           //     {
            //        item.photo = File.ReadAllBytes($"C:/Car/{item.StateNumber}.jpg");
            //    }

              //  context.SaveChanges();

           // }

       // }

    }
}
