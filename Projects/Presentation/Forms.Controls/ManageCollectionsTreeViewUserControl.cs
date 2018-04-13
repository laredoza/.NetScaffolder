// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ManageCollectionsTreeViewUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Usings

    using System;
    using System.Windows.Forms;

    using DotNetScaffolder.Presentation.Forms.Controls.Enum;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The manage collections tree view user control.
    /// </summary>
    public partial class ManageCollectionsTreeViewUserControl
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ManageCollectionsTreeViewUserControl" /> class.
        /// </summary>
        public ManageCollectionsTreeViewUserControl()
        {
            InitializeComponent();
            treeView1.AfterSelect += TreeView1_AfterSelect;
            treeView1.BeforeSelect += TreeView1_BeforeSelect;
            BtnUp.Click += BtnUp_Click;
            BtnDown.Click += BtnDown_Click;
            BtnDelete.Click += BtnDelete_Click;
            BtnAddGroup.Click += BtnAddGroup_Click;
            BtnAddItem.Click += BtnAddItem_Click;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the after select.
        /// </summary>
        public TreeViewEventHandler AfterSelect { get; set; }

        /// <summary>
        ///     Gets or sets the before select.
        /// </summary>
        public TreeViewCancelEventHandler BeforeSelect { get; set; }

        /// <summary>
        ///     Gets or sets the btn add group click.
        /// </summary>
        public EventHandler BtnAddGroupClick { get; set; }

        /// <summary>
        ///     Gets or sets the btn add item click.
        /// </summary>
        public EventHandler BtnAddItemClick { get; set; }

        /// <summary>
        ///     Gets or sets the btn delete click.
        /// </summary>
        public EventHandler BtnDeleteClick { get; set; }

        /// <summary>
        ///     Gets or sets the btn down click.
        /// </summary>
        public EventHandler BtnDownClick { get; set; }

        /// <summary>
        ///     Gets or sets the btn up click.
        /// </summary>
        public EventHandler BtnUpClick { get; set; }

        /// <summary>
        ///     Gets or sets the collection type.
        /// </summary>
        public TreeViewType CollectionType { get; set; }

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public IHierarchy DataSource
        {
            get
            {
                return treeView1.Data;
            }

            set
            {
                if (treeView1.Data != value)
                {
                    treeView1.Data = value;
                    treeView1.ExpandAll();
                }
            }
        }

        #endregion

        #region Public methods and operators

        /// <summary>
        /// The move down.
        /// </summary>
        /// <param name="selectedNode">
        /// The selected node.
        /// </param>
        public void MoveDown(TreeNode selectedNode)
        {
            treeView1.MoveDown(selectedNode);
        }

        /// <summary>
        /// The move up.
        /// </summary>
        /// <param name="selectedNode">
        /// The selected node.
        /// </param>
        public void MoveUp(TreeNode selectedNode)
        {
            treeView1.MoveUp(selectedNode);
        }

        /// <summary>
        ///     The select first node.
        /// </summary>
        public void SelectFirstNode()
        {
            if (treeView1.Nodes.Count > 0)
            {
                treeView1.SelectNode(treeView1.Nodes[0]);
                OnAfterSelectChanged(new TreeViewEventArgs(treeView1.Nodes[0]), AfterSelect);
            }
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The on after select changed.
        /// </summary>
        /// <param name="e">
        /// The e.
        /// </param>
        /// <param name="eventHandler">
        /// The event handler.
        /// </param>
        protected virtual void OnAfterSelectChanged(TreeViewEventArgs e, TreeViewEventHandler eventHandler)
        {
            if (eventHandler != null)
            {
                eventHandler(this, e);
            }
        }

        /// <summary>
        /// The on before select changed.
        /// </summary>
        /// <param name="e">
        /// The e.
        /// </param>
        /// <param name="eventHandler">
        /// The event handler.
        /// </param>
        protected virtual void OnBeforeSelectChanged(TreeViewCancelEventArgs e, TreeViewCancelEventHandler eventHandler)
        {
            if (eventHandler != null)
            {
                eventHandler(this, e);
            }
        }

        /// <summary>
        /// The on button clicked.
        /// </summary>
        /// <param name="e">
        /// The e.
        /// </param>
        /// <param name="eventHandler">
        /// The event handler.
        /// </param>
        protected virtual void OnButtonClicked(EventArgs e, EventHandler eventHandler)
        {
            if (eventHandler != null)
            {
                eventHandler(this, e);
            }
        }

        /// <summary>
        /// The btn add group_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnAddGroup_Click(object sender, EventArgs e)
        {
            OnButtonClicked(e, BtnAddGroupClick);
        }

        /// <summary>
        /// The btn add item_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            OnButtonClicked(e, BtnAddItemClick);
        }

        /// <summary>
        /// The btn delete_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            OnButtonClicked(e, BtnDeleteClick);
        }

        /// <summary>
        /// The btn down_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnDown_Click(object sender, EventArgs e)
        {
            OnButtonClicked(e, BtnDownClick);
        }

        /// <summary>
        /// The btn up_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnUp_Click(object sender, EventArgs e)
        {
            OnButtonClicked(e, BtnUpClick);
        }

        /// <summary>
        /// The tree view 1_ after select.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // throw new System.NotImplementedException();
            treeView1.SelectNode(e.Node);
            BtnUp.Enabled = treeView1.UpEnabled;
            BtnDown.Enabled = treeView1.DownEnabled;
            BtnDelete.Enabled = treeView1.DeleteEnabled;
            BtnAddGroup.Enabled = treeView1.AddGroupEnabled;
            BtnAddItem.Enabled = treeView1.AddItemEnabled;

            OnAfterSelectChanged(e, AfterSelect);
        }

        /// <summary>
        /// The tree view 1_ before select.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TreeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            OnBeforeSelectChanged(e, BeforeSelect);
        }

        #endregion
    }
}