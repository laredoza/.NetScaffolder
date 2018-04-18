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
            this.ComboBoxPackages = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ComboBoxDriverType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ComboBoxDriver = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ComboBoxSourceType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboBoxCollectionOption = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBoxNamingConvention = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnManageSource = new System.Windows.Forms.Button();
            this.BtnModel = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(534, 225);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 48;
            this.button5.Text = "Driver";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ComboBoxPackages
            // 
            this.ComboBoxPackages.FormattingEnabled = true;
            this.ComboBoxPackages.Items.AddRange(new object[] {
            "Domain",
            "Layer"});
            this.ComboBoxPackages.Location = new System.Drawing.Point(168, 271);
            this.ComboBoxPackages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxPackages.Name = "ComboBoxPackages";
            this.ComboBoxPackages.Size = new System.Drawing.Size(355, 28);
            this.ComboBoxPackages.TabIndex = 47;
            this.ComboBoxPackages.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPackages_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 275);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
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
            this.ComboBoxDriverType.Location = new System.Drawing.Point(168, 225);
            this.ComboBoxDriverType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxDriverType.Name = "ComboBoxDriverType";
            this.ComboBoxDriverType.Size = new System.Drawing.Size(355, 28);
            this.ComboBoxDriverType.TabIndex = 45;
            this.ComboBoxDriverType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDriverType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 225);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "Driver Type:";
            // 
            // ComboBoxDriver
            // 
            this.ComboBoxDriver.FormattingEnabled = true;
            this.ComboBoxDriver.Location = new System.Drawing.Point(168, 175);
            this.ComboBoxDriver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxDriver.Name = "ComboBoxDriver";
            this.ComboBoxDriver.Size = new System.Drawing.Size(355, 28);
            this.ComboBoxDriver.TabIndex = 43;
            this.ComboBoxDriver.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDriver_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Driver::";
            // 
            // ComboBoxSourceType
            // 
            this.ComboBoxSourceType.FormattingEnabled = true;
            this.ComboBoxSourceType.Location = new System.Drawing.Point(168, 134);
            this.ComboBoxSourceType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxSourceType.Name = "ComboBoxSourceType";
            this.ComboBoxSourceType.Size = new System.Drawing.Size(355, 28);
            this.ComboBoxSourceType.TabIndex = 41;
            this.ComboBoxSourceType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSourceType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Source Type:";
            // 
            // ComboBoxCollectionOption
            // 
            this.ComboBoxCollectionOption.FormattingEnabled = true;
            this.ComboBoxCollectionOption.Location = new System.Drawing.Point(168, 92);
            this.ComboBoxCollectionOption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxCollectionOption.Name = "ComboBoxCollectionOption";
            this.ComboBoxCollectionOption.Size = new System.Drawing.Size(355, 28);
            this.ComboBoxCollectionOption.TabIndex = 39;
            this.ComboBoxCollectionOption.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCollectionOption_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Collection Option:";
            // 
            // ComboBoxNamingConvention
            // 
            this.ComboBoxNamingConvention.FormattingEnabled = true;
            this.ComboBoxNamingConvention.Location = new System.Drawing.Point(168, 45);
            this.ComboBoxNamingConvention.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxNamingConvention.Name = "ComboBoxNamingConvention";
            this.ComboBoxNamingConvention.Size = new System.Drawing.Size(355, 28);
            this.ComboBoxNamingConvention.TabIndex = 36;
            this.ComboBoxNamingConvention.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNamingConvention_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Naming Convention:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(168, 5);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(355, 26);
            this.TextBoxName.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Name:";
            // 
            // BtnManageSource
            // 
            this.BtnManageSource.Location = new System.Drawing.Point(534, 134);
            this.BtnManageSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnManageSource.Name = "BtnManageSource";
            this.BtnManageSource.Size = new System.Drawing.Size(112, 35);
            this.BtnManageSource.TabIndex = 49;
            this.BtnManageSource.Text = "Configure";
            this.BtnManageSource.UseVisualStyleBackColor = true;
            this.BtnManageSource.Click += new System.EventHandler(this.BtnManageSource_Click);
            // 
            // BtnModel
            // 
            this.BtnModel.Location = new System.Drawing.Point(534, 177);
            this.BtnModel.Name = "BtnModel";
            this.BtnModel.Size = new System.Drawing.Size(112, 40);
            this.BtnModel.TabIndex = 50;
            this.BtnModel.Text = "Models";
            this.BtnModel.UseVisualStyleBackColor = true;
            this.BtnModel.Click += new System.EventHandler(this.BtnModel_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(652, 179);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(91, 38);
            this.BtnRefresh.TabIndex = 51;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // ProjectDomainDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnModel);
            this.Controls.Add(this.BtnManageSource);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ComboBoxPackages);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ComboBoxDriverType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ComboBoxDriver);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComboBoxSourceType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ComboBoxCollectionOption);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBoxNamingConvention);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProjectDomainDetailsUserControl";
            this.Size = new System.Drawing.Size(852, 325);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox ComboBoxPackages;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ComboBoxDriverType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ComboBoxDriver;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ComboBoxSourceType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboBoxCollectionOption;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBoxNamingConvention;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnManageSource;
        private System.Windows.Forms.Button BtnModel;
        private System.Windows.Forms.Button BtnRefresh;
    }
}
