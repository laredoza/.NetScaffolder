namespace DotNetScaffolder.Presentation.Forms.Controls.Model
{
    partial class ModelFieldUserControl
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
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtBoxDefault = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtBoxScale = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtBoxPrecision = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CheckBoxPrimaryKey = new System.Windows.Forms.CheckBox();
            this.TxtBoxLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBoxRequired = new System.Windows.Forms.CheckBox();
            this.ComboBoxDataType = new System.Windows.Forms.ComboBox();
            this.LblOrder = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.ComboBoxRemapDataType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtDescription);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TxtBoxDefault);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.TxtBoxScale);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtBoxPrecision);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.CheckBoxPrimaryKey);
            this.groupBox1.Controls.Add(this.TxtBoxLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CheckBoxRequired);
            this.groupBox1.Controls.Add(this.ComboBoxDataType);
            this.groupBox1.Controls.Add(this.LblOrder);
            this.groupBox1.Controls.Add(this.LblName);
            this.groupBox1.Controls.Add(this.ComboBoxRemapDataType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 491);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Field Details";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(116, 42);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(121, 20);
            this.TxtDescription.TabIndex = 77;
            this.TxtDescription.TextChanged += new System.EventHandler(this.TxtDescription_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "Description:";
            // 
            // TxtBoxDefault
            // 
            this.TxtBoxDefault.Location = new System.Drawing.Point(113, 221);
            this.TxtBoxDefault.Name = "TxtBoxDefault";
            this.TxtBoxDefault.Size = new System.Drawing.Size(121, 20);
            this.TxtBoxDefault.TabIndex = 74;
            this.TxtBoxDefault.TextChanged += new System.EventHandler(this.TxtBoxDefault_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 73;
            this.label13.Text = "Default Value:";
            // 
            // TxtBoxScale
            // 
            this.TxtBoxScale.Location = new System.Drawing.Point(113, 192);
            this.TxtBoxScale.Name = "TxtBoxScale";
            this.TxtBoxScale.Size = new System.Drawing.Size(121, 20);
            this.TxtBoxScale.TabIndex = 72;
            this.TxtBoxScale.Text = "0";
            this.TxtBoxScale.TextChanged += new System.EventHandler(this.TxtBoxScale_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "Scale:";
            // 
            // TxtBoxPrecision
            // 
            this.TxtBoxPrecision.Location = new System.Drawing.Point(113, 166);
            this.TxtBoxPrecision.Name = "TxtBoxPrecision";
            this.TxtBoxPrecision.Size = new System.Drawing.Size(121, 20);
            this.TxtBoxPrecision.TabIndex = 70;
            this.TxtBoxPrecision.Text = "0";
            this.TxtBoxPrecision.TextChanged += new System.EventHandler(this.TxtBoxPrecision_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "Precision:";
            // 
            // CheckBoxPrimaryKey
            // 
            this.CheckBoxPrimaryKey.AutoSize = true;
            this.CheckBoxPrimaryKey.Location = new System.Drawing.Point(188, 259);
            this.CheckBoxPrimaryKey.Name = "CheckBoxPrimaryKey";
            this.CheckBoxPrimaryKey.Size = new System.Drawing.Size(81, 17);
            this.CheckBoxPrimaryKey.TabIndex = 68;
            this.CheckBoxPrimaryKey.Text = "Primary Key";
            this.CheckBoxPrimaryKey.UseVisualStyleBackColor = true;
            this.CheckBoxPrimaryKey.CheckedChanged += new System.EventHandler(this.CheckBoxPrimaryKey_CheckedChanged);
            // 
            // TxtBoxLength
            // 
            this.TxtBoxLength.Location = new System.Drawing.Point(113, 118);
            this.TxtBoxLength.Name = "TxtBoxLength";
            this.TxtBoxLength.Size = new System.Drawing.Size(121, 20);
            this.TxtBoxLength.TabIndex = 67;
            this.TxtBoxLength.TextChanged += new System.EventHandler(this.TxtBoxLength_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Length:";
            // 
            // CheckBoxRequired
            // 
            this.CheckBoxRequired.AutoSize = true;
            this.CheckBoxRequired.Location = new System.Drawing.Point(113, 259);
            this.CheckBoxRequired.Name = "CheckBoxRequired";
            this.CheckBoxRequired.Size = new System.Drawing.Size(69, 17);
            this.CheckBoxRequired.TabIndex = 65;
            this.CheckBoxRequired.Text = "Required";
            this.CheckBoxRequired.UseVisualStyleBackColor = true;
            this.CheckBoxRequired.CheckedChanged += new System.EventHandler(this.CheckBoxRequired_CheckedChanged);
            // 
            // ComboBoxDataType
            // 
            this.ComboBoxDataType.Enabled = false;
            this.ComboBoxDataType.FormattingEnabled = true;
            this.ComboBoxDataType.Items.AddRange(new object[] {
            "None",
            "Integer",
            "Decimal"});
            this.ComboBoxDataType.Location = new System.Drawing.Point(113, 91);
            this.ComboBoxDataType.Name = "ComboBoxDataType";
            this.ComboBoxDataType.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxDataType.TabIndex = 64;
            this.ComboBoxDataType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDataType_SelectedIndexChanged);
            // 
            // LblOrder
            // 
            this.LblOrder.AutoSize = true;
            this.LblOrder.Location = new System.Drawing.Point(116, 72);
            this.LblOrder.Name = "LblOrder";
            this.LblOrder.Size = new System.Drawing.Size(13, 13);
            this.LblOrder.TabIndex = 63;
            this.LblOrder.Text = "1";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(113, 26);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(16, 13);
            this.LblName.TabIndex = 62;
            this.LblName.Text = "Id";
            // 
            // ComboBoxRemapDataType
            // 
            this.ComboBoxRemapDataType.FormattingEnabled = true;
            this.ComboBoxRemapDataType.Items.AddRange(new object[] {
            "None",
            "Integer",
            "Decimal"});
            this.ComboBoxRemapDataType.Location = new System.Drawing.Point(113, 142);
            this.ComboBoxRemapDataType.Name = "ComboBoxRemapDataType";
            this.ComboBoxRemapDataType.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxRemapDataType.TabIndex = 61;
            this.ComboBoxRemapDataType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRemapDataType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Remap Data Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Data Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Order:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Name:";
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // ModelFieldUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModelFieldUserControl";
            this.Size = new System.Drawing.Size(724, 502);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtBoxDefault;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtBoxScale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtBoxPrecision;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox CheckBoxPrimaryKey;
        private System.Windows.Forms.TextBox TxtBoxLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBoxRequired;
        private System.Windows.Forms.ComboBox ComboBoxDataType;
        private System.Windows.Forms.Label LblOrder;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ComboBox ComboBoxRemapDataType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
    }
}
