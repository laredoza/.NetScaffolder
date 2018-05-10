namespace DotNetScaffolder.Presentation.Forms.Controls.Project
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
            this.ComboBoxPackages = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.ListViewDrivers = new System.Windows.Forms.ListView();
            this.DriverType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ComboBoxPackages
            // 
            this.ComboBoxPackages.FormattingEnabled = true;
            this.ComboBoxPackages.Items.AddRange(new object[] {
            "Domain",
            "Layer"});
            this.ComboBoxPackages.Location = new System.Drawing.Point(112, 114);
            this.ComboBoxPackages.Name = "ComboBoxPackages";
            this.ComboBoxPackages.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxPackages.TabIndex = 47;
            this.ComboBoxPackages.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPackages_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Package:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Driver Type:";
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
            // ComboBoxCollectionOption
            // 
            this.ComboBoxCollectionOption.FormattingEnabled = true;
            this.ComboBoxCollectionOption.Location = new System.Drawing.Point(112, 60);
            this.ComboBoxCollectionOption.Name = "ComboBoxCollectionOption";
            this.ComboBoxCollectionOption.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxCollectionOption.TabIndex = 39;
            this.ComboBoxCollectionOption.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCollectionOption_SelectedIndexChanged);
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
            // BtnManageSource
            // 
            this.BtnManageSource.Location = new System.Drawing.Point(356, 82);
            this.BtnManageSource.Name = "BtnManageSource";
            this.BtnManageSource.Size = new System.Drawing.Size(75, 23);
            this.BtnManageSource.TabIndex = 49;
            this.BtnManageSource.Text = "Configure";
            this.BtnManageSource.UseVisualStyleBackColor = true;
            this.BtnManageSource.Click += new System.EventHandler(this.BtnManageSource_Click);
            // 
            // BtnModel
            // 
            this.BtnModel.Location = new System.Drawing.Point(355, 110);
            this.BtnModel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModel.Name = "BtnModel";
            this.BtnModel.Size = new System.Drawing.Size(75, 26);
            this.BtnModel.TabIndex = 50;
            this.BtnModel.Text = "Models";
            this.BtnModel.UseVisualStyleBackColor = true;
            this.BtnModel.Click += new System.EventHandler(this.BtnModel_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(434, 110);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(61, 25);
            this.BtnRefresh.TabIndex = 51;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // ListViewDrivers
            // 
            this.ListViewDrivers.CheckBoxes = true;
            this.ListViewDrivers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DriverType,
            this.columnHeader2});
            this.ListViewDrivers.Location = new System.Drawing.Point(112, 144);
            this.ListViewDrivers.Name = "ListViewDrivers";
            this.ListViewDrivers.Size = new System.Drawing.Size(414, 192);
            this.ListViewDrivers.TabIndex = 53;
            this.ListViewDrivers.UseCompatibleStateImageBehavior = false;
            this.ListViewDrivers.View = System.Windows.Forms.View.Details;
            this.ListViewDrivers.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListViewDrivers_ItemChecked);
            // 
            // DriverType
            // 
            this.DriverType.Text = "Driver Type";
            this.DriverType.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Driver";
            this.columnHeader2.Width = 150;
            // 
            // ProjectDomainDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListViewDrivers);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnModel);
            this.Controls.Add(this.BtnManageSource);
            this.Controls.Add(this.ComboBoxPackages);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ComboBoxSourceType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ComboBoxCollectionOption);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBoxNamingConvention);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label5);
            this.Name = "ProjectDomainDetailsUserControl";
            this.Size = new System.Drawing.Size(557, 359);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBoxPackages;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.ListView ListViewDrivers;
        private System.Windows.Forms.ColumnHeader DriverType;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
