
namespace Sotsug
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbClothing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "＜";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "＞";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "⌂";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbClothing
            // 
            this.lbClothing.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbClothing.Location = new System.Drawing.Point(12, 54);
            this.lbClothing.Name = "lbClothing";
            this.lbClothing.Size = new System.Drawing.Size(1099, 594);
            this.lbClothing.TabIndex = 6;
            this.lbClothing.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 657);
            this.Controls.Add(this.lbClothing);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "検索結果";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbClothing;
    }
}