namespace WindowsFormsApp4
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdBold = new System.Windows.Forms.ToolStripButton();
            this.cmditalic = new System.Windows.Forms.ToolStripButton();
            this.cmdunderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdcolors = new System.Windows.Forms.ToolStripDropDownButton();
            this.cmdfont = new System.Windows.Forms.ToolStripDropDownButton();
            this.cmdfontsize = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdzoom = new System.Windows.Forms.ToolStripDropDownButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(135, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(607, 371);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdBold,
            this.cmditalic,
            this.cmdunderline,
            this.toolStripSeparator1,
            this.cmdcolors,
            this.cmdfont,
            this.cmdfontsize,
            this.toolStripSeparator2,
            this.cmdzoom});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdBold
            // 
            this.cmdBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdBold.Image = ((System.Drawing.Image)(resources.GetObject("cmdBold.Image")));
            this.cmdBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBold.Name = "cmdBold";
            this.cmdBold.Size = new System.Drawing.Size(44, 24);
            this.cmdBold.Text = "Bold";
            this.cmdBold.Click += new System.EventHandler(this.cmdBold_Click);
            // 
            // cmditalic
            // 
            this.cmditalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmditalic.Image = ((System.Drawing.Image)(resources.GetObject("cmditalic.Image")));
            this.cmditalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmditalic.Name = "cmditalic";
            this.cmditalic.Size = new System.Drawing.Size(45, 24);
            this.cmditalic.Text = "italic";
            this.cmditalic.Click += new System.EventHandler(this.cmditalic_Click);
            // 
            // cmdunderline
            // 
            this.cmdunderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdunderline.Image = ((System.Drawing.Image)(resources.GetObject("cmdunderline.Image")));
            this.cmdunderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdunderline.Name = "cmdunderline";
            this.cmdunderline.Size = new System.Drawing.Size(75, 24);
            this.cmdunderline.Text = "underline";
            this.cmdunderline.Click += new System.EventHandler(this.cmdunderline_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // cmdcolors
            // 
            this.cmdcolors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdcolors.Image = ((System.Drawing.Image)(resources.GetObject("cmdcolors.Image")));
            this.cmdcolors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdcolors.Name = "cmdcolors";
            this.cmdcolors.Size = new System.Drawing.Size(63, 24);
            this.cmdcolors.Text = "colors";
            this.cmdcolors.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmdcolors_DropDownItemClicked);
            // 
            // cmdfont
            // 
            this.cmdfont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdfont.Image = ((System.Drawing.Image)(resources.GetObject("cmdfont.Image")));
            this.cmdfont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdfont.Name = "cmdfont";
            this.cmdfont.Size = new System.Drawing.Size(50, 24);
            this.cmdfont.Text = "font";
            this.cmdfont.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmdfont_DropDownItemClicked);
            // 
            // cmdfontsize
            // 
            this.cmdfontsize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdfontsize.Image = ((System.Drawing.Image)(resources.GetObject("cmdfontsize.Image")));
            this.cmdfontsize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdfontsize.Name = "cmdfontsize";
            this.cmdfontsize.Size = new System.Drawing.Size(75, 24);
            this.cmdfontsize.Text = "fontsize";
            this.cmdfontsize.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmdfontsize_DropDownItemClicked);
            this.cmdfontsize.Click += new System.EventHandler(this.cmdfontsize_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // cmdzoom
            // 
            this.cmdzoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdzoom.Image = ((System.Drawing.Image)(resources.GetObject("cmdzoom.Image")));
            this.cmdzoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdzoom.Name = "cmdzoom";
            this.cmdzoom.Size = new System.Drawing.Size(63, 24);
            this.cmdzoom.Text = "Zoom";
            this.cmdzoom.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmdzoom_DropDownItemClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton cmdBold;
        private System.Windows.Forms.ToolStripButton cmditalic;
        private System.Windows.Forms.ToolStripButton cmdunderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton cmdcolors;
        private System.Windows.Forms.ToolStripDropDownButton cmdfont;
        private System.Windows.Forms.ToolStripDropDownButton cmdfontsize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton cmdzoom;
        private System.Windows.Forms.Button button2;
    }
}