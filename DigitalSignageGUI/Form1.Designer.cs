namespace DigitalSignageGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleDOTW = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pphomeList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitDropDown});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitDropDown
            // 
            this.exitDropDown.Name = "exitDropDown";
            this.exitDropDown.Size = new System.Drawing.Size(152, 22);
            this.exitDropDown.Text = "Exit";
            this.exitDropDown.Click += new System.EventHandler(this.exitDropDown_Click);
            // 
            // scheduleDOTW
            // 
            this.scheduleDOTW.Location = new System.Drawing.Point(229, 27);
            this.scheduleDOTW.Name = "scheduleDOTW";
            this.scheduleDOTW.Size = new System.Drawing.Size(200, 110);
            this.scheduleDOTW.TabIndex = 5;
            this.scheduleDOTW.TabStop = false;
            this.scheduleDOTW.Text = "Days of the Week";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(274, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 99);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Of Day";
            // 
            // pphomeList
            // 
            this.pphomeList.FormattingEnabled = true;
            this.pphomeList.Location = new System.Drawing.Point(12, 38);
            this.pphomeList.Name = "pphomeList";
            this.pphomeList.Size = new System.Drawing.Size(83, 82);
            this.pphomeList.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 272);
            this.Controls.Add(this.pphomeList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scheduleDOTW);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Scheduling GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitDropDown;
        private System.Windows.Forms.GroupBox scheduleDOTW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox pphomeList;
    }
}

