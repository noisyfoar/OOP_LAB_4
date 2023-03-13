namespace OOP_LAB_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox_CTRL = new System.Windows.Forms.CheckBox();
            this.checkBox_Multiple = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // checkBox_CTRL
            // 
            this.checkBox_CTRL.AutoCheck = false;
            this.checkBox_CTRL.AutoSize = true;
            this.checkBox_CTRL.Location = new System.Drawing.Point(14, 16);
            this.checkBox_CTRL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_CTRL.Name = "checkBox_CTRL";
            this.checkBox_CTRL.Size = new System.Drawing.Size(54, 24);
            this.checkBox_CTRL.TabIndex = 1;
            this.checkBox_CTRL.Text = "Ctrl";
            this.checkBox_CTRL.UseVisualStyleBackColor = true;
            // 
            // checkBox_Multiple
            // 
            this.checkBox_Multiple.AutoSize = true;
            this.checkBox_Multiple.Location = new System.Drawing.Point(14, 49);
            this.checkBox_Multiple.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_Multiple.Name = "checkBox_Multiple";
            this.checkBox_Multiple.Size = new System.Drawing.Size(72, 24);
            this.checkBox_Multiple.TabIndex = 2;
            this.checkBox_Multiple.Text = "Single";
            this.checkBox_Multiple.UseVisualStyleBackColor = true;
            this.checkBox_Multiple.CheckedChanged += new System.EventHandler(this.checkBox_Multiple_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(14, 83);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 574);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.checkBox_Multiple);
            this.Controls.Add(this.checkBox_CTRL);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox checkBox_CTRL;
        private CheckBox checkBox_Multiple;
        private Panel panel1;
    }
}