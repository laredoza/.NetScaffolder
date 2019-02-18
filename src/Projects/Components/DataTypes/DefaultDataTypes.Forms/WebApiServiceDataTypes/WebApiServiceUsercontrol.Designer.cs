namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Forms.WebApiServiceDataTypes
{
    partial class WebApiServiceUserControl
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
            this.btnNew = new System.Windows.Forms.Button();
            this.gbAdditionalNamespaces = new System.Windows.Forms.GroupBox();
            this.txtNamespaces = new System.Windows.Forms.TextBox();
            this.TreeviewContextModels = new FormControls.TreeView.MultiSelectTreeView.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputPath = new System.Windows.Forms.TextBox();
            this.OutputFolder = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.InheritFromInterface = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.Namespace = new System.Windows.Forms.TextBox();
            this.WebApiName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOutputPathApplicationService = new System.Windows.Forms.TextBox();
            this.TxtOutputFolderApplicationService = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtInheritFromApplicationService = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNamespaceApplicationService = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbAdditionalNamespaces.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(507, 232);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 58;
            this.btnNew.Tag = "Add";
            this.btnNew.Text = "Add";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gbAdditionalNamespaces
            // 
            this.gbAdditionalNamespaces.Controls.Add(this.txtNamespaces);
            this.gbAdditionalNamespaces.Location = new System.Drawing.Point(501, 3);
            this.gbAdditionalNamespaces.Name = "gbAdditionalNamespaces";
            this.gbAdditionalNamespaces.Size = new System.Drawing.Size(251, 206);
            this.gbAdditionalNamespaces.TabIndex = 60;
            this.gbAdditionalNamespaces.TabStop = false;
            this.gbAdditionalNamespaces.Text = "Additional Namespaces:";
            // 
            // txtNamespaces
            // 
            this.txtNamespaces.AcceptsReturn = true;
            this.txtNamespaces.Location = new System.Drawing.Point(6, 19);
            this.txtNamespaces.Multiline = true;
            this.txtNamespaces.Name = "txtNamespaces";
            this.txtNamespaces.Size = new System.Drawing.Size(239, 179);
            this.txtNamespaces.TabIndex = 0;
            // 
            // TreeviewContextModels
            // 
            this.TreeviewContextModels.CheckBoxes = true;
            this.TreeviewContextModels.Location = new System.Drawing.Point(7, 217);
            this.TreeviewContextModels.Name = "TreeviewContextModels";
            this.TreeviewContextModels.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.TreeviewContextModels.SelectionMode = FormControls.TreeView.MultiSelectTreeView.TreeViewSelectionMode.SingleSelect;
            this.TreeviewContextModels.Size = new System.Drawing.Size(492, 258);
            this.TreeviewContextModels.TabIndex = 58;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 188);
            this.tabControl1.TabIndex = 59;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.OutputPath);
            this.tabPage1.Controls.Add(this.OutputFolder);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.InheritFromInterface);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.Namespace);
            this.tabPage1.Controls.Add(this.WebApiName);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 162);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Web Api";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.TxtOutputPathApplicationService);
            this.tabPage2.Controls.Add(this.TxtOutputFolderApplicationService);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TxtInheritFromApplicationService);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.TxtNamespaceApplicationService);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Service";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Output Path:";
            // 
            // OutputPath
            // 
            this.OutputPath.Location = new System.Drawing.Point(97, 128);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.Size = new System.Drawing.Size(301, 20);
            this.OutputPath.TabIndex = 67;
            // 
            // OutputFolder
            // 
            this.OutputFolder.Location = new System.Drawing.Point(98, 74);
            this.OutputFolder.Name = "OutputFolder";
            this.OutputFolder.Size = new System.Drawing.Size(171, 20);
            this.OutputFolder.TabIndex = 65;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 13);
            this.label23.TabIndex = 59;
            this.label23.Text = "WebApi Name:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(22, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 60;
            this.label24.Text = "Namespace:";
            // 
            // InheritFromInterface
            // 
            this.InheritFromInterface.Location = new System.Drawing.Point(98, 102);
            this.InheritFromInterface.Name = "InheritFromInterface";
            this.InheritFromInterface.Size = new System.Drawing.Size(171, 20);
            this.InheritFromInterface.TabIndex = 66;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 77);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 13);
            this.label25.TabIndex = 61;
            this.label25.Text = "Output Folder:";
            // 
            // Namespace
            // 
            this.Namespace.Location = new System.Drawing.Point(98, 45);
            this.Namespace.Name = "Namespace";
            this.Namespace.Size = new System.Drawing.Size(171, 20);
            this.Namespace.TabIndex = 64;
            // 
            // WebApiName
            // 
            this.WebApiName.Location = new System.Drawing.Point(98, 19);
            this.WebApiName.Name = "WebApiName";
            this.WebApiName.Size = new System.Drawing.Size(171, 20);
            this.WebApiName.TabIndex = 63;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(26, 104);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 13);
            this.label27.TabIndex = 62;
            this.label27.Text = "Inherit From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 100;
            this.label3.Text = "Output Path:";
            // 
            // TxtOutputPathApplicationService
            // 
            this.TxtOutputPathApplicationService.Location = new System.Drawing.Point(101, 103);
            this.TxtOutputPathApplicationService.Name = "TxtOutputPathApplicationService";
            this.TxtOutputPathApplicationService.Size = new System.Drawing.Size(345, 20);
            this.TxtOutputPathApplicationService.TabIndex = 99;
            // 
            // TxtOutputFolderApplicationService
            // 
            this.TxtOutputFolderApplicationService.Location = new System.Drawing.Point(101, 47);
            this.TxtOutputFolderApplicationService.Name = "TxtOutputFolderApplicationService";
            this.TxtOutputFolderApplicationService.Size = new System.Drawing.Size(171, 20);
            this.TxtOutputFolderApplicationService.TabIndex = 97;
            this.TxtOutputFolderApplicationService.Text = "Context";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "NameSpace:";
            // 
            // TxtInheritFromApplicationService
            // 
            this.TxtInheritFromApplicationService.Location = new System.Drawing.Point(101, 75);
            this.TxtInheritFromApplicationService.Name = "TxtInheritFromApplicationService";
            this.TxtInheritFromApplicationService.Size = new System.Drawing.Size(171, 20);
            this.TxtInheritFromApplicationService.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "Output Folder:";
            // 
            // TxtNamespaceApplicationService
            // 
            this.TxtNamespaceApplicationService.Location = new System.Drawing.Point(101, 18);
            this.TxtNamespaceApplicationService.Name = "TxtNamespaceApplicationService";
            this.TxtNamespaceApplicationService.Size = new System.Drawing.Size(171, 20);
            this.TxtNamespaceApplicationService.TabIndex = 96;
            this.TxtNamespaceApplicationService.Text = "Context";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 95;
            this.label9.Text = "Inherit From:";
            // 
            // WebApiServiceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbAdditionalNamespaces);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.TreeviewContextModels);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WebApiServiceUserControl";
            this.Size = new System.Drawing.Size(796, 504);
            this.gbAdditionalNamespaces.ResumeLayout(false);
            this.gbAdditionalNamespaces.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNew;
        private FormControls.TreeView.MultiSelectTreeView.TreeView TreeviewContextModels;
        private System.Windows.Forms.GroupBox gbAdditionalNamespaces;
        private System.Windows.Forms.TextBox txtNamespaces;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputPath;
        private System.Windows.Forms.TextBox OutputFolder;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox InheritFromInterface;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox Namespace;
        private System.Windows.Forms.TextBox WebApiName;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtOutputPathApplicationService;
        private System.Windows.Forms.TextBox TxtOutputFolderApplicationService;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtInheritFromApplicationService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNamespaceApplicationService;
        private System.Windows.Forms.Label label9;
    }
}
