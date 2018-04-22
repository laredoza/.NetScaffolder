namespace DotNetScaffolder.Presentation.Forms.Controls.Model
{
    partial class ModelRelationshipUserControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblRelationship = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.ComboBoxRelatedTable = new System.Windows.Forms.ComboBox();
            this.ComboBoxColumn = new System.Windows.Forms.ComboBox();
            this.LblSecurity = new System.Windows.Forms.Label();
            this.ComboBoxRelationshipType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblRelationship);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.ComboBoxRelatedTable);
            this.groupBox1.Controls.Add(this.ComboBoxColumn);
            this.groupBox1.Controls.Add(this.LblSecurity);
            this.groupBox1.Controls.Add(this.ComboBoxRelationshipType);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1070, 755);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relationship Details";
            // 
            // LblRelationship
            // 
            this.LblRelationship.AutoSize = true;
            this.LblRelationship.Location = new System.Drawing.Point(188, 35);
            this.LblRelationship.Name = "LblRelationship";
            this.LblRelationship.Size = new System.Drawing.Size(114, 20);
            this.LblRelationship.TabIndex = 56;
            this.LblRelationship.Text = "My relationship";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Relationship Name:";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Parent"});
            this.comboBox6.Location = new System.Drawing.Point(187, 217);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(180, 28);
            this.comboBox6.TabIndex = 54;
            this.comboBox6.Text = "Id";
            // 
            // ComboBoxRelatedTable
            // 
            this.ComboBoxRelatedTable.FormattingEnabled = true;
            this.ComboBoxRelatedTable.Items.AddRange(new object[] {
            "Parent"});
            this.ComboBoxRelatedTable.Location = new System.Drawing.Point(187, 175);
            this.ComboBoxRelatedTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxRelatedTable.Name = "ComboBoxRelatedTable";
            this.ComboBoxRelatedTable.Size = new System.Drawing.Size(180, 28);
            this.ComboBoxRelatedTable.TabIndex = 53;
            this.ComboBoxRelatedTable.Text = "Users";
            this.ComboBoxRelatedTable.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRelatedTable_SelectedIndexChanged);
            // 
            // ComboBoxColumn
            // 
            this.ComboBoxColumn.FormattingEnabled = true;
            this.ComboBoxColumn.Items.AddRange(new object[] {
            "UserId",
            "RoleName"});
            this.ComboBoxColumn.Location = new System.Drawing.Point(187, 133);
            this.ComboBoxColumn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxColumn.Name = "ComboBoxColumn";
            this.ComboBoxColumn.Size = new System.Drawing.Size(180, 28);
            this.ComboBoxColumn.TabIndex = 52;
            this.ComboBoxColumn.SelectedIndexChanged += new System.EventHandler(this.ComboBoxColumn_SelectedIndexChanged);
            // 
            // LblSecurity
            // 
            this.LblSecurity.AutoSize = true;
            this.LblSecurity.Location = new System.Drawing.Point(188, 106);
            this.LblSecurity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSecurity.Name = "LblSecurity";
            this.LblSecurity.Size = new System.Drawing.Size(66, 20);
            this.LblSecurity.TabIndex = 50;
            this.LblSecurity.Text = "Security";
            // 
            // ComboBoxRelationshipType
            // 
            this.ComboBoxRelationshipType.FormattingEnabled = true;
            this.ComboBoxRelationshipType.Items.AddRange(new object[] {
            "Parent"});
            this.ComboBoxRelationshipType.Location = new System.Drawing.Point(188, 63);
            this.ComboBoxRelationshipType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxRelationshipType.Name = "ComboBoxRelationshipType";
            this.ComboBoxRelationshipType.Size = new System.Drawing.Size(180, 28);
            this.ComboBoxRelationshipType.TabIndex = 49;
            this.ComboBoxRelationshipType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRelationshipType_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 215);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(173, 20);
            this.label20.TabIndex = 47;
            this.label20.Text = "Related Column Name:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 175);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 20);
            this.label19.TabIndex = 46;
            this.label19.Text = "Related Table Name:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(66, 138);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 20);
            this.label18.TabIndex = 45;
            this.label18.Text = "Column Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(61, 106);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "Schema Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 69);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 20);
            this.label15.TabIndex = 42;
            this.label15.Text = "Relationship Type:";
            // 
            // ModelRelationshipUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ModelRelationshipUserControl";
            this.Size = new System.Drawing.Size(1086, 772);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox ComboBoxRelatedTable;
        private System.Windows.Forms.ComboBox ComboBoxColumn;
        private System.Windows.Forms.Label LblSecurity;
        private System.Windows.Forms.ComboBox ComboBoxRelationshipType;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LblRelationship;
        private System.Windows.Forms.Label label1;
    }
}
