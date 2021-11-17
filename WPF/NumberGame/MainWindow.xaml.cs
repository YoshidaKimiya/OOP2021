using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>

   
    public partial class MainWindow : Window
    {
        int rand = 0;
        DispatcherTimer dispatcherTimer;
        DateTime StartTime;                 // カウント開始時刻
        TimeSpan nowtimespan;               // Startボタンが押されてから現在までの経過時間
        TimeSpan oldtimespan;
        public MainWindow()
        {
            InitializeComponent();
            ramdom(1,26);
            lblTime.Content = "00:00:000";
            // タイマーのインスタンスを生成
            dispatcherTimer = new DispatcherTimer(DispatcherPriority.Normal);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);

            // タイマー開始
            TimerStart();


        }
        public void ramdom(int min, int max)
        {
            //乱数を生成
            Random random = new Random();
            rand = random.Next(min,max);        
        }
        private void btClick(object sender, RoutedEventArgs e)
        {
            //色変換
            Button bt = e.Source as Button;
            bt.Background = Brushes.Red;
            
            //数字の判定
            if(rand == int.Parse((string)bt.Content))
            {
                judge.Text = "正解です";
                TimerStop();
                
            }
            else if(rand < int.Parse((string)bt.Content))
            {
                judge.Text = int.Parse((string)bt.Content) + "より小さい";
            }
            else if (rand > int.Parse((string)bt.Content))
            {
                judge.Text = int.Parse((string)bt.Content) + "より大きい";
            }
        
        }
        // タイマー Tick処理
        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            nowtimespan = DateTime.Now.Subtract(StartTime);
            lblTime.Content = oldtimespan.Add(nowtimespan).ToString(@"mm\:ss\:fff");
        }
            // タイマー操作：開始
            private void TimerStart()
        {
          
            StartTime = DateTime.Now;
            dispatcherTimer.Start();
        }

        // タイマー操作：停止
        private void TimerStop()
        {
            
            oldtimespan = oldtimespan.Add(nowtimespan);
            dispatcherTimer.Stop();
        }
    }
}
