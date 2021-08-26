using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample0823
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exec_Click(object sender, EventArgs e)
        {
           
            double va = double.Parse(Value.Text);
            double ex = double.Parse(jyou.Text);
            //for (int i = 0; i < ex; i++)
            //{
            //    result = result * va;
            
            //}
            Result.Text = Math.Pow(va,ex).ToString();


        }
    }
}
