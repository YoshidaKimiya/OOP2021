
namespace Sotsug
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btOuter = new System.Windows.Forms.Button();
            this.btTops = new System.Windows.Forms.Button();
            this.btTrousers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dgvRegistData = new System.Windows.Forms.DataGridView();
            this.infosys202116DataSet = new Sotsug.infosys202116DataSet();
            this.clothingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clothingTableAdapter = new Sotsug.infosys202116DataSetTableAdapters.ClothingTableAdapter();
            this.ブランド名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ジャンルDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.カテゴリDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.色DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.サイズDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.写真DataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202116DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btOuter
            // 
            this.btOuter.Location = new System.Drawing.Point(12, 150);
            this.btOuter.Name = "btOuter";
            this.btOuter.Size = new System.Drawing.Size(163, 31);
            this.btOuter.TabIndex = 7;
            this.btOuter.Text = "アウター";
            this.btOuter.UseVisualStyleBackColor = true;
            // 
            // btTops
            // 
            this.btTops.Location = new System.Drawing.Point(12, 114);
            this.btTops.Name = "btTops";
            this.btTops.Size = new System.Drawing.Size(163, 30);
            this.btTops.TabIndex = 8;
            this.btTops.Text = "トップス";
            this.btTops.UseVisualStyleBackColor = true;
            // 
            // btTrousers
            // 
            this.btTrousers.Location = new System.Drawing.Point(12, 78);
            this.btTrousers.Name = "btTrousers";
            this.btTrousers.Size = new System.Drawing.Size(163, 30);
            this.btTrousers.TabIndex = 9;
            this.btTrousers.Text = "ズボン";
            this.btTrousers.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 22);
            this.button1.TabIndex = 14;
            this.button1.Text = "Beams";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 22);
            this.button2.TabIndex = 14;
            this.button2.Text = "champion";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 22);
            this.button3.TabIndex = 14;
            this.button3.Text = "NIKE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(395, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 22);
            this.button4.TabIndex = 14;
            this.button4.Text = "Levis";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(310, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 22);
            this.button5.TabIndex = 14;
            this.button5.Text = "Xlarge";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(395, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 22);
            this.button6.TabIndex = 14;
            this.button6.Text = "GU";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dgvRegistData
            // 
            this.dgvRegistData.AutoGenerateColumns = false;
            this.dgvRegistData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ブランド名DataGridViewTextBoxColumn,
            this.ジャンルDataGridViewTextBoxColumn,
            this.カテゴリDataGridViewTextBoxColumn,
            this.色DataGridViewTextBoxColumn,
            this.サイズDataGridViewTextBoxColumn,
            this.写真DataGridViewImageColumn});
            this.dgvRegistData.DataSource = this.clothingBindingSource;
            this.dgvRegistData.Location = new System.Drawing.Point(12, 202);
            this.dgvRegistData.Name = "dgvRegistData";
            this.dgvRegistData.RowTemplate.Height = 21;
            this.dgvRegistData.Size = new System.Drawing.Size(612, 170);
            this.dgvRegistData.TabIndex = 15;
            // 
            // infosys202116DataSet
            // 
            this.infosys202116DataSet.DataSetName = "infosys202116DataSet";
            this.infosys202116DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clothingBindingSource
            // 
            this.clothingBindingSource.DataMember = "Clothing";
            this.clothingBindingSource.DataSource = this.infosys202116DataSet;
            // 
            // clothingTableAdapter
            // 
            this.clothingTableAdapter.ClearBeforeFill = true;
            // 
            // ブランド名DataGridViewTextBoxColumn
            // 
            this.ブランド名DataGridViewTextBoxColumn.DataPropertyName = "ブランド名";
            this.ブランド名DataGridViewTextBoxColumn.HeaderText = "ブランド名";
            this.ブランド名DataGridViewTextBoxColumn.Name = "ブランド名DataGridViewTextBoxColumn";
            // 
            // ジャンルDataGridViewTextBoxColumn
            // 
            this.ジャンルDataGridViewTextBoxColumn.DataPropertyName = "ジャンル";
            this.ジャンルDataGridViewTextBoxColumn.HeaderText = "ジャンル";
            this.ジャンルDataGridViewTextBoxColumn.Name = "ジャンルDataGridViewTextBoxColumn";
            // 
            // カテゴリDataGridViewTextBoxColumn
            // 
            this.カテゴリDataGridViewTextBoxColumn.DataPropertyName = "カテゴリ";
            this.カテゴリDataGridViewTextBoxColumn.HeaderText = "カテゴリ";
            this.カテゴリDataGridViewTextBoxColumn.Name = "カテゴリDataGridViewTextBoxColumn";
            // 
            // 色DataGridViewTextBoxColumn
            // 
            this.色DataGridViewTextBoxColumn.DataPropertyName = "色";
            this.色DataGridViewTextBoxColumn.HeaderText = "色";
            this.色DataGridViewTextBoxColumn.Name = "色DataGridViewTextBoxColumn";
            // 
            // サイズDataGridViewTextBoxColumn
            // 
            this.サイズDataGridViewTextBoxColumn.DataPropertyName = "サイズ";
            this.サイズDataGridViewTextBoxColumn.HeaderText = "サイズ";
            this.サイズDataGridViewTextBoxColumn.Name = "サイズDataGridViewTextBoxColumn";
            // 
            // 写真DataGridViewImageColumn
            // 
            this.写真DataGridViewImageColumn.DataPropertyName = "写真";
            this.写真DataGridViewImageColumn.HeaderText = "写真";
            this.写真DataGridViewImageColumn.Name = "写真DataGridViewImageColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 384);
            this.Controls.Add(this.dgvRegistData);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btTrousers);
            this.Controls.Add(this.btTops);
            this.Controls.Add(this.btOuter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202116DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btOuter;
        private System.Windows.Forms.Button btTops;
        private System.Windows.Forms.Button btTrousers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dgvRegistData;
        private infosys202116DataSet infosys202116DataSet;
        private System.Windows.Forms.BindingSource clothingBindingSource;
        private infosys202116DataSetTableAdapters.ClothingTableAdapter clothingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ブランド名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ジャンルDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn カテゴリDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 色DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn サイズDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn 写真DataGridViewImageColumn;
    }
}

