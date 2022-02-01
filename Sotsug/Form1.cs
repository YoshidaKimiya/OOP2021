using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sotsug
{
    public partial class Form1 : Form
    {
        BindingList<Clothing> listClothing = new BindingList<Clothing>();
        public Form1()
        {
            InitializeComponent();
            dgvRegistData.DataSource = listClothing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202116DataSet.Clothing' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clothingTableAdapter.Fill(this.infosys202116DataSet.Clothing);

        }
    }
}
