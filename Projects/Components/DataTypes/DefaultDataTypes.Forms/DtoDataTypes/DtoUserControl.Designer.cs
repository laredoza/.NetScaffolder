namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Forms.DtoDataTypes
{
    partial class DtoUserControl
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
            //base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.chkAddInjectConstructor = new System.Windows.Forms.CheckBox();
            this.txtInheritFrom = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNamespaces = new System.Windows.Forms.TextBox();
            this.txtPostFix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkUseInterface = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.chkUseGenerics = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(131, 121);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(151, 20);
            this.txtOutputFolder.TabIndex = 59;
            this.txtOutputFolder.Text = "Dto";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(37, 124);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 13);
            this.label31.TabIndex = 58;
            this.label31.Text = "Output Folder:";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(131, 71);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(151, 20);
            this.txtNamespace.TabIndex = 57;
            this.txtNamespace.Text = "Dto";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(44, 74);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(67, 13);
            this.label30.TabIndex = 56;
            this.label30.Text = "Namespace:";
            // 
            // chkAddInjectConstructor
            // 
            this.chkAddInjectConstructor.AutoSize = true;
            this.chkAddInjectConstructor.Enabled = false;
            this.chkAddInjectConstructor.Location = new System.Drawing.Point(131, 191);
            this.chkAddInjectConstructor.Name = "chkAddInjectConstructor";
            this.chkAddInjectConstructor.Size = new System.Drawing.Size(187, 17);
            this.chkAddInjectConstructor.TabIndex = 55;
            this.chkAddInjectConstructor.Text = "Add interface injection constructor";
            this.chkAddInjectConstructor.UseVisualStyleBackColor = true;
            // 
            // txtInheritFrom
            // 
            this.txtInheritFrom.Location = new System.Drawing.Point(131, 18);
            this.txtInheritFrom.Name = "txtInheritFrom";
            this.txtInheritFrom.Size = new System.Drawing.Size(151, 20);
            this.txtInheritFrom.TabIndex = 53;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(46, 21);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 13);
            this.label29.TabIndex = 52;
            this.label29.Text = "Inherit From:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkUseGenerics);
            this.groupBox1.Controls.Add(this.txtPostFix);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkUseInterface);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOutputPath);
            this.groupBox1.Controls.Add(this.txtNamespace);
            this.groupBox1.Controls.Add(this.txtOutputFolder);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.txtInheritFrom);
            this.groupBox1.Controls.Add(this.chkAddInjectConstructor);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 213);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dto settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNamespaces);
            this.groupBox2.Location = new System.Drawing.Point(288, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 130);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Namespaces:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtNamespaces
            // 
            this.txtNamespaces.AcceptsReturn = true;
            this.txtNamespaces.Location = new System.Drawing.Point(6, 19);
            this.txtNamespaces.Multiline = true;
            this.txtNamespaces.Name = "txtNamespaces";
            this.txtNamespaces.Size = new System.Drawing.Size(237, 105);
            this.txtNamespaces.TabIndex = 0;
            // 
            // txtPostFix
            // 
            this.txtPostFix.Location = new System.Drawing.Point(131, 97);
            this.txtPostFix.Name = "txtPostFix";
            this.txtPostFix.Size = new System.Drawing.Size(151, 20);
            this.txtPostFix.TabIndex = 65;
            this.txtPostFix.Text = "Dto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Postfix:";
            // 
            // chkUseInterface
            // 
            this.chkUseInterface.AutoSize = true;
            this.chkUseInterface.Location = new System.Drawing.Point(131, 171);
            this.chkUseInterface.Name = "chkUseInterface";
            this.chkUseInterface.Size = new System.Drawing.Size(89, 17);
            this.chkUseInterface.TabIndex = 63;
            this.chkUseInterface.Text = "Use interface";
            this.chkUseInterface.UseVisualStyleBackColor = true;
            this.chkUseInterface.CheckedChanged += new System.EventHandler(this.chkUseInterface_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Output Path:";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(131, 146);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(406, 20);
            this.txtOutputPath.TabIndex = 60;
            // 
            // chkUseGenerics
            // 
            this.chkUseGenerics.Location = new System.Drawing.Point(131, 43);
            this.chkUseGenerics.Name = "chkUseGenerics";
            this.chkUseGenerics.Size = new System.Drawing.Size(168, 22);
            this.chkUseGenerics.TabIndex = 69;
            this.chkUseGenerics.Text = "Use generics for inheritance";
            this.chkUseGenerics.UseVisualStyleBackColor = true;
            // 
            // DtoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DtoUserControl";
            this.Size = new System.Drawing.Size(549, 219);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox chkAddInjectConstructor;
        private System.Windows.Forms.TextBox txtInheritFrom;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.CheckBox chkUseInterface;
        private System.Windows.Forms.TextBox txtPostFix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNamespaces;
        private System.Windows.Forms.CheckBox chkUseGenerics;
    }
}
