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

namespace _02_SimpleChat
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

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if (TBox1.Text != string.Empty)
            {
                TBlock1.Text += new string(' ', 50) + "Me: " + TBox1.Text + Environment.NewLine;
                TBlock2.Text += "User1: " + TBox1.Text + Environment.NewLine;
                TBox1.Text = string.Empty;
            }
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (TBox2.Text != string.Empty)
            {
                TBlock1.Text += "User2: " + TBox2.Text + Environment.NewLine;
                TBlock2.Text += new string(' ', 50) + "Me: " + TBox2.Text + Environment.NewLine;
                TBox2.Text = string.Empty;
            }
        }
    }
}
