namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources
{
    partial class SqlServerAdoUserControl
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
            this.components = new System.ComponentModel.Container();
            this.TxtConnection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ListViewDrivers = new System.Windows.Forms.ListView();
            this.Schema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtConnection
            // 
            this.TxtConnection.Location = new System.Drawing.Point(82, 17);
            this.TxtConnection.Name = "TxtConnection";
            this.TxtConnection.Size = new System.Drawing.Size(352, 20);
            this.TxtConnection.TabIndex = 8;
            this.TxtConnection.TextChanged += new System.EventHandler(this.TxtConnection_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Connection:";
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Schema:";
            // 
            // ListViewDrivers
            // 
            this.ListViewDrivers.CheckBoxes = true;
            this.ListViewDrivers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Schema});
            this.ListViewDrivers.Location = new System.Drawing.Point(82, 51);
            this.ListViewDrivers.Name = "ListViewDrivers";
            this.ListViewDrivers.Size = new System.Drawing.Size(352, 176);
            this.ListViewDrivers.TabIndex = 54;
            this.ListViewDrivers.UseCompatibleStateImageBehavior = false;
            this.ListViewDrivers.View = System.Windows.Forms.View.Details;
            this.ListViewDrivers.SelectedIndexChanged += new System.EventHandler(this.ListViewDrivers_SelectedIndexChanged);
            // 
            // Schema
            // 
            this.Schema.Text = "Schema";
            this.Schema.Width = 250;
            // 
            // SqlServerAdoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListViewDrivers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtConnection);
            this.Controls.Add(this.label2);
            this.Name = "SqlServerAdoUserControl";
            this.Size = new System.Drawing.Size(502, 245);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListViewDrivers;
        private System.Windows.Forms.ColumnHeader Schema;
    }
}
