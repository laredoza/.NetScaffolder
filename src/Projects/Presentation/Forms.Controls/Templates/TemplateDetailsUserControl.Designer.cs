namespace DotNetScaffolder.Presentation.Forms.Controls.Templates
{
    partial class TemplateDetailsUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckBoxEnabled = new System.Windows.Forms.CheckBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PanelTemplate = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBoxGeneratorOutput = new System.Windows.Forms.ComboBox();
            this.LblVersion = new System.Windows.Forms.Label();
            this.ListBoxTemplates = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ComboBoxLanguageOutput = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.PanelTemplate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckBoxEnabled);
            this.panel1.Controls.Add(this.TextBoxName);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 43);
            this.panel1.TabIndex = 59;
            // 
            // CheckBoxEnabled
            // 
            this.CheckBoxEnabled.AutoSize = true;
            this.CheckBoxEnabled.Location = new System.Drawing.Point(115, 26);
            this.CheckBoxEnabled.Name = "CheckBoxEnabled";
            this.CheckBoxEnabled.Size = new System.Drawing.Size(65, 17);
            this.CheckBoxEnabled.TabIndex = 61;
            this.CheckBoxEnabled.Text = "Enabled";
            this.CheckBoxEnabled.UseVisualStyleBackColor = true;
            this.CheckBoxEnabled.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(115, 0);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(238, 20);
            this.TextBoxName.TabIndex = 54;
            this.TextBoxName.Text = "Entity Framework";
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Name:";
            // 
            // PanelTemplate
            // 
            this.PanelTemplate.Controls.Add(this.groupBox1);
            this.PanelTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTemplate.Location = new System.Drawing.Point(0, 43);
            this.PanelTemplate.Name = "PanelTemplate";
            this.PanelTemplate.Size = new System.Drawing.Size(466, 206);
            this.PanelTemplate.TabIndex = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBoxGeneratorOutput);
            this.groupBox1.Controls.Add(this.LblVersion);
            this.groupBox1.Controls.Add(this.ListBoxTemplates);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.BtnOpen);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.ComboBoxLanguageOutput);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Template";
            // 
            // ComboBoxGeneratorOutput
            // 
            this.ComboBoxGeneratorOutput.Enabled = false;
            this.ComboBoxGeneratorOutput.FormattingEnabled = true;
            this.ComboBoxGeneratorOutput.Location = new System.Drawing.Point(112, 48);
            this.ComboBoxGeneratorOutput.Name = "ComboBoxGeneratorOutput";
            this.ComboBoxGeneratorOutput.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxGeneratorOutput.TabIndex = 86;
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Location = new System.Drawing.Point(109, 163);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(13, 13);
            this.LblVersion.TabIndex = 85;
            this.LblVersion.Text = "1";
            // 
            // ListBoxTemplates
            // 
            this.ListBoxTemplates.Enabled = false;
            this.ListBoxTemplates.FormattingEnabled = true;
            this.ListBoxTemplates.Location = new System.Drawing.Point(112, 75);
            this.ListBoxTemplates.Name = "ListBoxTemplates";
            this.ListBoxTemplates.Size = new System.Drawing.Size(238, 82);
            this.ListBoxTemplates.TabIndex = 84;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 82;
            this.label15.Text = "Version:";
            // 
            // BtnOpen
            // 
            this.BtnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpen.Enabled = false;
            this.BtnOpen.Location = new System.Drawing.Point(370, 134);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(75, 23);
            this.BtnOpen.TabIndex = 78;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 79;
            this.label14.Text = "Templates:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 76;
            this.label19.Text = "Generator Type:";
            // 
            // ComboBoxLanguageOutput
            // 
            this.ComboBoxLanguageOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLanguageOutput.FormattingEnabled = true;
            this.ComboBoxLanguageOutput.Location = new System.Drawing.Point(112, 19);
            this.ComboBoxLanguageOutput.Name = "ComboBoxLanguageOutput";
            this.ComboBoxLanguageOutput.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxLanguageOutput.TabIndex = 75;
            this.ComboBoxLanguageOutput.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLanguageOutput_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 13);
            this.label18.TabIndex = 74;
            this.label18.Text = "Language Output:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TemplateDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTemplate);
            this.Controls.Add(this.panel1);
            this.Name = "TemplateDetailsUserControl";
            this.Size = new System.Drawing.Size(466, 255);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelTemplate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelTemplate;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox CheckBoxEnabled;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox ComboBoxLanguageOutput;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox ListBoxTemplates;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.ComboBox ComboBoxGeneratorOutput;
    }
}
