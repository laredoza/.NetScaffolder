﻿namespace DotNetScaffolder.Presentation.Forms.Controls.Model
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblRelationship = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxRelatedColumn = new System.Windows.Forms.ComboBox();
            this.ComboBoxRelatedTable = new System.Windows.Forms.ComboBox();
            this.ComboBoxColumn = new System.Windows.Forms.ComboBox();
            this.LblSecurity = new System.Windows.Forms.Label();
            this.ComboBoxRelationshipType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblRelationship);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboBoxRelatedColumn);
            this.groupBox1.Controls.Add(this.ComboBoxRelatedTable);
            this.groupBox1.Controls.Add(this.ComboBoxColumn);
            this.groupBox1.Controls.Add(this.LblSecurity);
            this.groupBox1.Controls.Add(this.ComboBoxRelationshipType);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 491);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relationship Details";
            // 
            // LblRelationship
            // 
            this.LblRelationship.AutoSize = true;
            this.LblRelationship.Location = new System.Drawing.Point(125, 23);
            this.LblRelationship.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRelationship.Name = "LblRelationship";
            this.LblRelationship.Size = new System.Drawing.Size(77, 13);
            this.LblRelationship.TabIndex = 56;
            this.LblRelationship.Text = "My relationship";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Relationship Name:";
            // 
            // ComboBoxRelatedColumn
            // 
            this.ComboBoxRelatedColumn.FormattingEnabled = true;
            this.ComboBoxRelatedColumn.Items.AddRange(new object[] {
            "Parent"});
            this.ComboBoxRelatedColumn.Location = new System.Drawing.Point(125, 141);
            this.ComboBoxRelatedColumn.Name = "ComboBoxRelatedColumn";
            this.ComboBoxRelatedColumn.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxRelatedColumn.TabIndex = 54;
            this.ComboBoxRelatedColumn.Text = "Id";
            this.ComboBoxRelatedColumn.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRelatedColumn_SelectedIndexChanged);
            // 
            // ComboBoxRelatedTable
            // 
            this.ComboBoxRelatedTable.FormattingEnabled = true;
            this.ComboBoxRelatedTable.Items.AddRange(new object[] {
            "Parent"});
            this.ComboBoxRelatedTable.Location = new System.Drawing.Point(125, 114);
            this.ComboBoxRelatedTable.Name = "ComboBoxRelatedTable";
            this.ComboBoxRelatedTable.Size = new System.Drawing.Size(121, 21);
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
            this.ComboBoxColumn.Location = new System.Drawing.Point(125, 86);
            this.ComboBoxColumn.Name = "ComboBoxColumn";
            this.ComboBoxColumn.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxColumn.TabIndex = 52;
            this.ComboBoxColumn.SelectedIndexChanged += new System.EventHandler(this.ComboBoxColumn_SelectedIndexChanged);
            // 
            // LblSecurity
            // 
            this.LblSecurity.AutoSize = true;
            this.LblSecurity.Location = new System.Drawing.Point(125, 69);
            this.LblSecurity.Name = "LblSecurity";
            this.LblSecurity.Size = new System.Drawing.Size(45, 13);
            this.LblSecurity.TabIndex = 50;
            this.LblSecurity.Text = "Security";
            // 
            // ComboBoxRelationshipType
            // 
            this.ComboBoxRelationshipType.FormattingEnabled = true;
            this.ComboBoxRelationshipType.Items.AddRange(new object[] {
            "Parent"});
            this.ComboBoxRelationshipType.Location = new System.Drawing.Point(125, 41);
            this.ComboBoxRelationshipType.Name = "ComboBoxRelationshipType";
            this.ComboBoxRelationshipType.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxRelationshipType.TabIndex = 49;
            this.ComboBoxRelationshipType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRelationshipType_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Related Column Name:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Related Table Name:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(44, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Column Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Schema Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Relationship Type:";
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // ModelRelationshipUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModelRelationshipUserControl";
            this.Size = new System.Drawing.Size(724, 502);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBoxRelatedColumn;
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
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
    }
}