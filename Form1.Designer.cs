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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxTriangle = new System.Windows.Forms.ToolStripMenuItem();
            this.label_shape = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 431);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxCircle,
            this.toolStripTextBoxRectangle,
            this.toolStripTextBoxTriangle});
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.shapesToolStripMenuItem.Text = "Shapes";
            // 
            // toolStripTextBoxCircle
            // 
            this.toolStripTextBoxCircle.Name = "toolStripTextBoxCircle";
            this.toolStripTextBoxCircle.Size = new System.Drawing.Size(180, 22);
            this.toolStripTextBoxCircle.Text = "Circle";
            this.toolStripTextBoxCircle.Click += new System.EventHandler(this.toolStripTextBoxCircle_Click);
            // 
            // toolStripTextBoxRectangle
            // 
            this.toolStripTextBoxRectangle.Name = "toolStripTextBoxRectangle";
            this.toolStripTextBoxRectangle.Size = new System.Drawing.Size(180, 22);
            this.toolStripTextBoxRectangle.Text = "Rectangle";
            this.toolStripTextBoxRectangle.Click += new System.EventHandler(this.toolStripTextBoxRectangle_Click);
            // 
            // toolStripTextBoxTriangle
            // 
            this.toolStripTextBoxTriangle.Name = "toolStripTextBoxTriangle";
            this.toolStripTextBoxTriangle.Size = new System.Drawing.Size(180, 22);
            this.toolStripTextBoxTriangle.Text = "Triangle";
            this.toolStripTextBoxTriangle.Click += new System.EventHandler(this.toolStripTextBoxTriangle_Click);
            // 
            // label_shape
            // 
            this.label_shape.AutoSize = true;
            this.label_shape.Location = new System.Drawing.Point(419, 24);
            this.label_shape.Name = "label_shape";
            this.label_shape.Size = new System.Drawing.Size(38, 15);
            this.label_shape.TabIndex = 2;
            this.label_shape.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 511);
            this.Controls.Add(this.label_shape);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1122, 550);
            this.MinimumSize = new System.Drawing.Size(1122, 550);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem shapesToolStripMenuItem;
        private ToolStripMenuItem toolStripTextBoxCircle;
        private ToolStripMenuItem toolStripTextBoxRectangle;
        private ToolStripMenuItem toolStripTextBoxTriangle;
        private Label label_shape;
    }
}