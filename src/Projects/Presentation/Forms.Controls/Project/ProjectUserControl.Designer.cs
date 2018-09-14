namespace DotNetScaffolder.Presentation.Forms.Controls.Project
{
    partial class ProjectUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectUserControl));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProjectDetailsUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.Project.ProjectDetailsUserControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProjectDomainUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.Project.ProjectDomainUserControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.projectDomainDetailsUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.Project.ProjectDomainDetailsUserControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "These details are used to render layers/files for the data model.The layers are d" +
    "etermined by the selected package.";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.ProjectDetailsUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 529);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Details";
            // 
            // ProjectDetailsUserControl1
            // 
            this.ProjectDetailsUserControl1.BaseNameSpace = "";
            this.ProjectDetailsUserControl1.Changed = false;
            this.ProjectDetailsUserControl1.Company = "";
            this.ProjectDetailsUserControl1.HeaderText = "";
            this.ProjectDetailsUserControl1.License = "";
            this.ProjectDetailsUserControl1.Location = new System.Drawing.Point(6, 20);
            this.ProjectDetailsUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectDetailsUserControl1.Name = "ProjectDetailsUserControl1";
            this.ProjectDetailsUserControl1.OutputFolder = "";
            this.ProjectDetailsUserControl1.Project = null;
            this.ProjectDetailsUserControl1.Size = new System.Drawing.Size(559, 498);
            this.ProjectDetailsUserControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ProjectDomainUserControl1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(575, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 529);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Domains";
            // 
            // ProjectDomainUserControl1
            // 
            this.ProjectDomainUserControl1.ApplicationService = null;
            this.ProjectDomainUserControl1.Changed = false;
            this.ProjectDomainUserControl1.Location = new System.Drawing.Point(16, 20);
            this.ProjectDomainUserControl1.ManageDataTypesEnabled = true;
            this.ProjectDomainUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectDomainUserControl1.Name = "ProjectDomainUserControl1";
            this.ProjectDomainUserControl1.Size = new System.Drawing.Size(324, 106);
            this.ProjectDomainUserControl1.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.projectDomainDetailsUserControl1);
            this.groupBox3.Location = new System.Drawing.Point(16, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 388);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Domain Details";
            // 
            // projectDomainDetailsUserControl1
            // 
            this.projectDomainDetailsUserControl1.ApplicationService = null;
            this.projectDomainDetailsUserControl1.ConfigPackage = null;
            this.projectDomainDetailsUserControl1.DomainName = "";
            this.projectDomainDetailsUserControl1.Loading = false;
            this.projectDomainDetailsUserControl1.Location = new System.Drawing.Point(7, 20);
            this.projectDomainDetailsUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectDomainDetailsUserControl1.Name = "projectDomainDetailsUserControl1";
            this.projectDomainDetailsUserControl1.Packages = null;
            this.projectDomainDetailsUserControl1.ProjectDomainUserControl = null;
            this.projectDomainDetailsUserControl1.SavePath = null;
            this.projectDomainDetailsUserControl1.SelectedCollectionOptionId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.projectDomainDetailsUserControl1.SelectedDomain = null;
            this.projectDomainDetailsUserControl1.SelectedDriverTypes = ((System.Collections.Generic.List<System.Guid>)(resources.GetObject("projectDomainDetailsUserControl1.SelectedDriverTypes")));
            this.projectDomainDetailsUserControl1.SelectedNamingConvention = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.projectDomainDetailsUserControl1.SelectedPackage = null;
            this.projectDomainDetailsUserControl1.SelectedSourceType = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.projectDomainDetailsUserControl1.Size = new System.Drawing.Size(557, 346);
            this.projectDomainDetailsUserControl1.TabIndex = 0;
            this.projectDomainDetailsUserControl1.UpdatePackageVisible = true;
            // 
            // ProjectUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ProjectUserControl";
            this.Size = new System.Drawing.Size(1198, 571);
            //this.Load += new System.EventHandler(this.ProjectUserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ProjectDetailsUserControl ProjectDetailsUserControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ProjectDomainUserControl ProjectDomainUserControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private ProjectDomainDetailsUserControl projectDomainDetailsUserControl1;
    }
}
