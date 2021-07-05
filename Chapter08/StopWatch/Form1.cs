using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {
        Stopwatch sw = new Stopwatch();
        public Form1() {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }
        private void btStart_Click(object sender, EventArgs e) {
            sw.Start();
            tm.Tick += Tm_Tick1;
            tm.Interval = 1;
            tm.Start();
        }

        private void Tm_Tick1(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void btStop_Click(object sender, EventArgs e) {
            sw.Stop();
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void btRap_Click(object sender, EventArgs e) {
            lbxRaplist.Items = sw.ElapsedMilliseconds;
        }
    }
}
