namespace DotNetScaffolder.Presentation.Forms.Controls
{
    partial class DomainMenuUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Id");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Name");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Surname");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Password");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Columns", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Relationships");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Users", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("RoleName");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Columns", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Relationships");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Roles", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("UserId");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("RoleName");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Columns", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("UserRole", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Security", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode12,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Tables", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.DomainTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // DomainTreeView
            // 
            this.DomainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DomainTreeView.Location = new System.Drawing.Point(0, 0);
            this.DomainTreeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DomainTreeView.Name = "DomainTreeView";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Id";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Name";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Surname";
            treeNode4.Name = "Node4";
            treeNode4.Text = "User";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Password";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Columns";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Relationships";
            treeNode8.Name = "Node2";
            treeNode8.Text = "Users";
            treeNode9.Name = "Node5";
            treeNode9.Text = "RoleName";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Columns";
            treeNode11.Name = "Node4";
            treeNode11.Text = "Relationships";
            treeNode12.Name = "Node3";
            treeNode12.Text = "Roles";
            treeNode13.Name = "Node8";
            treeNode13.Text = "UserId";
            treeNode14.Name = "Node9";
            treeNode14.Text = "RoleName";
            treeNode15.Name = "Node7";
            treeNode15.Text = "Columns";
            treeNode16.Name = "Node6";
            treeNode16.Text = "UserRole";
            treeNode17.Name = "Node1";
            treeNode17.Text = "Security";
            treeNode18.Name = "Node0";
            treeNode18.Text = "Tables";
            this.DomainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.DomainTreeView.Size = new System.Drawing.Size(575, 781);
            this.DomainTreeView.TabIndex = 3;
            this.DomainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DomainTreeView_AfterSelect);
            this.DomainTreeView.Click += new System.EventHandler(this.DomainTreeView_Click);
            // 
            // DomainMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DomainTreeView);
            this.Name = "DomainMenuUserControl";
            this.Size = new System.Drawing.Size(575, 781);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView DomainTreeView;
    }
}
