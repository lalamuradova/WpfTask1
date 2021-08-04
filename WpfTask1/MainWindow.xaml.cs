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

namespace WpfTask1
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            Color[] colors = new Color[]
            {
                  Colors.Red,
                  Colors.Blue,
                  Colors.Green,
                  Colors.Purple,
                  Colors.Aqua,
                  Colors.Crimson,
                  Colors.HotPink,
                  Colors.Lime,
                  Colors.Gold,
                  Colors.DarkViolet,
                  Colors.Turquoise,
                  Colors.LimeGreen,
                  Colors.Fuchsia,
                  Colors.LightCoral,
            };


            Button button = sender as Button;
            var color = colors[rand.Next(0, 14)];            
            button.Background = new SolidColorBrush(color);
            string text = "Button " + button.Content.ToString() + " Color code: " + color.ToString();

           MessageBox.Show(text);
        }

        private void btn1_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button button = sender as Button;
            Title = button.Content.ToString();
            
        }

    }
}
