namespace newVIM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cursorXLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cursorYLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cursorXLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cursorYLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 368);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Position X:";
            // 
            // cursorXLabel
            // 
            this.cursorXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cursorXLabel.Location = new System.Drawing.Point(375, 63);
            this.cursorXLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cursorXLabel.Name = "cursorXLabel";
            this.cursorXLabel.Size = new System.Drawing.Size(83, 41);
            this.cursorXLabel.TabIndex = 2;
            this.cursorXLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Position Y:";
            // 
            // cursorYLabel
            // 
            this.cursorYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cursorYLabel.Location = new System.Drawing.Point(375, 180);
            this.cursorYLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cursorYLabel.Name = "cursorYLabel";
            this.cursorYLabel.Size = new System.Drawing.Size(83, 41);
            this.cursorYLabel.TabIndex = 4;
            this.cursorYLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cursorXLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cursorYLabel;
    }
}

