namespace DotNetScaffolder.Presentation.Forms.Controls
{
    partial class ManageDataSourceForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnTest = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(567, 225);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 35);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Close";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(447, 225);
            this.BtnTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(112, 35);
            this.BtnTest.TabIndex = 5;
            this.BtnTest.Text = "Test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(682, 205);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(674, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ManageDataSourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 274);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ManageDataSourceForm";
            this.Text = "Update Datasource";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}