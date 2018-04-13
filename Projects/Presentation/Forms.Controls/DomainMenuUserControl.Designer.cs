namespace DotNetScaffolder.Presentation.Forms.Controls
{
    partial class DomainMenuUserControl
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
            this.DomainTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // DomainTreeView
            // 
            this.DomainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DomainTreeView.Location = new System.Drawing.Point(0, 0);
            this.DomainTreeView.Name = "DomainTreeView";
            this.DomainTreeView.Size = new System.Drawing.Size(383, 508);
            this.DomainTreeView.TabIndex = 3;
            this.DomainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DomainTreeView_AfterSelect);
            this.DomainTreeView.Click += new System.EventHandler(this.DomainTreeView_Click);
            // 
            // DomainMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DomainTreeView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DomainMenuUserControl";
            this.Size = new System.Drawing.Size(383, 508);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView DomainTreeView;
    }
}
