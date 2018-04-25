namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.EntityDataTypes
{
    partial class EntityUserControl
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
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.chkAddInjectConstructor = new System.Windows.Forms.CheckBox();
            this.txtInheritFrom = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUseInterface = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tstOutputPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(131, 93);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(121, 20);
            this.txtOutputFolder.TabIndex = 59;
            this.txtOutputFolder.Text = "Entity";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(37, 96);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 13);
            this.label31.TabIndex = 58;
            this.label31.Text = "Output Folder:";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(131, 57);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(121, 20);
            this.txtNamespace.TabIndex = 57;
            this.txtNamespace.Text = "Entity";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(44, 60);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(67, 13);
            this.label30.TabIndex = 56;
            this.label30.Text = "Namespace:";
            // 
            // chkAddInjectConstructor
            // 
            this.chkAddInjectConstructor.AutoSize = true;
            this.chkAddInjectConstructor.Enabled = false;
            this.chkAddInjectConstructor.Location = new System.Drawing.Point(131, 188);
            this.chkAddInjectConstructor.Name = "chkAddInjectConstructor";
            this.chkAddInjectConstructor.Size = new System.Drawing.Size(187, 17);
            this.chkAddInjectConstructor.TabIndex = 55;
            this.chkAddInjectConstructor.Text = "Add interface injection constructor";
            this.chkAddInjectConstructor.UseVisualStyleBackColor = true;
            // 
            // txtInheritFrom
            // 
            this.txtInheritFrom.Location = new System.Drawing.Point(131, 22);
            this.txtInheritFrom.Name = "txtInheritFrom";
            this.txtInheritFrom.Size = new System.Drawing.Size(121, 20);
            this.txtInheritFrom.TabIndex = 53;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(46, 25);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 13);
            this.label29.TabIndex = 52;
            this.label29.Text = "Inherit From:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUseInterface);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tstOutputPath);
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
            this.groupBox1.Text = "Entity settings";
            // 
            // chkUseInterface
            // 
            this.chkUseInterface.AutoSize = true;
            this.chkUseInterface.Location = new System.Drawing.Point(131, 161);
            this.chkUseInterface.Name = "chkUseInterface";
            this.chkUseInterface.Size = new System.Drawing.Size(89, 17);
            this.chkUseInterface.TabIndex = 63;
            this.chkUseInterface.Text = "Use interface";
            this.chkUseInterface.UseVisualStyleBackColor = true;
            this.chkUseInterface.CheckedChanged += new System.EventHandler(this.chkUseInterface_CheckedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(439, 128);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 62;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Output Path:";
            // 
            // tstOutputPath
            // 
            this.tstOutputPath.Enabled = false;
            this.tstOutputPath.Location = new System.Drawing.Point(131, 130);
            this.tstOutputPath.Name = "tstOutputPath";
            this.tstOutputPath.Size = new System.Drawing.Size(304, 20);
            this.tstOutputPath.TabIndex = 60;
            // 
            // EntityUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EntityUserControl";
            this.Size = new System.Drawing.Size(549, 219);
            this.Load += new System.EventHandler(this.EntityUserControl1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tstOutputPath;
        private System.Windows.Forms.CheckBox chkUseInterface;
    }
}
