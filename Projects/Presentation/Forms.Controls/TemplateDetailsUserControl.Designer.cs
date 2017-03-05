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
            this.ComboBoxGeneratorOutput = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ComboBoxLanguageOutput = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.ComboBoxSetupLocation = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TextBoxVersion = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TextBoxTemplate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBoxGeneratorOutput
            // 
            this.ComboBoxGeneratorOutput.FormattingEnabled = true;
            this.ComboBoxGeneratorOutput.Location = new System.Drawing.Point(117, 152);
            this.ComboBoxGeneratorOutput.Name = "ComboBoxGeneratorOutput";
            this.ComboBoxGeneratorOutput.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxGeneratorOutput.TabIndex = 58;
            this.ComboBoxGeneratorOutput.Text = "T4";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 154);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 57;
            this.label19.Text = "Generator Type:";
            // 
            // ComboBoxLanguageOutput
            // 
            this.ComboBoxLanguageOutput.FormattingEnabled = true;
            this.ComboBoxLanguageOutput.Location = new System.Drawing.Point(117, 125);
            this.ComboBoxLanguageOutput.Name = "ComboBoxLanguageOutput";
            this.ComboBoxLanguageOutput.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxLanguageOutput.TabIndex = 56;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "Language Output:";
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(280, 202);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 52;
            this.button11.Text = "Default";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // ComboBoxSetupLocation
            // 
            this.ComboBoxSetupLocation.FormattingEnabled = true;
            this.ComboBoxSetupLocation.Items.AddRange(new object[] {
            "Data",
            "Driver"});
            this.ComboBoxSetupLocation.Location = new System.Drawing.Point(117, 72);
            this.ComboBoxSetupLocation.Name = "ComboBoxSetupLocation";
            this.ComboBoxSetupLocation.Size = new System.Drawing.Size(238, 21);
            this.ComboBoxSetupLocation.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "Setup Location:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(61, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Version:";
            // 
            // TextBoxVersion
            // 
            this.TextBoxVersion.Location = new System.Drawing.Point(117, 99);
            this.TextBoxVersion.Name = "TextBoxVersion";
            this.TextBoxVersion.Size = new System.Drawing.Size(238, 20);
            this.TextBoxVersion.TabIndex = 48;
            this.TextBoxVersion.Text = "0";
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(361, 46);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 40;
            this.button8.Text = "Edit";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(117, 182);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "Enabled";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TextBoxTemplate
            // 
            this.TextBoxTemplate.Location = new System.Drawing.Point(117, 46);
            this.TextBoxTemplate.Name = "TextBoxTemplate";
            this.TextBoxTemplate.Size = new System.Drawing.Size(238, 20);
            this.TextBoxTemplate.TabIndex = 46;
            this.TextBoxTemplate.Text = "Entity\\EntityFramework.tmp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Template:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(117, 20);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(238, 20);
            this.TextBoxName.TabIndex = 44;
            this.TextBoxName.Text = "Entity Framework";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Name:";
            // 
            // TemplateDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ComboBoxGeneratorOutput);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.ComboBoxLanguageOutput);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.ComboBoxSetupLocation);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TextBoxVersion);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TextBoxTemplate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label13);
            this.Name = "TemplateDetailsUserControl";
            this.Size = new System.Drawing.Size(451, 240);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxGeneratorOutput;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox ComboBoxLanguageOutput;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox ComboBoxSetupLocation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TextBoxVersion;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox TextBoxTemplate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label13;
    }
}
