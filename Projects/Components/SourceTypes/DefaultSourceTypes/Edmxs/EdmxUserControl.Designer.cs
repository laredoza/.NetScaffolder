namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.Edmxs
{
    partial class EdmxUserControl
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TxtFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "EDMX files|*.edmx";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(575, 36);
            this.BtnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(112, 35);
            this.BtnBrowse.TabIndex = 13;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.Location = new System.Drawing.Point(8, 36);
            this.TxtFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.Size = new System.Drawing.Size(526, 26);
            this.TxtFilePath.TabIndex = 12;
            this.TxtFilePath.TextChanged += new System.EventHandler(this.TxtFilePath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Edmx File Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Update datasource settings";
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // EdmxUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.TxtFilePath);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EdmxUserControl";
            this.Size = new System.Drawing.Size(702, 175);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TxtFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
    }
}
