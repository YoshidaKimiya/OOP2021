
namespace StopWatch {
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
            this.components = new System.ComponentModel.Container();
            this.lbTimerDisp = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btRap = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.lbxRap = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbTimerDisp.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimerDisp.Location = new System.Drawing.Point(32, 29);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(522, 75);
            this.lbTimerDisp.TabIndex = 0;
            this.lbTimerDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(34, 118);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(257, 66);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btRap
            // 
            this.btRap.Location = new System.Drawing.Point(308, 118);
            this.btRap.Name = "btRap";
            this.btRap.Size = new System.Drawing.Size(246, 66);
            this.btRap.TabIndex = 1;
            this.btRap.Text = "Rap";
            this.btRap.UseVisualStyleBackColor = true;
            this.btRap.Click += new System.EventHandler(this.btRap_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(308, 190);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(246, 66);
            this.btReset.TabIndex = 1;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(34, 190);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(257, 66);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // lbxRap
            // 
            this.lbxRap.FormattingEnabled = true;
            this.lbxRap.ItemHeight = 12;
            this.lbxRap.Location = new System.Drawing.Point(575, 30);
            this.lbxRap.Name = "lbxRap";
            this.lbxRap.Size = new System.Drawing.Size(206, 220);
            this.lbxRap.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 279);
            this.Controls.Add(this.lbxRap);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btRap);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbTimerDisp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimerDisp;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btRap;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.ListBox lbxRap;
    }
}

