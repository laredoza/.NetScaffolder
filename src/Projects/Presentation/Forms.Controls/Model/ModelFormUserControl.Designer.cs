namespace DotNetScaffolder.Presentation.Forms.Controls.Model
{
    partial class ModelFormUserControl
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
            this.PanelConfig = new System.Windows.Forms.Panel();
            this.btnAddIndex = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DomainTreeView = new System.Windows.Forms.TreeView();
            this.lblAddIndex = new System.Windows.Forms.Label();
            this.PanelConfig.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelConfig
            // 
            this.PanelConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelConfig.Controls.Add(this.lblAddIndex);
            this.PanelConfig.Controls.Add(this.btnAddIndex);
            this.PanelConfig.Location = new System.Drawing.Point(302, 2);
            this.PanelConfig.Margin = new System.Windows.Forms.Padding(2);
            this.PanelConfig.Name = "PanelConfig";
            this.PanelConfig.Size = new System.Drawing.Size(767, 513);
            this.PanelConfig.TabIndex = 7;
            // 
            // btnAddIndex
            // 
            this.btnAddIndex.Location = new System.Drawing.Point(16, 17);
            this.btnAddIndex.Name = "btnAddIndex";
            this.btnAddIndex.Size = new System.Drawing.Size(111, 23);
            this.btnAddIndex.TabIndex = 5;
            this.btnAddIndex.Text = "Add Index";
            this.btnAddIndex.UseVisualStyleBackColor = true;
            this.btnAddIndex.Click += new System.EventHandler(this.btnAddIndex_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 771F));
            this.tableLayoutPanel1.Controls.Add(this.DomainTreeView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelConfig, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 517);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // DomainTreeView
            // 
            this.DomainTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.DomainTreeView.Location = new System.Drawing.Point(3, 3);
            this.DomainTreeView.Name = "DomainTreeView";
            this.DomainTreeView.Size = new System.Drawing.Size(294, 511);
            this.DomainTreeView.TabIndex = 9;
            this.DomainTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.DomainTreeView_BeforeSelect);
            this.DomainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DomainTreeView_AfterSelect);
            // 
            // lblAddIndex
            // 
            this.lblAddIndex.AutoSize = true;
            this.lblAddIndex.Location = new System.Drawing.Point(16, 47);
            this.lblAddIndex.Name = "lblAddIndex";
            this.lblAddIndex.Size = new System.Drawing.Size(393, 13);
            this.lblAddIndex.TabIndex = 6;
            this.lblAddIndex.Text = "(Note: The index must correlate with the indexes created in the physical database" +
    ")\r\n";
            // 
            // ModelFormUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModelFormUserControl";
            this.Size = new System.Drawing.Size(735, 517);
            this.PanelConfig.ResumeLayout(false);
            this.PanelConfig.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelConfig;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView DomainTreeView;
        private System.Windows.Forms.Button btnAddIndex;
        private System.Windows.Forms.Label lblAddIndex;
    }
}
