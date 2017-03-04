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

    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

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
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public IHierarchy<Template> DataSource
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