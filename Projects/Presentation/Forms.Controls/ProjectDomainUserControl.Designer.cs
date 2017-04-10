namespace DotNetScaffolder.Presentation.Forms.Controls
{
    partial class ProjectDomainUserControl
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
            this.BtnTables = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.DomainsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnTables
            // 
            this.BtnTables.Location = new System.Drawing.Point(242, 63);
            this.BtnTables.Name = "BtnTables";
            this.BtnTables.Size = new System.Drawing.Size(75, 23);
            this.BtnTables.TabIndex = 23;
            this.BtnTables.Text = "Tables";
            this.BtnTables.UseVisualStyleBackColor = true;
            this.BtnTables.Click += new System.EventHandler(this.BtnTables_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(242, 33);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 22;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(242, 2);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 21;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // DomainsListBox
            // 
            this.DomainsListBox.FormattingEnabled = true;
            this.DomainsListBox.Location = new System.Drawing.Point(3, 3);
            this.DomainsListBox.Name = "DomainsListBox";
            this.DomainsListBox.Size = new System.Drawing.Size(233, 95);
            this.DomainsListBox.TabIndex = 20;
            this.DomainsListBox.SelectedIndexChanged += new System.EventHandler(this.DomainsListBox_SelectedIndexChanged);
            // 
            // ProjectDomainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnTables);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.DomainsListBox);
            this.Name = "ProjectDomainUserControl";
            this.Size = new System.Drawing.Size(324, 106);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTables;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.ListBox DomainsListBox;
    }
}
