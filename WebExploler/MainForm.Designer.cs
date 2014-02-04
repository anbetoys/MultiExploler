namespace WebExploler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView1 = new Gizmox.WebGUI.Forms.TreeView();
            this.splitter1 = new Gizmox.WebGUI.Forms.Splitter();
            this.listView1 = new Gizmox.WebGUI.Forms.ListView();
            this.imageList1 = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.treeView1.ImageKey = "folder.gif";
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(182, 441);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeSelect += new Gizmox.WebGUI.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            this.treeView1.BeforeExpand += new Gizmox.WebGUI.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(182, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 441);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.AutoGenerateColumns = true;
            this.listView1.DataMember = null;
            this.listView1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.listView1.ItemsPerPage = 20;
            this.listView1.Location = new System.Drawing.Point(185, 0);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = false;
            this.listView1.Size = new System.Drawing.Size(364, 441);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.Images.AddRange(new Gizmox.WebGUI.Common.Resources.ResourceHandle[] {
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imageList1.Images")),
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imageList1.Images1"))});
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.Images.SetKeyName(0, "folder.gif");
            this.imageList1.Images.SetKeyName(1, "settings.gif");
            // 
            // MainForm
            // 
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = Gizmox.WebGUI.Forms.FormBorderStyle.Sizable;
            this.Size = new System.Drawing.Size(549, 441);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.TreeView treeView1;
        private Gizmox.WebGUI.Forms.Splitter splitter1;
        private Gizmox.WebGUI.Forms.ListView listView1;
        private Gizmox.WebGUI.Forms.ImageList imageList1;
    }
}