namespace DotNetScaffolder.Presentation.Forms.Controls.Sources
{
    partial class UpdateModelsFromSourceForm
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.updateModelsFromSourceUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.Sources.UpdateModelsFromSourceUserControl();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(639, 618);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(112, 35);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Ok";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(760, 618);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateModelsFromSourceUserControl1
            // 
            this.updateModelsFromSourceUserControl1.DataSource = null;
            this.updateModelsFromSourceUserControl1.Location = new System.Drawing.Point(14, 12);
            this.updateModelsFromSourceUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateModelsFromSourceUserControl1.Name = "updateModelsFromSourceUserControl1";
            this.updateModelsFromSourceUserControl1.SavePath = null;
            this.updateModelsFromSourceUserControl1.Size = new System.Drawing.Size(912, 582);
            this.updateModelsFromSourceUserControl1.TabIndex = 3;
            // 
            // UpdateModelsFromSourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 671);
            this.Controls.Add(this.updateModelsFromSourceUserControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "UpdateModelsFromSourceForm";
            this.Text = "Update Tables From Source";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button button3;
        private UpdateModelsFromSourceUserControl updateModelsFromSourceUserControl1;
    }
}