// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ManageCollectionsTreeViewUserControl.cs" company="">
//   
// </copyright>
// <summary>
//   The manage collections tree view user control.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Using

    using System.Windows.Forms;
    using System.Windows.Forms.VisualStyles;

    using DotNetScaffolder.Mapping.MetaData.Project.Packages;
    using DotNetScaffolder.Presentation.Forms.Controls.Enum;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    /// The manage collections tree view user control.
    /// </summary>
    public partial class ManageCollectionsTreeViewUserControl
    {
        #region Constructors and Destructors

        public ManageCollectionsTreeViewUserControl()
        {
            this.InitializeComponent();
            this.treeView1.AfterSelect += TreeView1_AfterSelect;
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //throw new System.NotImplementedException();
            this.treeView1.SelectNode(e.Node);
            this.BtnUp.Enabled = this.treeView1.UpEnabled;
            this.BtnDown.Enabled = this.treeView1.DownEnabled;
            this.BtnDelete.Enabled = this.treeView1.DeleteEnabled;
            this.BtnAddGroup.Enabled = this.treeView1.AddGroupEnabled;
            this.BtnAddItem.Enabled = this.treeView1.AddItemEnabled;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the collection type.
        /// </summary>
        public TreeViewType CollectionType { get; set; }

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public IHierarchy DataSource
        {
            get
            {
                return this.treeView1.Data;
            }
            set
            {
                if (this.treeView1.Data != value)
                {
                    this.treeView1.Data = value;
                    this.treeView1.ExpandAll();
                }
            }
        }

        #endregion
    }
}