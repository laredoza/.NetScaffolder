namespace DefaultDrivers.Forms
{
    partial class EFDriverTypeUserControl
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
            //base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkColumnOrder = new System.Windows.Forms.CheckBox();
            this.ProxyCreation = new System.Windows.Forms.CheckBox();
            this.LoggingEnabled = new System.Windows.Forms.CheckBox();
            this.CreateDb = new System.Windows.Forms.CheckBox();
            this.LazyLoading = new System.Windows.Forms.CheckBox();
            this.chkUseConfigClasses = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkColumnOrder
            // 
            this.chkColumnOrder.AutoSize = true;
            this.chkColumnOrder.Location = new System.Drawing.Point(14, 85);
            this.chkColumnOrder.Name = "chkColumnOrder";
            this.chkColumnOrder.Size = new System.Drawing.Size(125, 17);
            this.chkColumnOrder.TabIndex = 67;
            this.chkColumnOrder.Text = "Include column order";
            this.chkColumnOrder.UseVisualStyleBackColor = true;
            // 
            // ProxyCreation
            // 
            this.ProxyCreation.AutoSize = true;
            this.ProxyCreation.Location = new System.Drawing.Point(14, 67);
            this.ProxyCreation.Name = "ProxyCreation";
            this.ProxyCreation.Size = new System.Drawing.Size(128, 17);
            this.ProxyCreation.TabIndex = 66;
            this.ProxyCreation.Text = "Enable proxy creation";
            this.ProxyCreation.UseVisualStyleBackColor = true;
            // 
            // LoggingEnabled
            // 
            this.LoggingEnabled.AutoSize = true;
            this.LoggingEnabled.Location = new System.Drawing.Point(14, 49);
            this.LoggingEnabled.Name = "LoggingEnabled";
            this.LoggingEnabled.Size = new System.Drawing.Size(96, 17);
            this.LoggingEnabled.TabIndex = 65;
            this.LoggingEnabled.Text = "Enable logging";
            this.LoggingEnabled.UseVisualStyleBackColor = true;
            // 
            // CreateDb
            // 
            this.CreateDb.AutoSize = true;
            this.CreateDb.Location = new System.Drawing.Point(14, 12);
            this.CreateDb.Name = "CreateDb";
            this.CreateDb.Size = new System.Drawing.Size(184, 17);
            this.CreateDb.TabIndex = 63;
            this.CreateDb.Text = "Create Database If it doesn\'t exist";
            this.CreateDb.UseVisualStyleBackColor = true;
            // 
            // LazyLoading
            // 
            this.LazyLoading.AutoSize = true;
            this.LazyLoading.Location = new System.Drawing.Point(14, 31);
            this.LazyLoading.Name = "LazyLoading";
            this.LazyLoading.Size = new System.Drawing.Size(117, 17);
            this.LazyLoading.TabIndex = 64;
            this.LazyLoading.Text = "Enable lazy loading";
            this.LazyLoading.UseVisualStyleBackColor = true;
            // 
            // chkUseConfigClasses
            // 
            this.chkUseConfigClasses.AutoSize = true;
            this.chkUseConfigClasses.Location = new System.Drawing.Point(14, 103);
            this.chkUseConfigClasses.Name = "chkUseConfigClasses";
            this.chkUseConfigClasses.Size = new System.Drawing.Size(191, 17);
            this.chkUseConfigClasses.TabIndex = 74;
            this.chkUseConfigClasses.Text = "Use seperate configuration classes";
            this.chkUseConfigClasses.UseVisualStyleBackColor = true;
            // 
            // EFDriverTypeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkUseConfigClasses);
            this.Controls.Add(this.chkColumnOrder);
            this.Controls.Add(this.ProxyCreation);
            this.Controls.Add(this.LoggingEnabled);
            this.Controls.Add(this.CreateDb);
            this.Controls.Add(this.LazyLoading);
            this.Name = "EFDriverTypeUserControl";
            this.Size = new System.Drawing.Size(352, 173);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkColumnOrder;
        private System.Windows.Forms.CheckBox ProxyCreation;
        private System.Windows.Forms.CheckBox LoggingEnabled;
        private System.Windows.Forms.CheckBox CreateDb;
        private System.Windows.Forms.CheckBox LazyLoading;
        private System.Windows.Forms.CheckBox chkUseConfigClasses;
    }
}
