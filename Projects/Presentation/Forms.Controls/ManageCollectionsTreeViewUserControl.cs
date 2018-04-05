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
            this.InitializeComponent();
            this.treeView1.AfterSelect += this.TreeView1_AfterSelect;
            this.treeView1.BeforeSelect += this.TreeView1_BeforeSelect;
            this.BtnUp.Click += this.BtnUp_Click;
            this.BtnDown.Click += this.BtnDown_Click;
            this.BtnDelete.Click += this.BtnDelete_Click;
            this.BtnAddGroup.Click += this.BtnAddGroup_Click;
            this.BtnAddItem.Click += this.BtnAddItem_Click;
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

        #region Public methods and operators

        /// <summary>
        /// The move down.
        /// </summary>
        /// <param name="selectedNode">
        /// The selected node.
        /// </param>
        public void MoveDown(TreeNode selectedNode)
        {
            this.treeView1.MoveDown(selectedNode);
        }

        /// <summary>
        /// The move up.
        /// </summary>
        /// <param name="selectedNode">
        /// The selected node.
        /// </param>
        public void MoveUp(TreeNode selectedNode)
        {
            this.treeView1.MoveUp(selectedNode);
        }

        /// <summary>
        ///     The select first node.
        /// </summary>
        public void SelectFirstNode()
        {
            if (this.treeView1.Nodes.Count > 0)
            {
                this.treeView1.SelectNode(this.treeView1.Nodes[0]);
                this.OnAfterSelectChanged(new TreeViewEventArgs(this.treeView1.Nodes[0]), this.AfterSelect);
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
            this.OnButtonClicked(e, this.BtnAddGroupClick);
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
            this.OnButtonClicked(e, this.BtnAddItemClick);
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
            this.OnButtonClicked(e, this.BtnDeleteClick);
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
            this.OnButtonClicked(e, this.BtnDownClick);
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
            this.OnButtonClicked(e, this.BtnUpClick);
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
            this.treeView1.SelectNode(e.Node);
            this.BtnUp.Enabled = this.treeView1.UpEnabled;
            this.BtnDown.Enabled = this.treeView1.DownEnabled;
            this.BtnDelete.Enabled = this.treeView1.DeleteEnabled;
            this.BtnAddGroup.Enabled = this.treeView1.AddGroupEnabled;
            this.BtnAddItem.Enabled = this.treeView1.AddItemEnabled;

            this.OnAfterSelectChanged(e, this.AfterSelect);
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
            this.OnBeforeSelectChanged(e, this.BeforeSelect);
        }

        #endregion
    }
}