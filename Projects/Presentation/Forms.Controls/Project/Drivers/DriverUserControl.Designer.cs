namespace DotNetScaffolder.Presentation.Forms.Controls.Project.Drivers
{
    partial class DriverUserControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkColumnOrder = new System.Windows.Forms.CheckBox();
            this.ProxyCreation = new System.Windows.Forms.CheckBox();
            this.LoggingEnabled = new System.Windows.Forms.CheckBox();
            this.CreateDb = new System.Windows.Forms.CheckBox();
            this.LazyLoading = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 163);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkColumnOrder);
            this.tabPage1.Controls.Add(this.ProxyCreation);
            this.tabPage1.Controls.Add(this.LoggingEnabled);
            this.tabPage1.Controls.Add(this.CreateDb);
            this.tabPage1.Controls.Add(this.LazyLoading);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(342, 137);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entity Framework 6";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkColumnOrder
            // 
            this.chkColumnOrder.AutoSize = true;
            this.chkColumnOrder.Location = new System.Drawing.Point(16, 89);
            this.chkColumnOrder.Name = "chkColumnOrder";
            this.chkColumnOrder.Size = new System.Drawing.Size(125, 17);
            this.chkColumnOrder.TabIndex = 67;
            this.chkColumnOrder.Text = "Include column order";
            this.chkColumnOrder.UseVisualStyleBackColor = true;
            // 
            // ProxyCreation
            // 
            this.ProxyCreation.AutoSize = true;
            this.ProxyCreation.Location = new System.Drawing.Point(16, 71);
            this.ProxyCreation.Name = "ProxyCreation";
            this.ProxyCreation.Size = new System.Drawing.Size(128, 17);
            this.ProxyCreation.TabIndex = 66;
            this.ProxyCreation.Text = "Enable proxy creation";
            this.ProxyCreation.UseVisualStyleBackColor = true;
            // 
            // LoggingEnabled
            // 
            this.LoggingEnabled.AutoSize = true;
            this.LoggingEnabled.Location = new System.Drawing.Point(16, 53);
            this.LoggingEnabled.Name = "LoggingEnabled";
            this.LoggingEnabled.Size = new System.Drawing.Size(96, 17);
            this.LoggingEnabled.TabIndex = 65;
            this.LoggingEnabled.Text = "Enable logging";
            this.LoggingEnabled.UseVisualStyleBackColor = true;
            // 
            // CreateDb
            // 
            this.CreateDb.AutoSize = true;
            this.CreateDb.Location = new System.Drawing.Point(16, 16);
            this.CreateDb.Name = "CreateDb";
            this.CreateDb.Size = new System.Drawing.Size(184, 17);
            this.CreateDb.TabIndex = 63;
            this.CreateDb.Text = "Create Database If it doesn\'t exist";
            this.CreateDb.UseVisualStyleBackColor = true;
            // 
            // LazyLoading
            // 
            this.LazyLoading.AutoSize = true;
            this.LazyLoading.Location = new System.Drawing.Point(16, 35);
            this.LazyLoading.Name = "LazyLoading";
            this.LazyLoading.Size = new System.Drawing.Size(117, 17);
            this.LazyLoading.TabIndex = 64;
            this.LazyLoading.Text = "Enable lazy loading";
            this.LazyLoading.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(342, 137);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Entity Framework Core";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(342, 137);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "NHibernate";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DriverUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "DriverUserControl";
            this.Size = new System.Drawing.Size(357, 171);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkColumnOrder;
        private System.Windows.Forms.CheckBox ProxyCreation;
        private System.Windows.Forms.CheckBox LoggingEnabled;
        private System.Windows.Forms.CheckBox CreateDb;
        private System.Windows.Forms.CheckBox LazyLoading;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
