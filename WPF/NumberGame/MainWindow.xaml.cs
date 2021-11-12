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

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        int rand = 0;
        public MainWindow()
        {
            InitializeComponent();
            ramdom(1,26);

        }
        public void ramdom(int min, int max)
        {
            Random random = new Random();
            rand = random.Next(min,max);        
        }
        private void btClick(object sender, RoutedEventArgs e)
        {
            Button bt = e.Source as Button;
            bt.Background = Brushes.Red;
            
            
            if(rand == int.Parse((string)bt.Content))
            {
                judge.Text = "正解です";
            }
            else if(rand < int.Parse((string)bt.Content))
            {
                judge.Text = "小さい";
            }
            else if (rand > int.Parse((string)bt.Content))
            {
                judge.Text = "大きい";
            }
        }
    }
}
