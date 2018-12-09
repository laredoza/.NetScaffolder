namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Forms.UnitTests
{
    partial class UnitTestsUserControl
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
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNamespaces = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBaseOutputPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(161, 26);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(121, 20);
            this.txtNamespace.TabIndex = 57;
            this.txtNamespace.Text = "Registry";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(79, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(67, 13);
            this.label30.TabIndex = 56;
            this.label30.Text = "Namespace:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBaseOutputPath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOutputFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOutputPath);
            this.groupBox1.Controls.Add(this.txtNamespace);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 161);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Structure map settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNamespaces);
            this.groupBox2.Location = new System.Drawing.Point(286, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 88);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Namespaces:";
            // 
            // txtNamespaces
            // 
            this.txtNamespaces.AcceptsReturn = true;
            this.txtNamespaces.Location = new System.Drawing.Point(6, 19);
            this.txtNamespaces.Multiline = true;
            this.txtNamespaces.Name = "txtNamespaces";
            this.txtNamespaces.Size = new System.Drawing.Size(267, 63);
            this.txtNamespaces.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Output Folder:";
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(161, 60);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(121, 20);
            this.txtOutputFolder.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Output Path:";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(161, 104);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(406, 20);
            this.txtOutputPath.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Base Unit Test Output Path:";
            // 
            // txtBaseOutputPath
            // 
            this.txtBaseOutputPath.Location = new System.Drawing.Point(161, 133);
            this.txtBaseOutputPath.Name = "txtBaseOutputPath";
            this.txtBaseOutputPath.Size = new System.Drawing.Size(406, 20);
            this.txtBaseOutputPath.TabIndex = 69;
            // 
            // UnitTestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UnitTestsUserControl";
            this.Size = new System.Drawing.Size(591, 184);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNamespaces;
        private System.Windows.Forms.TextBox txtBaseOutputPath;
        private System.Windows.Forms.Label label3;
    }
}
