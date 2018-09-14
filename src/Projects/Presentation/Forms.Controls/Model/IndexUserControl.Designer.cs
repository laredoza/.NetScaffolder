namespace DotNetScaffolder.Presentation.Forms.Controls.Model
{
    partial class IndexUserControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListViewColumns = new System.Windows.Forms.ListView();
            this.ColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CheckBoxIsUnique = new System.Windows.Forms.CheckBox();
            this.TextBoxIndexName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxRelationshipType = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListViewColumns);
            this.groupBox1.Controls.Add(this.CheckBoxIsUnique);
            this.groupBox1.Controls.Add(this.TextBoxIndexName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboBoxRelationshipType);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 491);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Index Details";
            // 
            // ListViewColumns
            // 
            this.ListViewColumns.CheckBoxes = true;
            this.ListViewColumns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName});
            this.ListViewColumns.Location = new System.Drawing.Point(125, 75);
            this.ListViewColumns.Name = "ListViewColumns";
            this.ListViewColumns.Size = new System.Drawing.Size(217, 164);
            this.ListViewColumns.TabIndex = 59;
            this.ListViewColumns.UseCompatibleStateImageBehavior = false;
            this.ListViewColumns.View = System.Windows.Forms.View.Details;
            this.ListViewColumns.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListViewColumns_ItemChecked);
            this.ListViewColumns.SelectedIndexChanged += new System.EventHandler(this.ListViewColumns_SelectedIndexChanged);
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Column";
            this.ColumnName.Width = 212;
            // 
            // CheckBoxIsUnique
            // 
            this.CheckBoxIsUnique.AutoSize = true;
            this.CheckBoxIsUnique.Location = new System.Drawing.Point(125, 245);
            this.CheckBoxIsUnique.Name = "CheckBoxIsUnique";
            this.CheckBoxIsUnique.Size = new System.Drawing.Size(71, 17);
            this.CheckBoxIsUnique.TabIndex = 58;
            this.CheckBoxIsUnique.Text = "Is Unique";
            this.CheckBoxIsUnique.UseVisualStyleBackColor = true;
            this.CheckBoxIsUnique.CheckedChanged += new System.EventHandler(this.CheckBoxIsUnique_CheckedChanged);
            // 
            // TextBoxIndexName
            // 
            this.TextBoxIndexName.Location = new System.Drawing.Point(125, 20);
            this.TextBoxIndexName.Name = "TextBoxIndexName";
            this.TextBoxIndexName.Size = new System.Drawing.Size(217, 20);
            this.TextBoxIndexName.TabIndex = 56;
            this.TextBoxIndexName.TextChanged += new System.EventHandler(this.TextBoxIndexName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Index Name:";
            // 
            // ComboBoxRelationshipType
            // 
            this.ComboBoxRelationshipType.FormattingEnabled = true;
            this.ComboBoxRelationshipType.Items.AddRange(new object[] {
            "Parent"});
            this.ComboBoxRelationshipType.Location = new System.Drawing.Point(125, 46);
            this.ComboBoxRelationshipType.Name = "ComboBoxRelationshipType";
            this.ComboBoxRelationshipType.Size = new System.Drawing.Size(217, 21);
            this.ComboBoxRelationshipType.TabIndex = 49;
            this.ComboBoxRelationshipType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRelationshipType_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Column Names:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Index Type:";
            // 
            // IndexUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "IndexUserControl";
            this.Size = new System.Drawing.Size(724, 504);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckBoxIsUnique;
        private System.Windows.Forms.TextBox TextBoxIndexName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxRelationshipType;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView ListViewColumns;
        private System.Windows.Forms.ColumnHeader ColumnName;
    }
}
