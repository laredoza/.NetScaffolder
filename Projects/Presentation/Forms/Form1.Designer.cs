namespace DotNetScaffolder.Presentation.Forms
{
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;
    using DotNetScaffolder.Presentation.Forms.Controls;
    using DotNetScaffolder.Presentation.Forms.Controls.Packages;
    using DotNetScaffolder.Presentation.Forms.Controls.Project;
    using DotNetScaffolder.Presentation.Forms.Controls.Templates;

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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ProjectDetailsUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.Project.ProjectDetailsUserControl();
            this.ProjectDomainUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.Project.ProjectDomainUserControl();
            this.projectDomainDetailsUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.Project.ProjectDomainDetailsUserControl();
            this.packageUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.Packages.PackageUserControl();
            this.TemplateManagementUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.Templates.TemplateManagementUserControl();
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
            this.menuStrip1.Size = new System.Drawing.Size(1186, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.LblPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 638);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 44);
            this.panel1.TabIndex = 7;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(1023, 11);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(1103, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblPath
            // 
            this.LblPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblPath.AutoSize = true;
            this.LblPath.Location = new System.Drawing.Point(9, 16);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(0, 13);
            this.LblPath.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1186, 614);
            this.panel2.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1186, 614);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1178, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Project";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "These details are used to render layers/files for the data model.The layers are d" +
    "etermined by the selected package.";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.ProjectDetailsUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 524);
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
            this.groupBox2.Location = new System.Drawing.Point(580, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 524);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Domains";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.packageUserControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1377, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Packages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Packages consist of templates.Each template will be used to render files/layers.";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.TemplateManagementUserControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1377, 588);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Templates";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "A template is used specify a T4 script.This script will then be used to generate " +
    "a file/layer.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Model files|*.mdl";
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
            this.ProjectDetailsUserControl1.Size = new System.Drawing.Size(559, 468);
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
            this.projectDomainDetailsUserControl1.ConfigPackage = null;
            this.projectDomainDetailsUserControl1.DataSourceInitialized = false;
            this.projectDomainDetailsUserControl1.DomainName = "";
            this.projectDomainDetailsUserControl1.Loading = false;
            this.projectDomainDetailsUserControl1.Location = new System.Drawing.Point(7, 20);
            this.projectDomainDetailsUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectDomainDetailsUserControl1.Name = "projectDomainDetailsUserControl1";
            this.projectDomainDetailsUserControl1.Packages = null;
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
            // packageUserControl1
            // 
            this.packageUserControl1.DataSource = null;
            this.packageUserControl1.DomainDefinition = null;
            this.packageUserControl1.Location = new System.Drawing.Point(6, 6);
            this.packageUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.packageUserControl1.Name = "packageUserControl1";
            this.packageUserControl1.SelectedPackage = null;
            this.packageUserControl1.Size = new System.Drawing.Size(975, 514);
            this.packageUserControl1.TabIndex = 0;
            this.packageUserControl1.Templates = ((System.Collections.Generic.List<DotNetScaffolder.Mapping.MetaData.Project.Packages.Template>)(resources.GetObject("packageUserControl1.Templates")));
            // 
            // TemplateManagementUserControl1
            // 
            this.TemplateManagementUserControl1.DataSource = null;
            this.TemplateManagementUserControl1.Location = new System.Drawing.Point(9, 8);
            this.TemplateManagementUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TemplateManagementUserControl1.Name = "TemplateManagementUserControl1";
            this.TemplateManagementUserControl1.Packages = null;
            this.TemplateManagementUserControl1.ProjectDefinition = null;
            this.TemplateManagementUserControl1.SelectedPackage = null;
            this.TemplateManagementUserControl1.Size = new System.Drawing.Size(938, 506);
            this.TemplateManagementUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1186, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(20, 682);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".NetScaffolder - Code Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
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
        private PackageUserControl packageUserControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private TemplateManagementUserControl TemplateManagementUserControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        //public ManageCollectionsTreeViewUserControl manageCollectionsTreeViewUserControl1;
    }
}

