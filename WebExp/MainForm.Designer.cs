namespace WebExp
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

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new Gizmox.WebGUI.Forms.MenuStrip();
            this.toolStripMenuItem1 = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.treeView1 = new Gizmox.WebGUI.Forms.TreeView();
            this.splitter1 = new Gizmox.WebGUI.Forms.Splitter();
            this.listView1 = new Gizmox.WebGUI.Forms.ListView();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.DockPadding.Bottom = 2;
            this.menuStrip1.DockPadding.Left = 6;
            this.menuStrip1.DockPadding.Top = 2;
            this.menuStrip1.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(128, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new Gizmox.WebGUI.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(38, 17);
            this.toolStripMenuItem1.Text = "‚Ä‚·‚Æ";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.toolStripMenuItem3.Size = new System.Drawing.Size(38, 19);
            this.toolStripMenuItem3.Text = "‚Ä‚·‚Æ";
            this.toolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeView1
            // 
            this.treeView1.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(48, 276);
            this.treeView1.TabIndex = 1;
            this.treeView1.BeforeSelect += new Gizmox.WebGUI.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            this.treeView1.BeforeExpand += new Gizmox.WebGUI.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(48, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 276);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.AutoGenerateColumns = true;
            this.listView1.DataMember = null;
            this.listView1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.listView1.ItemsPerPage = 20;
            this.listView1.Location = new System.Drawing.Point(51, 24);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = false;
            this.listView1.Size = new System.Drawing.Size(249, 276);
            this.listView1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = Gizmox.WebGUI.Forms.FormBorderStyle.Sizable;
            this.Size = new System.Drawing.Size(300, 300);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.MenuStrip menuStrip1;
        private Gizmox.WebGUI.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Gizmox.WebGUI.Forms.ToolStripMenuItem toolStripMenuItem3;
        private Gizmox.WebGUI.Forms.TreeView treeView1;
        private Gizmox.WebGUI.Forms.Splitter splitter1;
        private Gizmox.WebGUI.Forms.ListView listView1;
    }
}