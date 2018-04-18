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
            this.ComboBoxGroupBy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxBaseNamespace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxOutputFolderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxGroupBy
            // 
            this.ComboBoxGroupBy.FormattingEnabled = true;
            this.ComboBoxGroupBy.Items.AddRange(new object[] {
            "Domain",
            "Layer"});
            this.ComboBoxGroupBy.Location = new System.Drawing.Point(115, 76);
            this.ComboBoxGroupBy.Name = "ComboBoxGroupBy";
            this.ComboBoxGroupBy.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxGroupBy.TabIndex = 11;
            this.ComboBoxGroupBy.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGroupBy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Group By:";
            // 
            // TextBoxBaseNamespace
            // 
            this.TextBoxBaseNamespace.Location = new System.Drawing.Point(115, 44);
            this.TextBoxBaseNamespace.Name = "TextBoxBaseNamespace";
            this.TextBoxBaseNamespace.Size = new System.Drawing.Size(238, 20);
            this.TextBoxBaseNamespace.TabIndex = 9;
            this.TextBoxBaseNamespace.TextChanged += new System.EventHandler(this.TextBoxBaseNamespace_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Base  Namespace:";
            // 
            // TextBoxOutputFolderName
            // 
            this.TextBoxOutputFolderName.Location = new System.Drawing.Point(115, 11);
            this.TextBoxOutputFolderName.Name = "TextBoxOutputFolderName";
            this.TextBoxOutputFolderName.Size = new System.Drawing.Size(238, 20);
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
            // ProjectDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ComboBoxGroupBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxBaseNamespace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxOutputFolderName);
            this.Controls.Add(this.label2);
            this.Name = "ProjectDetailsUserControl";
            this.Size = new System.Drawing.Size(380, 123);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxGroupBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxBaseNamespace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxOutputFolderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
