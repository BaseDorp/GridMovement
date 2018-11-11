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

// Big thanks to Jethro for helping me debug the grid movement
// His github: https://github.com/JSchoppe

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
            if (img_Player.Margin.Left - pixelsPerUnit <= 450)
            {
                Thickness _margin = img_Player.Margin;
                img_Player.Margin = Translate(img_Player.Margin, new Vector(1, 0));
            }
        }
        public static int pixelsPerUnit = 59;

        public static Thickness Translate(Thickness toTranslate, Vector direction)
        {
            Thickness returnThickness = toTranslate;

            // Update the left margin.
            returnThickness.Left += direction.X * pixelsPerUnit;

            // Subtraction because of the Ydown canvas.
            returnThickness.Top -= direction.Y * pixelsPerUnit;

            return returnThickness;
        }

        private void bt_Left_Click(object sender, RoutedEventArgs e)
        {
            if (img_Player.Margin.Left - pixelsPerUnit >= 0)
            {
                Thickness _margin = img_Player.Margin;
                img_Player.Margin = Translate(img_Player.Margin, new Vector(-1, 0));
            }
        }

        private void bt_Down_Click(object sender, RoutedEventArgs e)
        {
            if (img_Player.Margin.Top - pixelsPerUnit <= 200)
            {
                Thickness _margin = img_Player.Margin;
                img_Player.Margin = Translate(img_Player.Margin, new Vector(0, -1));
            }
        }

        private void bt_Up_Click(object sender, RoutedEventArgs e)
        {
            if (img_Player.Margin.Top - pixelsPerUnit >= 0)
            {
                Thickness _margin = img_Player.Margin;
                img_Player.Margin = Translate(img_Player.Margin, new Vector(0, 1));
            }
        }
    }
}
