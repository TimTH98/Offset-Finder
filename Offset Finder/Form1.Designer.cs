
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CodeLine = new System.Windows.Forms.TextBox();
            this.result2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // off_0
            // 
            this.off_0.Location = new System.Drawing.Point(16, 21);
            this.off_0.MaxLength = 2;
            this.off_0.Name = "off_0";
            this.off_0.Size = new System.Drawing.Size(30, 20);
            this.off_0.TabIndex = 1;
            this.off_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // off_res
            // 
            this.off_res.Location = new System.Drawing.Point(24, 93);
            this.off_res.Name = "off_res";
            this.off_res.ReadOnly = true;
            this.off_res.Size = new System.Drawing.Size(120, 20);
            this.off_res.TabIndex = 6;
            this.off_res.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Paste your offset:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result:";
            // 
            // off_1
            // 
            this.off_1.Location = new System.Drawing.Point(52, 21);
            this.off_1.MaxLength = 2;
            this.off_1.Name = "off_1";
            this.off_1.Size = new System.Drawing.Size(30, 20);
            this.off_1.TabIndex = 2;
            this.off_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // off_2
            // 
            this.off_2.Location = new System.Drawing.Point(88, 21);
            this.off_2.MaxLength = 2;
            this.off_2.Name = "off_2";
            this.off_2.Size = new System.Drawing.Size(30, 20);
            this.off_2.TabIndex = 3;
            this.off_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // off_3
            // 
            this.off_3.Location = new System.Drawing.Point(124, 21);
            this.off_3.MaxLength = 2;
            this.off_3.Name = "off_3";
            this.off_3.Size = new System.Drawing.Size(30, 20);
            this.off_3.TabIndex = 4;
            this.off_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search this in hex editor\r\nto find string offset.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.off_0);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.off_1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.off_2);
            this.splitContainer1.Panel1.Controls.Add(this.off_res);
            this.splitContainer1.Panel1.Controls.Add(this.off_3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.CodeLine);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.result2);
            this.splitContainer1.Size = new System.Drawing.Size(334, 147);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Convert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Search Line code in hex editor\r\nto find string offset and paste:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodeLine
            // 
            this.CodeLine.Location = new System.Drawing.Point(22, 36);
            this.CodeLine.Name = "CodeLine";
            this.CodeLine.Size = new System.Drawing.Size(120, 20);
            this.CodeLine.TabIndex = 6;
            this.CodeLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result2
            // 
            this.result2.Location = new System.Drawing.Point(22, 114);
            this.result2.Name = "result2";
            this.result2.ReadOnly = true;
            this.result2.Size = new System.Drawing.Size(120, 20);
            this.result2.TabIndex = 6;
            this.result2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(335, 152);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Offset Converter";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CodeLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox result2;
    }
}

