namespace ControlsTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.stuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTdResult = new System.Windows.Forms.Label();
            this.commandLink1 = new Windows.Controls.CommandLink();
            this.searchBox1 = new Windows.Controls.SearchBox();
            this.commandButton1 = new Windows.Controls.CommandButton();
            this.editControl1 = new Windows.Controls.EditControl();
            this.splitButton1 = new Windows.Controls.SplitButton();
            this.treeView1 = new Windows.Controls.TreeView();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1ToolStripMenuItem,
            this.menuItem2ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.stuffToolStripMenuItem,
            this.thingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 98);
            // 
            // menuItem1ToolStripMenuItem
            // 
            this.menuItem1ToolStripMenuItem.Name = "menuItem1ToolStripMenuItem";
            this.menuItem1ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.menuItem1ToolStripMenuItem.Text = "Menu Item 1";
            // 
            // menuItem2ToolStripMenuItem
            // 
            this.menuItem2ToolStripMenuItem.Name = "menuItem2ToolStripMenuItem";
            this.menuItem2ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.menuItem2ToolStripMenuItem.Text = "Menu Item 2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // stuffToolStripMenuItem
            // 
            this.stuffToolStripMenuItem.Name = "stuffToolStripMenuItem";
            this.stuffToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.stuffToolStripMenuItem.Text = "Stuff";
            // 
            // thingsToolStripMenuItem
            // 
            this.thingsToolStripMenuItem.Name = "thingsToolStripMenuItem";
            this.thingsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.thingsToolStripMenuItem.Text = "Things";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(596, 178);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(233, 115);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(225, 87);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(225, 87);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "Show TaskDialog";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTdResult
            // 
            this.labelTdResult.AutoSize = true;
            this.labelTdResult.Location = new System.Drawing.Point(44, 312);
            this.labelTdResult.Name = "labelTdResult";
            this.labelTdResult.Size = new System.Drawing.Size(105, 15);
            this.labelTdResult.TabIndex = 10;
            this.labelTdResult.Text = "Task Dialog Result:";
            // 
            // commandLink1
            // 
            this.commandLink1.Description = "This is the description";
            this.commandLink1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.commandLink1.Location = new System.Drawing.Point(341, 312);
            this.commandLink1.Name = "commandLink1";
            this.commandLink1.ShowShieldIcon = false;
            this.commandLink1.Size = new System.Drawing.Size(206, 73);
            this.commandLink1.TabIndex = 8;
            this.commandLink1.Text = "commandLink1";
            this.commandLink1.UseVisualStyleBackColor = true;
            // 
            // searchBox1
            // 
            this.searchBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchBox1.BackColor = System.Drawing.SystemColors.Window;
            this.searchBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox1.CueBanner = "";
            this.searchBox1.Location = new System.Drawing.Point(48, 178);
            this.searchBox1.MinimumSize = new System.Drawing.Size(116, 23);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.SelectedText = "";
            this.searchBox1.SelectionLength = 0;
            this.searchBox1.SelectionStart = 0;
            this.searchBox1.Size = new System.Drawing.Size(240, 23);
            this.searchBox1.TabIndex = 7;
            this.searchBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // commandButton1
            // 
            this.commandButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.commandButton1.Image = ((System.Drawing.Image)(resources.GetObject("commandButton1.Image")));
            this.commandButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.commandButton1.Location = new System.Drawing.Point(654, 47);
            this.commandButton1.Name = "commandButton1";
            this.commandButton1.ShowShieldIcon = true;
            this.commandButton1.Size = new System.Drawing.Size(194, 29);
            this.commandButton1.TabIndex = 6;
            this.commandButton1.Text = "commandButton1";
            this.commandButton1.UseVisualStyleBackColor = true;
            // 
            // editControl1
            // 
            this.editControl1.CueBanner = "Enter search text";
            this.editControl1.Location = new System.Drawing.Point(48, 120);
            this.editControl1.Name = "editControl1";
            this.editControl1.ShowCueOnFocus = false;
            this.editControl1.Size = new System.Drawing.Size(240, 23);
            this.editControl1.TabIndex = 2;
            this.editControl1.Validating += new System.ComponentModel.CancelEventHandler(this.editControl1_Validating);
            // 
            // splitButton1
            // 
            this.splitButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.splitButton1.Location = new System.Drawing.Point(48, 67);
            this.splitButton1.Name = "splitButton1";
            this.splitButton1.ShowShieldIcon = false;
            this.splitButton1.Size = new System.Drawing.Size(110, 27);
            this.splitButton1.SplitMenu = this.contextMenuStrip1;
            this.splitButton1.TabIndex = 1;
            this.splitButton1.Text = "splitButton1";
            this.splitButton1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(453, 67);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Node4";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Node2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.labelTdResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.commandLink1);
            this.Controls.Add(this.searchBox1);
            this.Controls.Add(this.commandButton1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editControl1);
            this.Controls.Add(this.splitButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thingsToolStripMenuItem;
        private Windows.Controls.SplitButton splitButton1;
        private Windows.Controls.EditControl editControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Windows.Controls.CommandButton commandButton1;
        private Windows.Controls.SearchBox searchBox1;
        private Windows.Controls.CommandLink commandLink1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelTdResult;
        private Windows.Controls.TreeView treeView1;
    }
}

