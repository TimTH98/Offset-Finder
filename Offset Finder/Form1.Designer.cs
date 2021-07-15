
namespace Offset_Finder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.off_0 = new System.Windows.Forms.TextBox();
            this.off_res = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.off_1 = new System.Windows.Forms.TextBox();
            this.off_2 = new System.Windows.Forms.TextBox();
            this.off_3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // off_0
            // 
            this.off_0.Location = new System.Drawing.Point(5, 22);
            this.off_0.MaxLength = 2;
            this.off_0.Name = "off_0";
            this.off_0.Size = new System.Drawing.Size(30, 20);
            this.off_0.TabIndex = 1;
            this.off_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // off_res
            // 
            this.off_res.Location = new System.Drawing.Point(13, 94);
            this.off_res.Name = "off_res";
            this.off_res.ReadOnly = true;
            this.off_res.Size = new System.Drawing.Size(120, 20);
            this.off_res.TabIndex = 6;
            this.off_res.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Paste your offset:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result:";
            // 
            // off_1
            // 
            this.off_1.Location = new System.Drawing.Point(41, 22);
            this.off_1.MaxLength = 2;
            this.off_1.Name = "off_1";
            this.off_1.Size = new System.Drawing.Size(30, 20);
            this.off_1.TabIndex = 2;
            this.off_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // off_2
            // 
            this.off_2.Location = new System.Drawing.Point(77, 22);
            this.off_2.MaxLength = 2;
            this.off_2.Name = "off_2";
            this.off_2.Size = new System.Drawing.Size(30, 20);
            this.off_2.TabIndex = 3;
            this.off_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // off_3
            // 
            this.off_3.Location = new System.Drawing.Point(113, 22);
            this.off_3.MaxLength = 2;
            this.off_3.Name = "off_3";
            this.off_3.Size = new System.Drawing.Size(30, 20);
            this.off_3.TabIndex = 4;
            this.off_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search this in hex editor\r\nto find string offset.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(150, 152);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.off_res);
            this.Controls.Add(this.off_3);
            this.Controls.Add(this.off_2);
            this.Controls.Add(this.off_1);
            this.Controls.Add(this.off_0);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Offset Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox off_0;
        private System.Windows.Forms.TextBox off_res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox off_1;
        private System.Windows.Forms.TextBox off_2;
        private System.Windows.Forms.TextBox off_3;
        private System.Windows.Forms.Label label3;
    }
}

