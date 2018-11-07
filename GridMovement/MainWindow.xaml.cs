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

namespace GridMovement
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

        private void bt_Right_Click(object sender, RoutedEventArgs e)
        {
            Thickness _margin = img_Player.Margin;
            img_Player.Margin = new Thickness(0, 0, 125, 0);
        }

        private void bt_Left_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void bt_Down_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_Up_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
