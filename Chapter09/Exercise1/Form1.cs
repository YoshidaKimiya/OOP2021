﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if(ofdOpenFile.ShowDialog() == DialogResult.OK) {
                using (var reader = new StreamReader(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"))) {
                    int count = 0;
                    while (!reader.EndOfStream) {
                        
                        var line = reader.ReadLine(); // 1行読み込み
                        if (line.Contains(tbKeyword.Text))
                            count++;
                    }
                    tbOutput.Text = "キーワード「" + tbKeyword.Text + "」が含まれている行は、" + count.ToString() + "行です。";
                }
            }
        }

        private void btReadAllLines_Click(object sender, EventArgs e) {
            if(ofdOpenFile.ShowDialog() == DialogResult.OK) {
                int count = 0;
                var lines = File.ReadAllLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"));
                foreach(var line in lines) {
                    if (line.Contains(tbKeyword.Text))
                        count++;
                }
                tbOutput.Text = "キーワード「"+ tbKeyword.Text+"」が含まれている行は、"+count.ToString() + "行です。";
            }
        }

        private void btReadLines_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                int count = 0;
                var lines = File.ReadLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"));
                foreach (var line in lines) {
                    if (line.Contains(tbKeyword.Text))
                        count++;
                }
                tbOutput.Text = "キーワード「" + tbKeyword.Text + "」が含まれている行は、" + count.ToString() + "行です。";
            }
        }
    }
}
