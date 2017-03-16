namespace DotNetScaffolder.Presentation.Forms.Controls
{
    partial class ManagePackageUserControl
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ManageCollectionsTreeViewUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.ManageCollectionsTreeViewUserControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PackageDetailsUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.PackageDetailsUserControl();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ManageCollectionsTreeViewUserControl1);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(407, 404);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Packages";
            // 
            // ManageCollectionsTreeViewUserControl1
            // 
            this.ManageCollectionsTreeViewUserControl1.AfterSelect = null;
            this.ManageCollectionsTreeViewUserControl1.BeforeSelect = null;
            this.ManageCollectionsTreeViewUserControl1.BtnAddGroupClick = null;
            this.ManageCollectionsTreeViewUserControl1.BtnAddItemClick = null;
            this.ManageCollectionsTreeViewUserControl1.BtnDeleteClick = null;
            this.ManageCollectionsTreeViewUserControl1.BtnDownClick = null;
            this.ManageCollectionsTreeViewUserControl1.BtnUpClick = null;
            this.ManageCollectionsTreeViewUserControl1.CollectionType = DotNetScaffolder.Presentation.Forms.Controls.Enum.TreeViewType.Package;
            this.ManageCollectionsTreeViewUserControl1.DataSource = null;
            this.ManageCollectionsTreeViewUserControl1.Location = new System.Drawing.Point(15, 19);
            this.ManageCollectionsTreeViewUserControl1.Name = "ManageCollectionsTreeViewUserControl1";
            this.ManageCollectionsTreeViewUserControl1.Size = new System.Drawing.Size(364, 368);
            this.ManageCollectionsTreeViewUserControl1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PackageDetailsUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(426, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 404);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // PackageDetailsUserControl1
            // 
            this.PackageDetailsUserControl1.DataSource = null;
            this.PackageDetailsUserControl1.Location = new System.Drawing.Point(15, 19);
            this.PackageDetailsUserControl1.Name = "PackageDetailsUserControl1";
            this.PackageDetailsUserControl1.PackageName = "";
            this.PackageDetailsUserControl1.Size = new System.Drawing.Size(451, 368);
            this.PackageDetailsUserControl1.TabIndex = 5;
            this.PackageDetailsUserControl1.TemplateEnabled = false;
            this.PackageDetailsUserControl1.TreeNode = null;
            this.PackageDetailsUserControl1.Version = 1D;
            // 
            // ManagePackageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "ManagePackageUserControl";
            this.Size = new System.Drawing.Size(926, 429);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private ManageCollectionsTreeViewUserControl ManageCollectionsTreeViewUserControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private PackageDetailsUserControl PackageDetailsUserControl1;
    }
}
