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
            this.chkUseAlias = new System.Windows.Forms.CheckBox();
            this.checkCaching = new System.Windows.Forms.CheckBox();
            this.groupBoxCaching = new System.Windows.Forms.GroupBox();
            this.comboBoxCaching = new System.Windows.Forms.ComboBox();
            this.groupBoxCaching.SuspendLayout();
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
            // chkUseAlias
            // 
            this.chkUseAlias.AutoSize = true;
            this.chkUseAlias.Location = new System.Drawing.Point(14, 103);
            this.chkUseAlias.Name = "chkUseAlias";
            this.chkUseAlias.Size = new System.Drawing.Size(70, 17);
            this.chkUseAlias.TabIndex = 74;
            this.chkUseAlias.Text = "Use Alias";
            this.chkUseAlias.UseVisualStyleBackColor = true;
            // 
            // checkCaching
            // 
            this.checkCaching.AutoSize = true;
            this.checkCaching.Location = new System.Drawing.Point(14, 126);
            this.checkCaching.Name = "checkCaching";
            this.checkCaching.Size = new System.Drawing.Size(100, 17);
            this.checkCaching.TabIndex = 77;
            this.checkCaching.Text = "Enable caching";
            this.checkCaching.UseVisualStyleBackColor = true;
            this.checkCaching.CheckedChanged += new System.EventHandler(this.checkCaching_CheckedChanged);
            // 
            // groupBoxCaching
            // 
            this.groupBoxCaching.Controls.Add(this.comboBoxCaching);
            this.groupBoxCaching.Location = new System.Drawing.Point(14, 149);
            this.groupBoxCaching.Name = "groupBoxCaching";
            this.groupBoxCaching.Size = new System.Drawing.Size(200, 67);
            this.groupBoxCaching.TabIndex = 76;
            this.groupBoxCaching.TabStop = false;
            this.groupBoxCaching.Text = "Caching Options";
            // 
            // comboBoxCaching
            // 
            this.comboBoxCaching.FormattingEnabled = true;
            this.comboBoxCaching.Location = new System.Drawing.Point(7, 30);
            this.comboBoxCaching.Name = "comboBoxCaching";
            this.comboBoxCaching.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCaching.TabIndex = 0;
            this.comboBoxCaching.SelectedIndexChanged += new System.EventHandler(this.comboBoxCaching_SelectedIndexChanged);
            // 
            // EFDriverTypeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkCaching);
            this.Controls.Add(this.groupBoxCaching);
            this.Controls.Add(this.chkUseAlias);
            this.Controls.Add(this.chkColumnOrder);
            this.Controls.Add(this.ProxyCreation);
            this.Controls.Add(this.LoggingEnabled);
            this.Controls.Add(this.CreateDb);
            this.Controls.Add(this.LazyLoading);
            this.Name = "EFDriverTypeUserControl";
            this.Size = new System.Drawing.Size(303, 228);
            this.groupBoxCaching.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkColumnOrder;
        private System.Windows.Forms.CheckBox ProxyCreation;
        private System.Windows.Forms.CheckBox LoggingEnabled;
        private System.Windows.Forms.CheckBox CreateDb;
        private System.Windows.Forms.CheckBox LazyLoading;
        private System.Windows.Forms.CheckBox chkUseAlias;
        private System.Windows.Forms.CheckBox checkCaching;
        private System.Windows.Forms.GroupBox groupBoxCaching;
        private System.Windows.Forms.ComboBox comboBoxCaching;
    }
}
