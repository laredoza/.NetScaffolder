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
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ListViewDrivers = new System.Windows.Forms.ListView();
            this.Schema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
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
            this.BtnBrowse.Location = new System.Drawing.Point(383, 23);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowse.TabIndex = 13;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.Location = new System.Drawing.Point(5, 23);
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.Size = new System.Drawing.Size(352, 20);
            this.TxtFilePath.TabIndex = 12;
            this.TxtFilePath.TextChanged += new System.EventHandler(this.TxtFilePath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Edmx File Path:";
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // ListViewDrivers
            // 
            this.ListViewDrivers.CheckBoxes = true;
            this.ListViewDrivers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Schema});
            this.ListViewDrivers.Location = new System.Drawing.Point(74, 52);
            this.ListViewDrivers.Name = "ListViewDrivers";
            this.ListViewDrivers.Size = new System.Drawing.Size(352, 176);
            this.ListViewDrivers.TabIndex = 56;
            this.ListViewDrivers.UseCompatibleStateImageBehavior = false;
            this.ListViewDrivers.View = System.Windows.Forms.View.Details;
            // 
            // Schemas
            // 
            this.Schema.Text = "Schemas";
            this.Schema.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Schemas:";
            // 
            // EdmxUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListViewDrivers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.TxtFilePath);
            this.Controls.Add(this.label2);
            this.Name = "EdmxUserControl";
            this.Size = new System.Drawing.Size(468, 245);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TxtFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
        private System.Windows.Forms.ListView ListViewDrivers;
        private System.Windows.Forms.ColumnHeader Schema;
        private System.Windows.Forms.Label label1;
    }
}
