namespace DotNetScaffolder.Presentation.Forms.Controls
{
    partial class ModelForm
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
            this.modelFormUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.ModelFormUserControl();
            this.SuspendLayout();
            // 
            // modelFormUserControl1
            // 
            this.modelFormUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelFormUserControl1.Location = new System.Drawing.Point(0, 0);
            this.modelFormUserControl1.Name = "modelFormUserControl1";
            this.modelFormUserControl1.Size = new System.Drawing.Size(1615, 789);
            this.modelFormUserControl1.TabIndex = 0;
            this.modelFormUserControl1.Load += new System.EventHandler(this.modelFormUserControl1_Load);
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 789);
            this.Controls.Add(this.modelFormUserControl1);
            this.Name = "ModelForm";
            this.Text = "Manage Models";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private ModelFormUserControl modelFormUserControl1;
    }
}