namespace DotNetScaffolder.Presentation.Forms
{
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;
    using DotNetScaffolder.Presentation.Forms.Controls;

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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.ProjectDetailsUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.ProjectDetailsUserControl();
            this.ProjectDomainUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.ProjectDomainUserControl();
            this.projectDomainDetailsUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.ProjectDomainDetailsUserControl();
            this.ManagePackageUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.ManagePackageUserControl();
            this.TemplateManagementUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.TemplateManagementUserControl();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 493);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1014, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Project";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.ProjectDetailsUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 375);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ProjectDomainUserControl1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(400, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 375);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Domains";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.projectDomainDetailsUserControl1);
            this.groupBox3.Location = new System.Drawing.Point(16, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 239);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Domain Details";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ManagePackageUserControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1014, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Packages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TemplateManagementUserControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1014, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Templates";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1022, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(926, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "c:\\Models\\Web.mdl";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(833, 526);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ProjectDetailsUserControl1
            // 
            this.ProjectDetailsUserControl1.BaseNameSpace = "";
            this.ProjectDetailsUserControl1.Changed = false;
            this.ProjectDetailsUserControl1.GroupBy = DotNetScaffolder.Mapping.MetaData.Enum.GenerationType.Domain;
            this.ProjectDetailsUserControl1.Location = new System.Drawing.Point(6, 20);
            this.ProjectDetailsUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectDetailsUserControl1.Name = "ProjectDetailsUserControl1";
            this.ProjectDetailsUserControl1.OutputFolder = "";
            this.ProjectDetailsUserControl1.Project = null;
            this.ProjectDetailsUserControl1.Size = new System.Drawing.Size(382, 123);
            this.ProjectDetailsUserControl1.TabIndex = 0;
            // 
            // ProjectDomainUserControl1
            // 
            this.ProjectDomainUserControl1.ApplicationService = null;
            this.ProjectDomainUserControl1.Changed = false;
            this.ProjectDomainUserControl1.Location = new System.Drawing.Point(16, 20);
            this.ProjectDomainUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectDomainUserControl1.Name = "ProjectDomainUserControl1";
            this.ProjectDomainUserControl1.Size = new System.Drawing.Size(324, 106);
            this.ProjectDomainUserControl1.TabIndex = 19;
            // 
            // projectDomainDetailsUserControl1
            // 
            this.projectDomainDetailsUserControl1.ApplicationService = null;
            this.projectDomainDetailsUserControl1.DomainName = "";
            this.projectDomainDetailsUserControl1.Location = new System.Drawing.Point(7, 20);
            this.projectDomainDetailsUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectDomainDetailsUserControl1.Name = "projectDomainDetailsUserControl1";
            this.projectDomainDetailsUserControl1.SelectedDomain = null;
            this.projectDomainDetailsUserControl1.SelectedDriver = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.projectDomainDetailsUserControl1.SelectedDriverType = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.projectDomainDetailsUserControl1.SelectedNamingConvention = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.projectDomainDetailsUserControl1.SelectedSourceType = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.projectDomainDetailsUserControl1.Size = new System.Drawing.Size(443, 211);
            this.projectDomainDetailsUserControl1.TabIndex = 0;
            // 
            // ManagePackageUserControl1
            // 
            this.ManagePackageUserControl1.DataSource = null;
            this.ManagePackageUserControl1.Location = new System.Drawing.Point(6, 6);
            this.ManagePackageUserControl1.Name = "ManagePackageUserControl1";
            this.ManagePackageUserControl1.Size = new System.Drawing.Size(975, 429);
            this.ManagePackageUserControl1.TabIndex = 0;
            // 
            // TemplateManagementUserControl1
            // 
            this.TemplateManagementUserControl1.DataSource = null;
            this.TemplateManagementUserControl1.Location = new System.Drawing.Point(11, 7);
            this.TemplateManagementUserControl1.Name = "TemplateManagementUserControl1";
            this.TemplateManagementUserControl1.Size = new System.Drawing.Size(938, 414);
            this.TemplateManagementUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 584);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Code Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private ProjectDetailsUserControl ProjectDetailsUserControl1;
        private ProjectDomainUserControl ProjectDomainUserControl1;
        private ProjectDomainDetailsUserControl projectDomainDetailsUserControl1;
        private TemplateDetailsUserControl TemplateDetailsUserControl1;
        private TemplateManagementUserControl TemplateManagementUserControl1;
        private ManagePackageUserControl ManagePackageUserControl1;
        //public ManageCollectionsTreeViewUserControl manageCollectionsTreeViewUserControl1;
    }
}

