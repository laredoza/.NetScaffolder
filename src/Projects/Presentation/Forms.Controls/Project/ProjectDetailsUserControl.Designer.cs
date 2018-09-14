namespace DotNetScaffolder.Presentation.Forms.Controls.Project
{
    partial class ProjectDetailsUserControl
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
            this.components = new System.ComponentModel.Container();
            this.TextBoxBaseNamespace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxOutputFolderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxCompany = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBoxLicense = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxHeader = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxBaseNamespace
            // 
            this.TextBoxBaseNamespace.Location = new System.Drawing.Point(115, 37);
            this.TextBoxBaseNamespace.Name = "TextBoxBaseNamespace";
            this.TextBoxBaseNamespace.Size = new System.Drawing.Size(422, 20);
            this.TextBoxBaseNamespace.TabIndex = 9;
            this.TextBoxBaseNamespace.TextChanged += new System.EventHandler(this.TextBoxBaseNamespace_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Base  Namespace:";
            // 
            // TextBoxOutputFolderName
            // 
            this.TextBoxOutputFolderName.Location = new System.Drawing.Point(115, 11);
            this.TextBoxOutputFolderName.Name = "TextBoxOutputFolderName";
            this.TextBoxOutputFolderName.Size = new System.Drawing.Size(422, 20);
            this.TextBoxOutputFolderName.TabIndex = 7;
            this.TextBoxOutputFolderName.TextChanged += new System.EventHandler(this.TextBoxOutputFolderName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output Folder Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Header:";
            // 
            // TextBoxCompany
            // 
            this.TextBoxCompany.Location = new System.Drawing.Point(115, 63);
            this.TextBoxCompany.Name = "TextBoxCompany";
            this.TextBoxCompany.Size = new System.Drawing.Size(422, 20);
            this.TextBoxCompany.TabIndex = 13;
            this.TextBoxCompany.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(54, 63);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(54, 13);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Company:";
            // 
            // TextBoxLicense
            // 
            this.TextBoxLicense.Location = new System.Drawing.Point(115, 89);
            this.TextBoxLicense.Name = "TextBoxLicense";
            this.TextBoxLicense.Size = new System.Drawing.Size(422, 20);
            this.TextBoxLicense.TabIndex = 15;
            this.TextBoxLicense.TextChanged += new System.EventHandler(this.TextBoxLicense_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "License:";
            // 
            // TextBoxHeader
            // 
            this.TextBoxHeader.Location = new System.Drawing.Point(115, 116);
            this.TextBoxHeader.Name = "TextBoxHeader";
            this.TextBoxHeader.Size = new System.Drawing.Size(422, 332);
            this.TextBoxHeader.TabIndex = 16;
            this.TextBoxHeader.Text = "";
            // 
            // ProjectDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxHeader);
            this.Controls.Add(this.TextBoxLicense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxCompany);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxBaseNamespace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxOutputFolderName);
            this.Controls.Add(this.label2);
            this.Name = "ProjectDetailsUserControl";
            this.Size = new System.Drawing.Size(595, 482);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxBaseNamespace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxOutputFolderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxLicense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxCompany;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.RichTextBox TextBoxHeader;
    }
}
