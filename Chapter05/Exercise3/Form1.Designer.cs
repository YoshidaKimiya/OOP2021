
namespace Exercise3 {
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
            this.inputStrText = new System.Windows.Forms.TextBox();
            this.button5_3_1 = new System.Windows.Forms.Button();
            this.TextBoxSpaceCount = new System.Windows.Forms.TextBox();
            this.button5_3_2 = new System.Windows.Forms.Button();
            this.TextBoxWordChange = new System.Windows.Forms.TextBox();
            this.button5_3_3 = new System.Windows.Forms.Button();
            this.WordCount = new System.Windows.Forms.TextBox();
            this.button5_3_4 = new System.Windows.Forms.Button();
            this.TextBoxForLengthWord = new System.Windows.Forms.TextBox();
            this.button5_3_5 = new System.Windows.Forms.Button();
            this.TextBoxRepairWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputstrData = new System.Windows.Forms.TextBox();
            this.inputStrData = new System.Windows.Forms.TextBox();
            this.button5_4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputStrText
            // 
            this.inputStrText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrText.Location = new System.Drawing.Point(76, 73);
            this.inputStrText.Name = "inputStrText";
            this.inputStrText.Size = new System.Drawing.Size(677, 31);
            this.inputStrText.TabIndex = 0;
            // 
            // button5_3_1
            // 
            this.button5_3_1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_3_1.Location = new System.Drawing.Point(76, 138);
            this.button5_3_1.Name = "button5_3_1";
            this.button5_3_1.Size = new System.Drawing.Size(151, 52);
            this.button5_3_1.TabIndex = 1;
            this.button5_3_1.Text = "空白をカウント";
            this.button5_3_1.UseVisualStyleBackColor = true;
            this.button5_3_1.Click += new System.EventHandler(this.button5_3_1_Click);
            // 
            // TextBoxSpaceCount
            // 
            this.TextBoxSpaceCount.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxSpaceCount.Location = new System.Drawing.Point(288, 148);
            this.TextBoxSpaceCount.Name = "TextBoxSpaceCount";
            this.TextBoxSpaceCount.Size = new System.Drawing.Size(46, 31);
            this.TextBoxSpaceCount.TabIndex = 2;
            // 
            // button5_3_2
            // 
            this.button5_3_2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_3_2.Location = new System.Drawing.Point(76, 213);
            this.button5_3_2.Name = "button5_3_2";
            this.button5_3_2.Size = new System.Drawing.Size(163, 52);
            this.button5_3_2.TabIndex = 1;
            this.button5_3_2.Text = "big → small";
            this.button5_3_2.UseVisualStyleBackColor = true;
            this.button5_3_2.Click += new System.EventHandler(this.button5_3_2_Click);
            // 
            // TextBoxWordChange
            // 
            this.TextBoxWordChange.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordChange.Location = new System.Drawing.Point(288, 223);
            this.TextBoxWordChange.Name = "TextBoxWordChange";
            this.TextBoxWordChange.Size = new System.Drawing.Size(500, 31);
            this.TextBoxWordChange.TabIndex = 2;
            // 
            // button5_3_3
            // 
            this.button5_3_3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_3_3.Location = new System.Drawing.Point(76, 299);
            this.button5_3_3.Name = "button5_3_3";
            this.button5_3_3.Size = new System.Drawing.Size(163, 52);
            this.button5_3_3.TabIndex = 1;
            this.button5_3_3.Text = "単語カウント";
            this.button5_3_3.UseVisualStyleBackColor = true;
            this.button5_3_3.Click += new System.EventHandler(this.button5_3_3_Click);
            // 
            // WordCount
            // 
            this.WordCount.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WordCount.Location = new System.Drawing.Point(288, 309);
            this.WordCount.Name = "WordCount";
            this.WordCount.Size = new System.Drawing.Size(46, 31);
            this.WordCount.TabIndex = 2;
            // 
            // button5_3_4
            // 
            this.button5_3_4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_3_4.Location = new System.Drawing.Point(76, 376);
            this.button5_3_4.Name = "button5_3_4";
            this.button5_3_4.Size = new System.Drawing.Size(182, 52);
            this.button5_3_4.TabIndex = 1;
            this.button5_3_4.Text = "４文字以下の単語";
            this.button5_3_4.UseVisualStyleBackColor = true;
            this.button5_3_4.Click += new System.EventHandler(this.button5_3_4_Click);
            // 
            // TextBoxForLengthWord
            // 
            this.TextBoxForLengthWord.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxForLengthWord.Location = new System.Drawing.Point(288, 386);
            this.TextBoxForLengthWord.Name = "TextBoxForLengthWord";
            this.TextBoxForLengthWord.Size = new System.Drawing.Size(357, 31);
            this.TextBoxForLengthWord.TabIndex = 2;
            // 
            // button5_3_5
            // 
            this.button5_3_5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_3_5.Location = new System.Drawing.Point(76, 460);
            this.button5_3_5.Name = "button5_3_5";
            this.button5_3_5.Size = new System.Drawing.Size(182, 52);
            this.button5_3_5.TabIndex = 1;
            this.button5_3_5.Text = "StringBuilder";
            this.button5_3_5.UseVisualStyleBackColor = true;
            this.button5_3_5.Click += new System.EventHandler(this.button5_3_5_Click);
            // 
            // TextBoxRepairWord
            // 
            this.TextBoxRepairWord.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxRepairWord.Location = new System.Drawing.Point(288, 470);
            this.TextBoxRepairWord.Name = "TextBoxRepairWord";
            this.TextBoxRepairWord.Size = new System.Drawing.Size(487, 31);
            this.TextBoxRepairWord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "問題5.3";
            // 
            // outputstrData
            // 
            this.outputstrData.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputstrData.Location = new System.Drawing.Point(192, 601);
            this.outputstrData.Name = "outputstrData";
            this.outputstrData.Size = new System.Drawing.Size(487, 31);
            this.outputstrData.TabIndex = 2;
            // 
            // inputStrData
            // 
            this.inputStrData.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrData.Location = new System.Drawing.Point(192, 554);
            this.inputStrData.Name = "inputStrData";
            this.inputStrData.Size = new System.Drawing.Size(487, 31);
            this.inputStrData.TabIndex = 2;
            // 
            // button5_4
            // 
            this.button5_4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_4.Location = new System.Drawing.Point(4, 568);
            this.button5_4.Name = "button5_4";
            this.button5_4.Size = new System.Drawing.Size(182, 52);
            this.button5_4.TabIndex = 1;
            this.button5_4.Text = "問題5.4";
            this.button5_4.UseVisualStyleBackColor = true;
            this.button5_4.Click += new System.EventHandler(this.button5_4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputstrData);
            this.Controls.Add(this.inputStrData);
            this.Controls.Add(this.TextBoxRepairWord);
            this.Controls.Add(this.TextBoxForLengthWord);
            this.Controls.Add(this.WordCount);
            this.Controls.Add(this.TextBoxWordChange);
            this.Controls.Add(this.TextBoxSpaceCount);
            this.Controls.Add(this.button5_4);
            this.Controls.Add(this.button5_3_5);
            this.Controls.Add(this.button5_3_4);
            this.Controls.Add(this.button5_3_3);
            this.Controls.Add(this.button5_3_2);
            this.Controls.Add(this.button5_3_1);
            this.Controls.Add(this.inputStrText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputStrText;
        private System.Windows.Forms.Button button5_3_1;
        private System.Windows.Forms.TextBox TextBoxSpaceCount;
        private System.Windows.Forms.Button button5_3_2;
        private System.Windows.Forms.TextBox TextBoxWordChange;
        private System.Windows.Forms.Button button5_3_3;
        private System.Windows.Forms.TextBox WordCount;
        private System.Windows.Forms.Button button5_3_4;
        private System.Windows.Forms.TextBox TextBoxForLengthWord;
        private System.Windows.Forms.Button button5_3_5;
        private System.Windows.Forms.TextBox TextBoxRepairWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputstrData;
        private System.Windows.Forms.TextBox inputStrData;
        private System.Windows.Forms.Button button5_4;
    }
}

