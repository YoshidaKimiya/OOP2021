using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sotsug
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            cbBrand.Items.AddRange(new string[] { "levis" });
            cbGenre.Items.AddRange(new string[] { "アウター" });
            cbColor.Items.AddRange(new string[] { "青" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202116DataSet.Clothing' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.clothingTableAdapter.Fill(this.infosys202116DataSet.Clothing);
            // TODO: このコード行はデータを 'infosys202116DataSet.Clothing' テー

        }

        private void btSearch_Click_1(object sender, EventArgs e)
        {
            clothingTableAdapter.FillByBrand(infosys202116DataSet.Clothing, cbBrand.Text);
        }

        private void clothingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clothingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202116DataSet);

        }
    }
}
