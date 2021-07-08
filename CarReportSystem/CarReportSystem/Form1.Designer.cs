
namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissann = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSuparu = new System.Windows.Forms.RadioButton();
            this.rbImport = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.dgvRegistData = new System.Windows.Forms.DataGridView();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.btPicDelete = new System.Windows.Forms.Button();
            this.btDataADd = new System.Windows.Forms.Button();
            this.btDataCorrect = new System.Windows.Forms.Button();
            this.btDataDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.ofdPictureOpen = new System.Windows.Forms.OpenFileDialog();
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdFileSave = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "レポート：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "記事一覧：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "画像；";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Location = new System.Drawing.Point(84, 22);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(188, 19);
            this.dtpDateTime.TabIndex = 2;
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(82, 71);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(177, 20);
            this.cbAuthor.TabIndex = 3;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(82, 161);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(177, 20);
            this.cbCarName.TabIndex = 3;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(82, 205);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(381, 108);
            this.tbReport.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOther);
            this.groupBox1.Controls.Add(this.rbImport);
            this.groupBox1.Controls.Add(this.rbSuparu);
            this.groupBox1.Controls.Add(this.rbHonda);
            this.groupBox1.Controls.Add(this.rbNissann);
            this.groupBox1.Controls.Add(this.rbToyota);
            this.groupBox1.Location = new System.Drawing.Point(84, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 37);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(9, 15);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 0;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissann
            // 
            this.rbNissann.AutoSize = true;
            this.rbNissann.Location = new System.Drawing.Point(62, 15);
            this.rbNissann.Name = "rbNissann";
            this.rbNissann.Size = new System.Drawing.Size(47, 16);
            this.rbNissann.TabIndex = 0;
            this.rbNissann.TabStop = true;
            this.rbNissann.Text = "日産";
            this.rbNissann.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(117, 15);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 0;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSuparu
            // 
            this.rbSuparu.AutoSize = true;
            this.rbSuparu.Location = new System.Drawing.Point(174, 15);
            this.rbSuparu.Name = "rbSuparu";
            this.rbSuparu.Size = new System.Drawing.Size(52, 16);
            this.rbSuparu.TabIndex = 0;
            this.rbSuparu.TabStop = true;
            this.rbSuparu.Text = "スバル";
            this.rbSuparu.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            this.rbImport.AutoSize = true;
            this.rbImport.Location = new System.Drawing.Point(232, 15);
            this.rbImport.Name = "rbImport";
            this.rbImport.Size = new System.Drawing.Size(59, 16);
            this.rbImport.TabIndex = 0;
            this.rbImport.TabStop = true;
            this.rbImport.Text = "外国車";
            this.rbImport.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(297, 15);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 0;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(485, 57);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(286, 200);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 6;
            this.pbPicture.TabStop = false;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(26, 380);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(56, 32);
            this.btOpen.TabIndex = 7;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(26, 418);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(56, 32);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // dgvRegistData
            // 
            this.dgvRegistData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistData.Location = new System.Drawing.Point(96, 348);
            this.dgvRegistData.Name = "dgvRegistData";
            this.dgvRegistData.RowTemplate.Height = 21;
            this.dgvRegistData.Size = new System.Drawing.Size(674, 174);
            this.dgvRegistData.TabIndex = 8;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(557, 22);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(79, 18);
            this.btPictureOpen.TabIndex = 9;
            this.btPictureOpen.Text = "開く";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // btPicDelete
            // 
            this.btPicDelete.Location = new System.Drawing.Point(654, 22);
            this.btPicDelete.Name = "btPicDelete";
            this.btPicDelete.Size = new System.Drawing.Size(79, 18);
            this.btPicDelete.TabIndex = 9;
            this.btPicDelete.Text = "削除";
            this.btPicDelete.UseVisualStyleBackColor = true;
            // 
            // btDataADd
            // 
            this.btDataADd.Location = new System.Drawing.Point(490, 273);
            this.btDataADd.Name = "btDataADd";
            this.btDataADd.Size = new System.Drawing.Size(79, 40);
            this.btDataADd.TabIndex = 9;
            this.btDataADd.Text = "追加";
            this.btDataADd.UseVisualStyleBackColor = true;
            // 
            // btDataCorrect
            // 
            this.btDataCorrect.Location = new System.Drawing.Point(592, 273);
            this.btDataCorrect.Name = "btDataCorrect";
            this.btDataCorrect.Size = new System.Drawing.Size(79, 40);
            this.btDataCorrect.TabIndex = 9;
            this.btDataCorrect.Text = "修正";
            this.btDataCorrect.UseVisualStyleBackColor = true;
            // 
            // btDataDelete
            // 
            this.btDataDelete.Location = new System.Drawing.Point(691, 273);
            this.btDataDelete.Name = "btDataDelete";
            this.btDataDelete.Size = new System.Drawing.Size(79, 40);
            this.btDataDelete.TabIndex = 9;
            this.btDataDelete.Text = "削除";
            this.btDataDelete.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(26, 475);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(56, 32);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "終了";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // ofdPictureOpen
            // 
            this.ofdPictureOpen.FileName = "openFileDialog1";
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.btDataDelete);
            this.Controls.Add(this.btDataCorrect);
            this.Controls.Add(this.btDataADd);
            this.Controls.Add(this.btPicDelete);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.dgvRegistData);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbImport;
        private System.Windows.Forms.RadioButton rbSuparu;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbNissann;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView dgvRegistData;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button btPicDelete;
        private System.Windows.Forms.Button btDataADd;
        private System.Windows.Forms.Button btDataCorrect;
        private System.Windows.Forms.Button btDataDelete;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.OpenFileDialog ofdPictureOpen;
        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
        private System.Windows.Forms.SaveFileDialog sfdFileSave;
    }
}

