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
            this.InheritFromInterface = new System.Windows.Forms.TextBox();
            this.OutputFolder = new System.Windows.Forms.TextBox();
            this.Namespace = new System.Windows.Forms.TextBox();
            this.ContextName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIsDefault = new System.Windows.Forms.CheckBox();
            this.txtCustomConnectionName = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputPath = new System.Windows.Forms.TextBox();
            this.gbAdditionalNamespaces = new System.Windows.Forms.GroupBox();
            this.txtNamespaces = new System.Windows.Forms.TextBox();
            this.TreeviewContextModels = new FormControls.TreeView.MultiSelectTreeView.TreeView();
            this.groupBox1.SuspendLayout();
            this.gbAdditionalNamespaces.SuspendLayout();
            this.SuspendLayout();
            // 
            // InheritFromInterface
            // 
            this.InheritFromInterface.Location = new System.Drawing.Point(151, 102);
            this.InheritFromInterface.Name = "InheritFromInterface";
            this.InheritFromInterface.Size = new System.Drawing.Size(171, 20);
            this.InheritFromInterface.TabIndex = 54;
            // 
            // OutputFolder
            // 
            this.OutputFolder.Location = new System.Drawing.Point(151, 74);
            this.OutputFolder.Name = "OutputFolder";
            this.OutputFolder.Size = new System.Drawing.Size(171, 20);
            this.OutputFolder.TabIndex = 52;
            this.OutputFolder.Text = "Context";
            // 
            // Namespace
            // 
            this.Namespace.Location = new System.Drawing.Point(151, 45);
            this.Namespace.Name = "Namespace";
            this.Namespace.Size = new System.Drawing.Size(171, 20);
            this.Namespace.TabIndex = 51;
            this.Namespace.Text = "Context";
            // 
            // ContextName
            // 
            this.ContextName.Location = new System.Drawing.Point(151, 19);
            this.ContextName.Name = "ContextName";
            this.ContextName.Size = new System.Drawing.Size(171, 20);
            this.ContextName.TabIndex = 50;
            this.ContextName.Text = "Security Model";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(86, 104);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 13);
            this.label27.TabIndex = 49;
            this.label27.Text = "Inherit From:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 132);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(145, 13);
            this.label26.TabIndex = 46;
            this.label26.Text = "Custom Connection or Name:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(77, 77);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 13);
            this.label25.TabIndex = 45;
            this.label25.Text = "Output Folder:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(82, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 13);
            this.label24.TabIndex = 44;
            this.label24.Text = "NameSpace:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(74, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "Context Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIsDefault);
            this.groupBox1.Controls.Add(this.txtCustomConnectionName);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OutputPath);
            this.groupBox1.Controls.Add(this.OutputFolder);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.InheritFromInterface);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.Namespace);
            this.groupBox1.Controls.Add(this.ContextName);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 206);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Context settings";
            // 
            // chkIsDefault
            // 
            this.chkIsDefault.AutoSize = true;
            this.chkIsDefault.Location = new System.Drawing.Point(151, 181);
            this.chkIsDefault.Name = "chkIsDefault";
            this.chkIsDefault.Size = new System.Drawing.Size(71, 17);
            this.chkIsDefault.TabIndex = 61;
            this.chkIsDefault.Text = "Is Default";
            this.chkIsDefault.UseVisualStyleBackColor = true;
            this.chkIsDefault.CheckedChanged += new System.EventHandler(this.chkIsDefault_CheckedChanged);
            // 
            // txtCustomConnectionName
            // 
            this.txtCustomConnectionName.Location = new System.Drawing.Point(151, 129);
            this.txtCustomConnectionName.Name = "txtCustomConnectionName";
            this.txtCustomConnectionName.Size = new System.Drawing.Size(255, 20);
            this.txtCustomConnectionName.TabIndex = 60;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(412, 127);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 58;
            this.btnNew.Tag = "Add";
            this.btnNew.Text = "Add";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Output Path:";
            // 
            // OutputPath
            // 
            this.OutputPath.Location = new System.Drawing.Point(151, 154);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.Size = new System.Drawing.Size(336, 20);
            this.OutputPath.TabIndex = 57;
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
            this.TreeviewContextModels.Location = new System.Drawing.Point(3, 215);
            this.TreeviewContextModels.Name = "TreeviewContextModels";
            this.TreeviewContextModels.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.TreeviewContextModels.SelectionMode = FormControls.TreeView.MultiSelectTreeView.TreeViewSelectionMode.SingleSelect;
            this.TreeviewContextModels.Size = new System.Drawing.Size(492, 258);
            this.TreeviewContextModels.TabIndex = 58;
            // 
            // ContextUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAdditionalNamespaces);
            this.Controls.Add(this.TreeviewContextModels);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ContextUserControl";
            this.Size = new System.Drawing.Size(796, 504);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAdditionalNamespaces.ResumeLayout(false);
            this.gbAdditionalNamespaces.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox InheritFromInterface;
        private System.Windows.Forms.TextBox OutputFolder;
        private System.Windows.Forms.TextBox Namespace;
        private System.Windows.Forms.TextBox ContextName;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox OutputPath;
        private System.Windows.Forms.Label label1;
        private FormControls.TreeView.MultiSelectTreeView.TreeView TreeviewContextModels;
        private System.Windows.Forms.TextBox txtCustomConnectionName;
        private System.Windows.Forms.CheckBox chkIsDefault;
        private System.Windows.Forms.GroupBox gbAdditionalNamespaces;
        private System.Windows.Forms.TextBox txtNamespaces;
    }
}
