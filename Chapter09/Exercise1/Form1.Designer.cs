﻿
namespace Exercise1 {
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
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btOpen = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btReadAllLines = new System.Windows.Forms.Button();
            this.btReadLines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(40, 24);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(80, 51);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "開く...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(30, 98);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(739, 343);
            this.tbOutput.TabIndex = 1;
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(147, 58);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(110, 19);
            this.tbKeyword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "キーワード";
            // 
            // btReadAllLines
            // 
            this.btReadAllLines.Location = new System.Drawing.Point(277, 21);
            this.btReadAllLines.Name = "btReadAllLines";
            this.btReadAllLines.Size = new System.Drawing.Size(101, 56);
            this.btReadAllLines.TabIndex = 4;
            this.btReadAllLines.Text = "ReadAllLines";
            this.btReadAllLines.UseVisualStyleBackColor = true;
            this.btReadAllLines.Click += new System.EventHandler(this.btReadAllLines_Click);
            // 
            // btReadLines
            // 
            this.btReadLines.Location = new System.Drawing.Point(413, 24);
            this.btReadLines.Name = "btReadLines";
            this.btReadLines.Size = new System.Drawing.Size(110, 50);
            this.btReadLines.TabIndex = 5;
            this.btReadLines.Text = "readline";
            this.btReadLines.UseVisualStyleBackColor = true;
            this.btReadLines.Click += new System.EventHandler(this.btReadLines_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReadLines);
            this.Controls.Add(this.btReadAllLines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReadAllLines;
        private System.Windows.Forms.Button btReadLines;
    }
}

