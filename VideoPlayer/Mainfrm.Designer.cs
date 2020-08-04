namespace Warp_Csharp
{
    partial class Mainfrm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nCCMatchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNCCDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaitonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nCCMatchingToolStripMenuItem,
            this.informaitonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nCCMatchingToolStripMenuItem
            // 
            this.nCCMatchingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNCCDialogToolStripMenuItem});
            this.nCCMatchingToolStripMenuItem.Name = "nCCMatchingToolStripMenuItem";
            this.nCCMatchingToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.nCCMatchingToolStripMenuItem.Text = "iMatch Matching";
            // 
            // openNCCDialogToolStripMenuItem
            // 
            this.openNCCDialogToolStripMenuItem.Name = "openNCCDialogToolStripMenuItem";
            this.openNCCDialogToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openNCCDialogToolStripMenuItem.Text = "Open iMatch Dialog";
            this.openNCCDialogToolStripMenuItem.Click += new System.EventHandler(this.openNCCDialogToolStripMenuItem_Click);
            // 
            // informaitonToolStripMenuItem
            // 
            this.informaitonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getVersionToolStripMenuItem,
            this.keyToolStripMenuItem});
            this.informaitonToolStripMenuItem.Name = "informaitonToolStripMenuItem";
            this.informaitonToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.informaitonToolStripMenuItem.Text = "Informaiton";
            // 
            // getVersionToolStripMenuItem
            // 
            this.getVersionToolStripMenuItem.Name = "getVersionToolStripMenuItem";
            this.getVersionToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.getVersionToolStripMenuItem.Text = "GetVersion";
            this.getVersionToolStripMenuItem.Click += new System.EventHandler(this.getVersionToolStripMenuItem_Click);
            // 
            // keyToolStripMenuItem
            // 
            this.keyToolStripMenuItem.Name = "keyToolStripMenuItem";
            this.keyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.keyToolStripMenuItem.Text = "Key";
            this.keyToolStripMenuItem.Click += new System.EventHandler(this.keyToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picturebox
            // 
            this.picturebox.Location = new System.Drawing.Point(10, 30);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(282, 196);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturebox.TabIndex = 1;
            this.picturebox.TabStop = false;
            this.picturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Picbox_MouseDown);
            this.picturebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picbox_MouseMove);
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 418);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainfrm";
            this.Text = "MiM iMatch Demo_x64";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainfrm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nCCMatchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNCCDialogToolStripMenuItem;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.ToolStripMenuItem informaitonToolStripMenuItem;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem getVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem;
    }
}

