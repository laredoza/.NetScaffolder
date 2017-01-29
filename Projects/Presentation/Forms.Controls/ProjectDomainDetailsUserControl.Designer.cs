namespace DotNetScaffolder.Presentation.Forms.Controls
{
    partial class ProjectDomainDetailsUserControl
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ComboBoxDriverType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ComboBoxDriver = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ComboBoxSourceType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBoxNamingConvention = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(356, 146);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 48;
            this.button5.Text = "Driver";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(356, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "Source";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Domain",
            "Layer"});
            this.comboBox7.Location = new System.Drawing.Point(112, 176);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(238, 21);
            this.comboBox7.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Package:";
            // 
            // ComboBoxDriverType
            // 
            this.ComboBoxDriverType.FormattingEnabled = true;
            this.ComboBoxDriverType.Items.AddRange(new object[] {
            "Oracle Default",
            "Sql Server Default",
            "Mongo Default"});
            this.ComboBoxDriverType.Location = new System.Drawing.Point(112, 146);
            this.ComboBoxDriverType.Name = "ComboBoxDriverType";
            this.ComboBoxDriverType.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxDriverType.TabIndex = 45;
            this.ComboBoxDriverType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDriverType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Driver Type:";
            // 
            // ComboBoxDriver
            // 
            this.ComboBoxDriver.FormattingEnabled = true;
            this.ComboBoxDriver.Location = new System.Drawing.Point(112, 114);
            this.ComboBoxDriver.Name = "ComboBoxDriver";
            this.ComboBoxDriver.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxDriver.TabIndex = 43;
            this.ComboBoxDriver.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDriver_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Driver::";
            // 
            // ComboBoxSourceType
            // 
            this.ComboBoxSourceType.FormattingEnabled = true;
            this.ComboBoxSourceType.Location = new System.Drawing.Point(112, 87);
            this.ComboBoxSourceType.Name = "ComboBoxSourceType";
            this.ComboBoxSourceType.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxSourceType.TabIndex = 41;
            this.ComboBoxSourceType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSourceType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Source Type:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "ICollectionAndHashSet",
            "IListAndList",
            "ObservableCollection"});
            this.comboBox3.Location = new System.Drawing.Point(112, 60);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(238, 21);
            this.comboBox3.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Collection Option:";
            // 
            // ComboBoxNamingConvention
            // 
            this.ComboBoxNamingConvention.FormattingEnabled = true;
            this.ComboBoxNamingConvention.Location = new System.Drawing.Point(112, 29);
            this.ComboBoxNamingConvention.Name = "ComboBoxNamingConvention";
            this.ComboBoxNamingConvention.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxNamingConvention.TabIndex = 36;
            this.ComboBoxNamingConvention.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNamingConvention_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Naming Convention:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(112, 3);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(238, 20);
            this.TextBoxName.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Name:";
            // 
            // ProjectDomainDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ComboBoxDriverType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ComboBoxDriver);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComboBoxSourceType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBoxNamingConvention);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label5);
            this.Name = "ProjectDomainDetailsUserControl";
            this.Size = new System.Drawing.Size(443, 211);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ComboBoxDriverType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ComboBoxDriver;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ComboBoxSourceType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBoxNamingConvention;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label5;
    }
}
