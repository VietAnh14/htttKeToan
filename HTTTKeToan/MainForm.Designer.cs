namespace HTTTKeToan
{
    partial class MainForm
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.báoCáoNhậpXuấtTồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoPhiếuNhậpĐiềuChỉnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoPhiếuXuấtĐiềuChỉnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 24);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(984, 537);
            this.panelContainer.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoNhậpXuấtTồnToolStripMenuItem,
            this.tạoPhiếuNhậpĐiềuChỉnhToolStripMenuItem,
            this.tạoPhiếuXuấtĐiềuChỉnhToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(984, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // báoCáoNhậpXuấtTồnToolStripMenuItem
            // 
            this.báoCáoNhậpXuấtTồnToolStripMenuItem.Name = "báoCáoNhậpXuấtTồnToolStripMenuItem";
            this.báoCáoNhậpXuấtTồnToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.báoCáoNhậpXuấtTồnToolStripMenuItem.Text = "Báo cáo nhập xuất tồn";
            this.báoCáoNhậpXuấtTồnToolStripMenuItem.Click += new System.EventHandler(this.báoCáoNhậpXuấtTồnToolStripMenuItem_Click);
            // 
            // tạoPhiếuNhậpĐiềuChỉnhToolStripMenuItem
            // 
            this.tạoPhiếuNhậpĐiềuChỉnhToolStripMenuItem.Name = "tạoPhiếuNhậpĐiềuChỉnhToolStripMenuItem";
            this.tạoPhiếuNhậpĐiềuChỉnhToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.tạoPhiếuNhậpĐiềuChỉnhToolStripMenuItem.Text = "Tạo phiếu nhập điều chỉnh";
            this.tạoPhiếuNhậpĐiềuChỉnhToolStripMenuItem.Click += new System.EventHandler(this.tạoPhiếuNhậpĐiềuChỉnhToolStripMenuItem_Click);
            // 
            // tạoPhiếuXuấtĐiềuChỉnhToolStripMenuItem
            // 
            this.tạoPhiếuXuấtĐiềuChỉnhToolStripMenuItem.Name = "tạoPhiếuXuấtĐiềuChỉnhToolStripMenuItem";
            this.tạoPhiếuXuấtĐiềuChỉnhToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.tạoPhiếuXuấtĐiềuChỉnhToolStripMenuItem.Text = "Tạo phiếu xuất điều chỉnh";
            this.tạoPhiếuXuấtĐiềuChỉnhToolStripMenuItem.Click += new System.EventHandler(this.tạoPhiếuXuấtĐiềuChỉnhToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem báoCáoNhậpXuấtTồnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoPhiếuNhậpĐiềuChỉnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoPhiếuXuấtĐiềuChỉnhToolStripMenuItem;
    }
}

