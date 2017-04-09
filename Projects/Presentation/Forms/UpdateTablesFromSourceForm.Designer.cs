namespace DotNetScaffolder.Presentation.Forms
{
    partial class UpdateTablesFromSourceForm
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
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("BankAccount");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Bank Transfers");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Book");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Country");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("dbo", new System.Windows.Forms.TreeNode[] {
            treeNode92,
            treeNode93,
            treeNode94,
            treeNode95});
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Tables", new System.Windows.Forms.TreeNode[] {
            treeNode96});
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Country");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Customer");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Order");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("OrderDetails");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("dbo", new System.Windows.Forms.TreeNode[] {
            treeNode98,
            treeNode99,
            treeNode100,
            treeNode101});
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Tables", new System.Windows.Forms.TreeNode[] {
            treeNode102});
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Tables");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.treeView1 = new FormControls.TreeView.MultiSelectTreeView.TreeView();
            this.treeView2 = new FormControls.TreeView.MultiSelectTreeView.TreeView();
            this.treeView3 = new FormControls.TreeView.MultiSelectTreeView.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.treeView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Refresh";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.treeView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(593, 342);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(7, 7);
            this.treeView1.Name = "treeView1";
            treeNode92.Name = "Node2";
            treeNode92.Text = "BankAccount";
            treeNode93.Name = "Node4";
            treeNode93.Text = "Bank Transfers";
            treeNode94.Name = "Node5";
            treeNode94.Text = "Book";
            treeNode95.Name = "Node6";
            treeNode95.Text = "Country";
            treeNode96.Name = "Node1";
            treeNode96.Text = "dbo";
            treeNode97.Name = "Node0";
            treeNode97.Text = "Tables";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode97});
            this.treeView1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.SelectionMode = FormControls.TreeView.MultiSelectTreeView.TreeViewSelectionMode.SingleSelect;
            this.treeView1.Size = new System.Drawing.Size(559, 290);
            this.treeView1.TabIndex = 0;
            // 
            // treeView2
            // 
            this.treeView2.CheckBoxes = true;
            this.treeView2.Location = new System.Drawing.Point(17, 12);
            this.treeView2.Name = "treeView2";
            treeNode98.Name = "Node2";
            treeNode98.Text = "Country";
            treeNode99.Name = "Node4";
            treeNode99.Text = "Customer";
            treeNode100.Name = "Node5";
            treeNode100.Text = "Order";
            treeNode101.Name = "Node6";
            treeNode101.Text = "OrderDetails";
            treeNode102.Name = "Node1";
            treeNode102.Text = "dbo";
            treeNode103.Name = "Node0";
            treeNode103.Text = "Tables";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode103});
            this.treeView2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.treeView2.SelectionMode = FormControls.TreeView.MultiSelectTreeView.TreeViewSelectionMode.SingleSelect;
            this.treeView2.Size = new System.Drawing.Size(559, 290);
            this.treeView2.TabIndex = 1;
            // 
            // treeView3
            // 
            this.treeView3.CheckBoxes = true;
            this.treeView3.Location = new System.Drawing.Point(17, 12);
            this.treeView3.Name = "treeView3";
            treeNode104.Name = "Node0";
            treeNode104.Text = "Tables";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode104});
            this.treeView3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.treeView3.SelectionMode = FormControls.TreeView.MultiSelectTreeView.TreeViewSelectionMode.SingleSelect;
            this.treeView3.Size = new System.Drawing.Size(559, 290);
            this.treeView3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select items to add to the model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "These items were found in the database and will be refreshed in the model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "These items could not be found in the database and will be removed from the model" +
    ".";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(507, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // UpdateTablesFromSourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 436);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Name = "UpdateTablesFromSourceForm";
            this.Text = "Update Tables From Source";
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private FormControls.TreeView.MultiSelectTreeView.TreeView treeView1;
        private FormControls.TreeView.MultiSelectTreeView.TreeView treeView2;
        private FormControls.TreeView.MultiSelectTreeView.TreeView treeView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}