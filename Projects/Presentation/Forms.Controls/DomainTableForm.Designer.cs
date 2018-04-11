namespace DotNetScaffolder.Presentation.Forms.Controls
{
    partial class DomainTableForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelConfig = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.domainMenuUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.DomainMenuUserControl();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 781F));
            this.tableLayoutPanel1.Controls.Add(this.domainMenuUserControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelConfig, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1059, 458);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PanelConfig
            // 
            this.PanelConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelConfig.Location = new System.Drawing.Point(280, 2);
            this.PanelConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelConfig.Name = "PanelConfig";
            this.PanelConfig.Size = new System.Drawing.Size(777, 454);
            this.PanelConfig.TabIndex = 7;
            this.PanelConfig.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelConfig_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(982, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(820, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // domainMenuUserControl1
            // 
            this.domainMenuUserControl1.DataSource = null;
            this.domainMenuUserControl1.Location = new System.Drawing.Point(1, 1);
            this.domainMenuUserControl1.Margin = new System.Windows.Forms.Padding(1);
            this.domainMenuUserControl1.Name = "domainMenuUserControl1";
            this.domainMenuUserControl1.OutputPath = null;
            this.domainMenuUserControl1.ParentConfigControl = null;
            this.domainMenuUserControl1.Size = new System.Drawing.Size(273, 454);
            this.domainMenuUserControl1.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(901, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "button3";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DomainTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 499);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DomainTableForm";
            this.Text = "Domain";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DomainMenuUserControl domainMenuUserControl1;
        private System.Windows.Forms.Panel PanelConfig;
        private System.Windows.Forms.Button btnSave;
    }
}