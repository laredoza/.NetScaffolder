namespace DotNetScaffolder.Presentation.Forms.Controls
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelTemplate = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TextBoxVersion = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.TextBoxTemplate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ComboBoxGeneratorOutput = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ComboBoxLanguageOutput = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ComboBoxSetupLocation = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PanelTemplate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.TextBoxName);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 43);
            this.panel1.TabIndex = 59;
            // 
            // PanelTemplate
            // 
            this.PanelTemplate.Controls.Add(this.groupBox1);
            this.PanelTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTemplate.Location = new System.Drawing.Point(0, 43);
            this.PanelTemplate.Name = "PanelTemplate";
            this.PanelTemplate.Size = new System.Drawing.Size(451, 169);
            this.PanelTemplate.TabIndex = 60;
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(359, -2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 62;
            this.button11.Text = "Default";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(115, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 61;
            this.checkBox1.Text = "Enabled";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.TextBoxVersion);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.TextBoxTemplate);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.ComboBoxGeneratorOutput);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.ComboBoxLanguageOutput);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.ComboBoxSetupLocation);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Template";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 82;
            this.label15.Text = "Version:";
            // 
            // TextBoxVersion
            // 
            this.TextBoxVersion.Location = new System.Drawing.Point(112, 126);
            this.TextBoxVersion.Name = "TextBoxVersion";
            this.TextBoxVersion.Size = new System.Drawing.Size(238, 20);
            this.TextBoxVersion.TabIndex = 81;
            this.TextBoxVersion.Text = "0";
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(356, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 78;
            this.button8.Text = "Edit";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // TextBoxTemplate
            // 
            this.TextBoxTemplate.Location = new System.Drawing.Point(112, 100);
            this.TextBoxTemplate.Name = "TextBoxTemplate";
            this.TextBoxTemplate.Size = new System.Drawing.Size(238, 20);
            this.TextBoxTemplate.TabIndex = 80;
            this.TextBoxTemplate.Text = "Entity\\EntityFramework.tmp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 79;
            this.label14.Text = "Template:";
            // 
            // ComboBoxGeneratorOutput
            // 
            this.ComboBoxGeneratorOutput.FormattingEnabled = true;
            this.ComboBoxGeneratorOutput.Location = new System.Drawing.Point(112, 73);
            this.ComboBoxGeneratorOutput.Name = "ComboBoxGeneratorOutput";
            this.ComboBoxGeneratorOutput.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxGeneratorOutput.TabIndex = 77;
            this.ComboBoxGeneratorOutput.Text = "T4";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 76;
            this.label19.Text = "Generator Type:";
            // 
            // ComboBoxLanguageOutput
            // 
            this.ComboBoxLanguageOutput.FormattingEnabled = true;
            this.ComboBoxLanguageOutput.Location = new System.Drawing.Point(112, 19);
            this.ComboBoxLanguageOutput.Name = "ComboBoxLanguageOutput";
            this.ComboBoxLanguageOutput.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxLanguageOutput.TabIndex = 75;
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
            // ComboBoxSetupLocation
            // 
            this.ComboBoxSetupLocation.FormattingEnabled = true;
            this.ComboBoxSetupLocation.Items.AddRange(new object[] {
            "Data",
            "Driver"});
            this.ComboBoxSetupLocation.Location = new System.Drawing.Point(112, 46);
            this.ComboBoxSetupLocation.Name = "ComboBoxSetupLocation";
            this.ComboBoxSetupLocation.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxSetupLocation.TabIndex = 73;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 72;
            this.label16.Text = "Setup Location:";
            // 
            // TemplateDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTemplate);
            this.Controls.Add(this.panel1);
            this.Name = "TemplateDetailsUserControl";
            this.Size = new System.Drawing.Size(451, 223);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelTemplate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelTemplate;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TextBoxVersion;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox TextBoxTemplate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ComboBoxGeneratorOutput;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox ComboBoxLanguageOutput;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox ComboBoxSetupLocation;
        private System.Windows.Forms.Label label16;
    }
}
