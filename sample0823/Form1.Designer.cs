
namespace sample0823
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
            this.Value = new System.Windows.Forms.TextBox();
            this.jyou = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exec = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(12, 25);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(100, 25);
            this.Value.TabIndex = 0;
            // 
            // jyou
            // 
            this.jyou.Location = new System.Drawing.Point(249, 25);
            this.jyou.Name = "jyou";
            this.jyou.Size = new System.Drawing.Size(100, 25);
            this.jyou.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "の";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "乗";
            // 
            // Exec
            // 
            this.Exec.Location = new System.Drawing.Point(381, 86);
            this.Exec.Name = "Exec";
            this.Exec.Size = new System.Drawing.Size(75, 23);
            this.Exec.TabIndex = 4;
            this.Exec.Text = "結果→";
            this.Exec.UseVisualStyleBackColor = true;
            this.Exec.Click += new System.EventHandler(this.Exec_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(539, 83);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 25);
            this.Result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Exec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jyou);
            this.Controls.Add(this.Value);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.TextBox jyou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exec;
        private System.Windows.Forms.TextBox Result;
    }
}

