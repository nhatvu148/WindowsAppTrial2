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

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Hello, " + TxtName.Text, "Greeting",
                MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);

           
        }

        private void button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.C)
            {
                MessageBox.Show("What is it?");
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MyGrid mg = new MyGrid();
            mg.Show();
        }
    }
}
