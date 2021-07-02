using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //フォームがロードされるタイミングで1回だけ実行される
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            inputStrData.Text = "Novelist = 谷崎潤一郎; BestWork = 春琴抄; Born = 1886";
        }

        private void button5_3_1_Click(object sender, EventArgs e) {
            var count = inputStrText.Text.Count(c => c == ' ');

            TextBoxSpaceCount.Text = count.ToString();
        }

        private void button5_3_2_Click(object sender, EventArgs e) {
            TextBoxWordChange.Text = inputStrText.Text.Replace("big", "small");
        }

        private void button5_3_3_Click(object sender, EventArgs e) {
            inputStrText.Text.Split(' ').Length.ToString();
        }

        private void button5_3_4_Click(object sender, EventArgs e) {
            var items = inputStrText.Text.Split(' ').Where(n => n.Length <= 4);
            foreach (var item in items) {
                TextBoxForLengthWord.Text += item+' ';
            }
            
        }

        private void button5_3_5_Click(object sender, EventArgs e) {
            var items = inputStrText.Text.Split(' ');
            var sb = new StringBuilder();
            foreach (var item in items) {
                sb.Append(item + ' ');
            }
            TextBoxRepairWord.Text = sb.ToString();
        }

        private void button5_4_Click(object sender, EventArgs e) {
            foreach (var pair in inputStrData.Text.Split(';')) {
                var array = pair.Split('=');
                outputstrData.Text += ToJapanese(array[0]) + ":" + array[1] + "\r\n";
            }

         
        }
        private string ToJapanese (string key) {
            switch (key) {
                case "Novelist":
                    return "作家";

                case "BestWork":
                    return "代表作";

                case "Born":
                    return "誕生年";

                
            }
            throw new ArgumentException("引数が正しくありません。");
        }
    }
}
