#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using System.IO;

#endregion

namespace WebExp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // リストビューの初期化（列追加
            ColumnHeader objColumn = new ColumnHeader();
            objColumn.Text = "Name";
            objColumn.Width = 200;
            listView1.Columns.Add(objColumn);
            objColumn = new ColumnHeader();
            objColumn.Text = "Extension";
            objColumn.Width = 100;
            listView1.Columns.Add(objColumn);

            // ツリービューの初期化
            treeView1.Nodes.Clear();
            TreeNode objTreeNode = new TreeNode();
            objTreeNode.Text = "C:";
            objTreeNode.Tag = @"C:\";
            treeView1.Nodes.Add(objTreeNode);
            LoadFolder(objTreeNode.Nodes, objTreeNode.Tag as string);
        }

        private void LoadFolder(TreeNodeCollection objNodes, string strPath)
        {
            DirectoryInfo objDir = new DirectoryInfo(strPath);

            objNodes.Clear();
            foreach (DirectoryInfo objSubDir in objDir.GetDirectories())
            {
                if ((objSubDir.Attributes & FileAttributes.Directory) == FileAttributes.Directory
                    && (objSubDir.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    try
                    {
                        TreeNode objTreeNode = new TreeNode();
                        objTreeNode.Text = objSubDir.Name;
                        objTreeNode.Tag = objSubDir.FullName;
                        objTreeNode.ImageIndex = 0;

                        objNodes.Add(objTreeNode);

                        if (objSubDir.GetDirectories().Length > 0)
                        {
                            TreeNode dmyNode = new TreeNode();
                            objTreeNode.Nodes.Add(dmyNode);
                        }
                    }
                    catch (Exception)
                    {
                        //    var result = MessageBox.Show(e.Message);
                    }
                }
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (!e.Node.IsExpanded)
                LoadFolder(e.Node.Nodes, e.Node.Tag as string);
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            string strPath = e.Node.Tag as string;
            DirectoryInfo objDir = new DirectoryInfo(strPath);

            listView1.Items.Clear();

            try
            {
                foreach (FileInfo objFile in objDir.GetFiles())
                {
                    try
                    {
                        ListViewItem objItem = listView1.Items.Add(objFile.Name);
                        objItem.SubItems.Add(objFile.Extension);
                        objItem.ImageIndex = 1;
                    }
                    catch (Exception)
                    {
                        //    var result = MessageBox.Show(e.Message);
                    }
                }
            }
            catch (Exception)
            {
                //    var result = MessageBox.Show(e.Message);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SubForm frm = new SubForm();
            frm.ShowDialog();
        }
    }
}