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

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for MyGrid.xaml
    /// </summary>
    public partial class MyGrid : Window
    {
        public MyGrid()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("0 is clicked!");
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1 is clicked!");
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("3 is clicked!");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("2 is clicked!");
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("4 is clicked!");
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("5 is clicked!");
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("6 is clicked!");
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("7 is clicked!");
        }
    }
}
