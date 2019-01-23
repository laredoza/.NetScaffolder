namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Forms.ApplicationServiceDataTypes
{
    partial class ApplicationServiceUserControl
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
            this.TreeviewContextModels = new FormControls.TreeView.MultiSelectTreeView.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbAdditionalNamespacesInterfaces = new System.Windows.Forms.GroupBox();
            this.txtNamespacesInterfaces = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputPathInterface = new System.Windows.Forms.TextBox();
            this.OutputFolderInterface = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InheritFromInterface = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NamespaceInterface = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbAdditionalNamespaces = new System.Windows.Forms.GroupBox();
            this.txtNamespaces = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputPath = new System.Windows.Forms.TextBox();
            this.OutputFolder = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.InheritFrom = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.Namespace = new System.Windows.Forms.TextBox();
            this.ApplicationServiceName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GbAdditionalNamespacesWeb = new System.Windows.Forms.GroupBox();
            this.TxtAdditionalnamespacesWeb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOutputPathWeb = new System.Windows.Forms.TextBox();
            this.TxtOutputFolderWeb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtInheritFromWeb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNamespaceWeb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbAdditionalNamespacesInterfaces.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbAdditionalNamespaces.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.GbAdditionalNamespacesWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeviewContextModels
            // 
            this.TreeviewContextModels.CheckBoxes = true;
            this.TreeviewContextModels.Location = new System.Drawing.Point(7, 249);
            this.TreeviewContextModels.Name = "TreeviewContextModels";
            this.TreeviewContextModels.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.TreeviewContextModels.SelectionMode = FormControls.TreeView.MultiSelectTreeView.TreeViewSelectionMode.SingleSelect;
            this.TreeviewContextModels.Size = new System.Drawing.Size(649, 297);
            this.TreeviewContextModels.TabIndex = 58;
            this.TreeviewContextModels.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeviewContextModels_AfterCheck);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 246);
            this.tabControl1.TabIndex = 61;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbAdditionalNamespacesInterfaces);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.OutputPathInterface);
            this.tabPage1.Controls.Add(this.OutputFolderInterface);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.InheritFromInterface);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.NamespaceInterface);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Application Service Interfaces Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbAdditionalNamespacesInterfaces
            // 
            this.gbAdditionalNamespacesInterfaces.Controls.Add(this.txtNamespacesInterfaces);
            this.gbAdditionalNamespacesInterfaces.Location = new System.Drawing.Point(501, 7);
            this.gbAdditionalNamespacesInterfaces.Name = "gbAdditionalNamespacesInterfaces";
            this.gbAdditionalNamespacesInterfaces.Size = new System.Drawing.Size(251, 206);
            this.gbAdditionalNamespacesInterfaces.TabIndex = 84;
            this.gbAdditionalNamespacesInterfaces.TabStop = false;
            this.gbAdditionalNamespacesInterfaces.Text = "Additional Namespaces:";
            // 
            // txtNamespacesInterfaces
            // 
            this.txtNamespacesInterfaces.AcceptsReturn = true;
            this.txtNamespacesInterfaces.Location = new System.Drawing.Point(6, 19);
            this.txtNamespacesInterfaces.Multiline = true;
            this.txtNamespacesInterfaces.Name = "txtNamespacesInterfaces";
            this.txtNamespacesInterfaces.Size = new System.Drawing.Size(239, 179);
            this.txtNamespacesInterfaces.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Output Path:";
            // 
            // OutputPathInterface
            // 
            this.OutputPathInterface.Location = new System.Drawing.Point(141, 111);
            this.OutputPathInterface.Name = "OutputPathInterface";
            this.OutputPathInterface.Size = new System.Drawing.Size(345, 20);
            this.OutputPathInterface.TabIndex = 82;
            // 
            // OutputFolderInterface
            // 
            this.OutputFolderInterface.Location = new System.Drawing.Point(141, 55);
            this.OutputFolderInterface.Name = "OutputFolderInterface";
            this.OutputFolderInterface.Size = new System.Drawing.Size(171, 20);
            this.OutputFolderInterface.TabIndex = 80;
            this.OutputFolderInterface.Text = "Context";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "NameSpace:";
            // 
            // InheritFromInterface
            // 
            this.InheritFromInterface.Location = new System.Drawing.Point(141, 83);
            this.InheritFromInterface.Name = "InheritFromInterface";
            this.InheritFromInterface.Size = new System.Drawing.Size(171, 20);
            this.InheritFromInterface.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Output Folder:";
            // 
            // NamespaceInterface
            // 
            this.NamespaceInterface.Location = new System.Drawing.Point(141, 26);
            this.NamespaceInterface.Name = "NamespaceInterface";
            this.NamespaceInterface.Size = new System.Drawing.Size(171, 20);
            this.NamespaceInterface.TabIndex = 79;
            this.NamespaceInterface.Text = "Context";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Inherit From:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbAdditionalNamespaces);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.OutputPath);
            this.tabPage2.Controls.Add(this.OutputFolder);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.InheritFrom);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.Namespace);
            this.tabPage2.Controls.Add(this.ApplicationServiceName);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 220);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Services Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbAdditionalNamespaces
            // 
            this.gbAdditionalNamespaces.Controls.Add(this.txtNamespaces);
            this.gbAdditionalNamespaces.Location = new System.Drawing.Point(506, 8);
            this.gbAdditionalNamespaces.Name = "gbAdditionalNamespaces";
            this.gbAdditionalNamespaces.Size = new System.Drawing.Size(251, 206);
            this.gbAdditionalNamespaces.TabIndex = 73;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Output Path:";
            // 
            // OutputPath
            // 
            this.OutputPath.Location = new System.Drawing.Point(148, 138);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.Size = new System.Drawing.Size(345, 20);
            this.OutputPath.TabIndex = 67;
            // 
            // OutputFolder
            // 
            this.OutputFolder.Location = new System.Drawing.Point(148, 82);
            this.OutputFolder.Name = "OutputFolder";
            this.OutputFolder.Size = new System.Drawing.Size(171, 20);
            this.OutputFolder.TabIndex = 65;
            this.OutputFolder.Text = "Context";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 30);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(132, 13);
            this.label23.TabIndex = 59;
            this.label23.Text = "Application Service Name:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(79, 56);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 13);
            this.label24.TabIndex = 60;
            this.label24.Text = "NameSpace:";
            // 
            // InheritFrom
            // 
            this.InheritFrom.Location = new System.Drawing.Point(148, 110);
            this.InheritFrom.Name = "InheritFrom";
            this.InheritFrom.Size = new System.Drawing.Size(171, 20);
            this.InheritFrom.TabIndex = 66;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(74, 85);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 13);
            this.label25.TabIndex = 61;
            this.label25.Text = "Output Folder:";
            // 
            // Namespace
            // 
            this.Namespace.Location = new System.Drawing.Point(148, 53);
            this.Namespace.Name = "Namespace";
            this.Namespace.Size = new System.Drawing.Size(171, 20);
            this.Namespace.TabIndex = 64;
            this.Namespace.Text = "Context";
            // 
            // ApplicationServiceName
            // 
            this.ApplicationServiceName.Location = new System.Drawing.Point(148, 27);
            this.ApplicationServiceName.Name = "ApplicationServiceName";
            this.ApplicationServiceName.Size = new System.Drawing.Size(171, 20);
            this.ApplicationServiceName.TabIndex = 63;
            this.ApplicationServiceName.Text = "Security Model";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(83, 112);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 13);
            this.label27.TabIndex = 62;
            this.label27.Text = "Inherit From:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(662, 253);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 68;
            this.btnNew.Tag = "Add";
            this.btnNew.Text = "Add";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GbAdditionalNamespacesWeb);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.TxtOutputPathWeb);
            this.tabPage3.Controls.Add(this.TxtOutputFolderWeb);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.TxtInheritFromWeb);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.TxtNamespaceWeb);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(763, 220);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Web Application Service Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // GbAdditionalNamespacesWeb
            // 
            this.GbAdditionalNamespacesWeb.Controls.Add(this.TxtAdditionalnamespacesWeb);
            this.GbAdditionalNamespacesWeb.Location = new System.Drawing.Point(473, 7);
            this.GbAdditionalNamespacesWeb.Name = "GbAdditionalNamespacesWeb";
            this.GbAdditionalNamespacesWeb.Size = new System.Drawing.Size(251, 206);
            this.GbAdditionalNamespacesWeb.TabIndex = 93;
            this.GbAdditionalNamespacesWeb.TabStop = false;
            this.GbAdditionalNamespacesWeb.Text = "Additional Namespaces:";
            // 
            // TxtAdditionalnamespacesWeb
            // 
            this.TxtAdditionalnamespacesWeb.AcceptsReturn = true;
            this.TxtAdditionalnamespacesWeb.Location = new System.Drawing.Point(6, 19);
            this.TxtAdditionalnamespacesWeb.Multiline = true;
            this.TxtAdditionalnamespacesWeb.Name = "TxtAdditionalnamespacesWeb";
            this.TxtAdditionalnamespacesWeb.Size = new System.Drawing.Size(239, 179);
            this.TxtAdditionalnamespacesWeb.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Output Path:";
            // 
            // TxtOutputPathWeb
            // 
            this.TxtOutputPathWeb.Location = new System.Drawing.Point(113, 111);
            this.TxtOutputPathWeb.Name = "TxtOutputPathWeb";
            this.TxtOutputPathWeb.Size = new System.Drawing.Size(345, 20);
            this.TxtOutputPathWeb.TabIndex = 91;
            // 
            // TxtOutputFolderWeb
            // 
            this.TxtOutputFolderWeb.Location = new System.Drawing.Point(113, 55);
            this.TxtOutputFolderWeb.Name = "TxtOutputFolderWeb";
            this.TxtOutputFolderWeb.Size = new System.Drawing.Size(171, 20);
            this.TxtOutputFolderWeb.TabIndex = 89;
            this.TxtOutputFolderWeb.Text = "Context";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "NameSpace:";
            // 
            // TxtInheritFromWeb
            // 
            this.TxtInheritFromWeb.Location = new System.Drawing.Point(113, 83);
            this.TxtInheritFromWeb.Name = "TxtInheritFromWeb";
            this.TxtInheritFromWeb.Size = new System.Drawing.Size(171, 20);
            this.TxtInheritFromWeb.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 86;
            this.label8.Text = "Output Folder:";
            // 
            // TxtNamespaceWeb
            // 
            this.TxtNamespaceWeb.Location = new System.Drawing.Point(113, 26);
            this.TxtNamespaceWeb.Name = "TxtNamespaceWeb";
            this.TxtNamespaceWeb.Size = new System.Drawing.Size(171, 20);
            this.TxtNamespaceWeb.TabIndex = 88;
            this.TxtNamespaceWeb.Text = "Context";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Inherit From:";
            // 
            // ApplicationServiceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.TreeviewContextModels);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ApplicationServiceUserControl";
            this.Size = new System.Drawing.Size(784, 556);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbAdditionalNamespacesInterfaces.ResumeLayout(false);
            this.gbAdditionalNamespacesInterfaces.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbAdditionalNamespaces.ResumeLayout(false);
            this.gbAdditionalNamespaces.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.GbAdditionalNamespacesWeb.ResumeLayout(false);
            this.GbAdditionalNamespacesWeb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FormControls.TreeView.MultiSelectTreeView.TreeView TreeviewContextModels;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputPath;
        private System.Windows.Forms.TextBox OutputFolder;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox InheritFrom;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox Namespace;
        private System.Windows.Forms.TextBox ApplicationServiceName;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gbAdditionalNamespaces;
        private System.Windows.Forms.TextBox txtNamespaces;
        private System.Windows.Forms.GroupBox gbAdditionalNamespacesInterfaces;
        private System.Windows.Forms.TextBox txtNamespacesInterfaces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutputPathInterface;
        private System.Windows.Forms.TextBox OutputFolderInterface;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InheritFromInterface;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NamespaceInterface;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox GbAdditionalNamespacesWeb;
        private System.Windows.Forms.TextBox TxtAdditionalnamespacesWeb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtOutputPathWeb;
        private System.Windows.Forms.TextBox TxtOutputFolderWeb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtInheritFromWeb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNamespaceWeb;
        private System.Windows.Forms.Label label9;
    }
}
