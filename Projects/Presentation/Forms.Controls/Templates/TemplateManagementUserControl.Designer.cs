namespace DotNetScaffolder.Presentation.Forms.Controls
{
    using DotNetScaffolder.Presentation.Forms.Controls.Core;

    using FormControls.Enum;

    partial class TemplateManagementUserControl
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TemplateDetailsUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.TemplateDetailsUserControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ManageTemplateTreeViewUserControl1 = new DotNetScaffolder.Presentation.Forms.Controls.Core.ManageCollectionsTreeViewUserControl();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TemplateDetailsUserControl1);
            this.groupBox5.Location = new System.Drawing.Point(411, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(505, 486);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Details";
            // 
            // TemplateDetailsUserControl1
            // 
            this.TemplateDetailsUserControl1.ConfigLocation = DotNetScaffolder.Mapping.MetaData.Enum.ConfigLocation.Data;
            this.TemplateDetailsUserControl1.Data = null;
            this.TemplateDetailsUserControl1.GeneratorTypeId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.TemplateDetailsUserControl1.LanguageId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.TemplateDetailsUserControl1.Location = new System.Drawing.Point(15, 19);
            this.TemplateDetailsUserControl1.Name = "TemplateDetailsUserControl1";
            this.TemplateDetailsUserControl1.Size = new System.Drawing.Size(451, 223);
            this.TemplateDetailsUserControl1.TabIndex = 0;
            this.TemplateDetailsUserControl1.TemplateEnabled = false;
            this.TemplateDetailsUserControl1.TemplateName = "";
            this.TemplateDetailsUserControl1.TemplatePath = "";
            this.TemplateDetailsUserControl1.TreeNode = null;
            this.TemplateDetailsUserControl1.Version = 1D;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ManageTemplateTreeViewUserControl1);
            this.groupBox4.Location = new System.Drawing.Point(11, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 486);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Templates";
            // 
            // ManageTemplateTreeViewUserControl1
            // 
            this.ManageTemplateTreeViewUserControl1.AfterSelect = null;
            this.ManageTemplateTreeViewUserControl1.BeforeSelect = null;
            this.ManageTemplateTreeViewUserControl1.BtnAddGroupClick = null;
            this.ManageTemplateTreeViewUserControl1.BtnAddItemClick = null;
            this.ManageTemplateTreeViewUserControl1.BtnDeleteClick = null;
            this.ManageTemplateTreeViewUserControl1.BtnDownClick = null;
            this.ManageTemplateTreeViewUserControl1.BtnUpClick = null;
            this.ManageTemplateTreeViewUserControl1.CollectionType = FormControls.Enum.TreeViewType.Package;
            this.ManageTemplateTreeViewUserControl1.DataSource = null;
            this.ManageTemplateTreeViewUserControl1.Location = new System.Drawing.Point(13, 16);
            this.ManageTemplateTreeViewUserControl1.Name = "ManageTemplateTreeViewUserControl1";
            this.ManageTemplateTreeViewUserControl1.Size = new System.Drawing.Size(364, 348);
            this.ManageTemplateTreeViewUserControl1.TabIndex = 0;
            // 
            // TemplateManagementUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "TemplateManagementUserControl";
            this.Size = new System.Drawing.Size(938, 516);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private ManageCollectionsTreeViewUserControl ManageTemplateTreeViewUserControl1;
        private TemplateDetailsUserControl TemplateDetailsUserControl1;
    }
}
