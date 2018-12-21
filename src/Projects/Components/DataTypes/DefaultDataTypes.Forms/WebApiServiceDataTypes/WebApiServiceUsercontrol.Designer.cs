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
            this.WebApiName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            // 
            // Namespace
            // 
            this.Namespace.Location = new System.Drawing.Point(151, 45);
            this.Namespace.Name = "Namespace";
            this.Namespace.Size = new System.Drawing.Size(171, 20);
            this.Namespace.TabIndex = 51;
            // 
            // WebApiName
            // 
            this.WebApiName.Location = new System.Drawing.Point(151, 19);
            this.WebApiName.Name = "WebApiName";
            this.WebApiName.Size = new System.Drawing.Size(171, 20);
            this.WebApiName.TabIndex = 50;
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
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 44;
            this.label24.Text = "Namespace:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(70, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "WebApi Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OutputPath);
            this.groupBox1.Controls.Add(this.OutputFolder);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.InheritFromInterface);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.Namespace);
            this.groupBox1.Controls.Add(this.WebApiName);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 206);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WebApi Settings";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(328, 102);
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
            this.label1.Location = new System.Drawing.Point(82, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Output Path:";
            // 
            // OutputPath
            // 
            this.OutputPath.Location = new System.Drawing.Point(150, 128);
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
            // WebApiServiceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAdditionalNamespaces);
            this.Controls.Add(this.TreeviewContextModels);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WebApiServiceUserControl";
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
        private System.Windows.Forms.TextBox WebApiName;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox OutputPath;
        private System.Windows.Forms.Label label1;
        private FormControls.TreeView.MultiSelectTreeView.TreeView TreeviewContextModels;
        private System.Windows.Forms.GroupBox gbAdditionalNamespaces;
        private System.Windows.Forms.TextBox txtNamespaces;
    }
}
