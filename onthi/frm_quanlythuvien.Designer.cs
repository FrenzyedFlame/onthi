namespace onthi
{
    partial class frm_quanlythuvien
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
            this.quanLySechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapSẹcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLySechToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLySechToolStripMenuItem
            // 
            this.quanLySechToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapSẹcToolStripMenuItem});
            this.quanLySechToolStripMenuItem.Name = "quanLySechToolStripMenuItem";
            this.quanLySechToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.quanLySechToolStripMenuItem.Text = "quan ly sech";
            // 
            // nhapSẹcToolStripMenuItem
            // 
            this.nhapSẹcToolStripMenuItem.Name = "nhapSẹcToolStripMenuItem";
            this.nhapSẹcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nhapSẹcToolStripMenuItem.Text = "nhap sech";
            this.nhapSẹcToolStripMenuItem.Click += new System.EventHandler(this.nhapSẹcToolStripMenuItem_Click);
            // 
            // frm_quanlythuvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_quanlythuvien";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLySechToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapSẹcToolStripMenuItem;
    }
}