namespace DotNetScaffolder.Presentation.Forms.Controls
{
    using System.Windows.Forms;

    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using FormControls.TreeView;

    partial class ManageCollectionsTreeViewUserControl : UserControl
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
            this.BtnDown = new System.Windows.Forms.Button();
            this.BtnAddGroup = new System.Windows.Forms.Button();
            this.BtnUp = new System.Windows.Forms.Button();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.treeView1 = new FormControls.TreeView.HierarchyTreeView();
            this.SuspendLayout();
            // 
            // BtnDown
            // 
            this.BtnDown.Location = new System.Drawing.Point(278, 46);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(75, 23);
            this.BtnDown.TabIndex = 9;
            this.BtnDown.Text = "Down";
            this.BtnDown.UseVisualStyleBackColor = true;
            // 
            // BtnAddGroup
            // 
            this.BtnAddGroup.Location = new System.Drawing.Point(17, 322);
            this.BtnAddGroup.Name = "BtnAddGroup";
            this.BtnAddGroup.Size = new System.Drawing.Size(75, 23);
            this.BtnAddGroup.TabIndex = 8;
            this.BtnAddGroup.Text = "Add Group";
            this.BtnAddGroup.UseVisualStyleBackColor = true;
            // 
            // BtnUp
            // 
            this.BtnUp.Location = new System.Drawing.Point(278, 17);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(75, 23);
            this.BtnUp.TabIndex = 10;
            this.BtnUp.Text = "Up";
            this.BtnUp.UseVisualStyleBackColor = true;
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.Location = new System.Drawing.Point(98, 322);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(84, 23);
            this.BtnAddItem.TabIndex = 11;
            this.BtnAddItem.Text = "Add Template";
            this.BtnAddItem.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(278, 75);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.AddGroupEnabled = false;
            this.treeView1.AddItemEnabled = false;
            this.treeView1.Data = null;
            this.treeView1.DeleteEnabled = false;
            this.treeView1.DownEnabled = false;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(269, 313);
            this.treeView1.TabIndex = 7;
            this.treeView1.UpEnabled = false;
            // 
            // ManageCollectionsTreeViewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAddItem);
            this.Controls.Add(this.BtnUp);
            this.Controls.Add(this.BtnDown);
            this.Controls.Add(this.BtnAddGroup);
            this.Controls.Add(this.treeView1);
            this.Name = "ManageCollectionsTreeViewUserControl";
            this.Size = new System.Drawing.Size(364, 368);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.Button BtnAddGroup;
        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.Button BtnDelete;
        private HierarchyTreeView treeView1;
    }
}
