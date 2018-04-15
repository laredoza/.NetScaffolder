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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblPath = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProjectDetailsUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.ProjectDetailsUserControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProjectDomainUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.ProjectDomainUserControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.projectDomainDetailsUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.ProjectDomainDetailsUserControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ManagePackageUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.ManagePackageUserControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TemplateManagementUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.TemplateManagementUserControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1533, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.LblPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 982);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1533, 68);
            this.panel1.TabIndex = 7;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(1288, 17);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 35);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(1408, 17);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(112, 35);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblPath
            // 
            this.LblPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblPath.AutoSize = true;
            this.LblPath.Location = new System.Drawing.Point(13, 24);
            this.LblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(142, 20);
            this.LblPath.TabIndex = 5;
            this.LblPath.Text = "c:\\Models\\Web.mdl";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1533, 947);
            this.panel2.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1533, 947);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1525, 914);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Project";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.ProjectDetailsUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(582, 893);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Details";
            // 
            // ProjectDetailsUserControl1
            // 
            this.ProjectDetailsUserControl1.BaseNameSpace = "";
            this.ProjectDetailsUserControl1.Changed = false;
            this.ProjectDetailsUserControl1.GroupBy = DotNetScaffolder.Mapping.MetaData.Enum.GenerationType.Domain;
            this.ProjectDetailsUserControl1.Location = new System.Drawing.Point(9, 31);
            this.ProjectDetailsUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ProjectDetailsUserControl1.Name = "ProjectDetailsUserControl1";
            this.ProjectDetailsUserControl1.OutputFolder = "";
            this.ProjectDetailsUserControl1.Project = null;
            this.ProjectDetailsUserControl1.Size = new System.Drawing.Size(573, 189);
            this.ProjectDetailsUserControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ProjectDomainUserControl1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(600, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(896, 893);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Domains";
            // 
            // ProjectDomainUserControl1
            // 
            this.ProjectDomainUserControl1.ApplicationService = null;
            this.ProjectDomainUserControl1.Changed = false;
            this.ProjectDomainUserControl1.Location = new System.Drawing.Point(24, 31);
            this.ProjectDomainUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ProjectDomainUserControl1.Name = "ProjectDomainUserControl1";
            this.ProjectDomainUserControl1.Size = new System.Drawing.Size(486, 163);
            this.ProjectDomainUserControl1.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.projectDomainDetailsUserControl1);
            this.groupBox3.Location = new System.Drawing.Point(24, 200);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(729, 368);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Domain Details";
            // 
            // projectDomainDetailsUserControl1
            // 
            this.projectDomainDetailsUserControl1.ApplicationService = null;
            this.projectDomainDetailsUserControl1.DomainName = "";
            this.projectDomainDetailsUserControl1.Location = new System.Drawing.Point(10, 31);
            this.projectDomainDetailsUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.projectDomainDetailsUserControl1.Name = "projectDomainDetailsUserControl1";
            this.projectDomainDetailsUserControl1.Packages = null;
            this.projectDomainDetailsUserControl1.SelectedCollectionOptionId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.projectDomainDetailsUserControl1.SelectedDomain = null;
            this.projectDomainDetailsUserControl1.SelectedDriver = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.projectDomainDetailsUserControl1.SelectedDriverType = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.projectDomainDetailsUserControl1.SelectedNamingConvention = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.projectDomainDetailsUserControl1.SelectedPackage = null;
            this.projectDomainDetailsUserControl1.SelectedSourceType = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.projectDomainDetailsUserControl1.Size = new System.Drawing.Size(664, 325);
            this.projectDomainDetailsUserControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ManagePackageUserControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1525, 914);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Packages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ManagePackageUserControl1
            // 
            this.ManagePackageUserControl1.DataSource = null;
            this.ManagePackageUserControl1.Location = new System.Drawing.Point(9, 9);
            this.ManagePackageUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ManagePackageUserControl1.Name = "ManagePackageUserControl1";
            this.ManagePackageUserControl1.Size = new System.Drawing.Size(1462, 660);
            this.ManagePackageUserControl1.TabIndex = 0;
            this.ManagePackageUserControl1.Templates = ((System.Collections.Generic.List<DotNetScaffolder.Mapping.MetaData.Project.Packages.Template>)(resources.GetObject("ManagePackageUserControl1.Templates")));
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TemplateManagementUserControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1525, 914);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Templates";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TemplateManagementUserControl1
            // 
            this.TemplateManagementUserControl1.DataSource = null;
            this.TemplateManagementUserControl1.Location = new System.Drawing.Point(16, 11);
            this.TemplateManagementUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TemplateManagementUserControl1.Name = "TemplateManagementUserControl1";
            this.TemplateManagementUserControl1.Size = new System.Drawing.Size(1407, 637);
            this.TemplateManagementUserControl1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1533, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(22, 1078);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private TemplateDetailsUserControl TemplateDetailsUserControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ProjectDetailsUserControl ProjectDetailsUserControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ProjectDomainUserControl ProjectDomainUserControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private ProjectDomainDetailsUserControl projectDomainDetailsUserControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private ManagePackageUserControl ManagePackageUserControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private TemplateManagementUserControl TemplateManagementUserControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        //public ManageCollectionsTreeViewUserControl manageCollectionsTreeViewUserControl1;
    }
}

