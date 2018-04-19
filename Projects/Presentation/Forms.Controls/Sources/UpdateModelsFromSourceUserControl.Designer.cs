namespace DotNetScaffolder.Presentation.Forms.Controls.Sources
{
    partial class UpdateModelsFromSourceUserControl
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("BankAccount");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Bank Transfers");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Book");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Country");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("dbo", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Tables", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Country");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Customer");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Order");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("OrderDetails");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("dbo", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Tables", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Tables");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TreeViewAdd = new FormControls.TreeView.MultiSelectTreeView.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TreeViewRefresh = new FormControls.TreeView.MultiSelectTreeView.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.TreeViewDelete = new FormControls.TreeView.MultiSelectTreeView.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 566);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TreeViewAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(894, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 482);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select items to add to the model";
            // 
            // TreeViewAdd
            // 
            this.TreeViewAdd.CheckBoxes = true;
            this.TreeViewAdd.Location = new System.Drawing.Point(10, 11);
            this.TreeViewAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TreeViewAdd.Name = "TreeViewAdd";
            treeNode1.Name = "Node2";
            treeNode1.Text = "BankAccount";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Bank Transfers";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Book";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Country";
            treeNode5.Name = "Node1";
            treeNode5.Text = "dbo";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Tables";
            this.TreeViewAdd.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.TreeViewAdd.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.TreeViewAdd.SelectionMode = FormControls.TreeView.MultiSelectTreeView.TreeViewSelectionMode.SingleSelect;
            this.TreeViewAdd.Size = new System.Drawing.Size(836, 444);
            this.TreeViewAdd.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.TreeViewRefresh);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(894, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Refresh";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 485);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "These items were found in the database and will be refreshed in the model";
            // 
            // TreeViewRefresh
            // 
            this.TreeViewRefresh.CheckBoxes = true;
            this.TreeViewRefresh.Location = new System.Drawing.Point(26, 18);
            this.TreeViewRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TreeViewRefresh.Name = "TreeViewRefresh";
            treeNode7.Name = "Node2";
            treeNode7.Text = "Country";
            treeNode8.Name = "Node4";
            treeNode8.Text = "Customer";
            treeNode9.Name = "Node5";
            treeNode9.Text = "Order";
            treeNode10.Name = "Node6";
            treeNode10.Text = "OrderDetails";
            treeNode11.Name = "Node1";
            treeNode11.Text = "dbo";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Tables";
            this.TreeViewRefresh.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.TreeViewRefresh.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.TreeViewRefresh.SelectionMode = FormControls.TreeView.MultiSelectTreeView.TreeViewSelectionMode.SingleSelect;
            this.TreeViewRefresh.Size = new System.Drawing.Size(836, 444);
            this.TreeViewRefresh.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.TreeViewDelete);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(894, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 485);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(601, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "These items could not be found in the database and will be removed from the model" +
    ".";
            // 
            // TreeViewDelete
            // 
            this.TreeViewDelete.CheckBoxes = true;
            this.TreeViewDelete.Location = new System.Drawing.Point(26, 18);
            this.TreeViewDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TreeViewDelete.Name = "TreeViewDelete";
            treeNode13.Name = "Node0";
            treeNode13.Text = "Tables";
            this.TreeViewDelete.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.TreeViewDelete.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.TreeViewDelete.SelectionMode = FormControls.TreeView.MultiSelectTreeView.TreeViewSelectionMode.SingleSelect;
            this.TreeViewDelete.Size = new System.Drawing.Size(836, 444);
            this.TreeViewDelete.TabIndex = 2;
            // 
            // UpdateModelsFromSourceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UpdateModelsFromSourceUserControl";
            this.Size = new System.Drawing.Size(912, 581);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private FormControls.TreeView.MultiSelectTreeView.TreeView TreeViewAdd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private FormControls.TreeView.MultiSelectTreeView.TreeView TreeViewRefresh;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private FormControls.TreeView.MultiSelectTreeView.TreeView TreeViewDelete;
    }
}
