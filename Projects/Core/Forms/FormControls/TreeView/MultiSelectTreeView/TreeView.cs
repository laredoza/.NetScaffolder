// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeView.cs" company="">
//  Copyright 2004, Coder's Lab
//  All rights reserved. The software and associated documentation 
//  supplied hereunder are the proprietary information of Coder's Lab
//  and are supplied subject to licence terms.
//  
//
//  You can use this control freely in your projects, but let me know if you
//  are using it so I can add you to a list of references. 
//
//  Email: ludwig.stuyck@coders-lab.be
//  Home page: http://www.coders-lab.be
// </copyright>
// <summary>
//   Selection mode for the treeview.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FormControls.TreeView.MultiSelectTreeView
{
    #region Using

    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    #endregion

    #region TreeViewSelectionMode enumeration

    #endregion

    #region Delegates

    /// <summary>
    ///     Delegate used for tree node events.
    /// </summary>
    public delegate void TreeNodeEventHandler(TreeNode tn);

    #endregion

    /// <summary>
    ///     The TreeView control is a regular treeview with multi-selection capability.
    /// </summary>
    [ToolboxItem(true)]
    public class TreeView : System.Windows.Forms.TreeView
    {
        #region Fields

        /// <summary>
        ///     Used to make sure that SelectedNode can only be used from within this class.
        /// </summary>
        private bool blnInternalCall = false;

        /// <summary>
        ///     Keeps track whether a node click has been handled by the mouse down event. This is almost always the
        ///     case, except when a selected node has been clicked again. Then, it will not be handled in the mouse
        ///     down event because we might want to drag the node and if that's the case, node should not go in edit
        ///     mode.
        /// </summary>
        private bool blnNodeProcessedOnMouseDown = false;

        /// <summary>
        ///     Track whether the total SelectedNodes changed across multiple operations
        ///     for SelectionsChanged event
        /// </summary>
        private bool blnSelectionChanged = false;

        /// <summary>
        ///     Remembers whether mouse click on a node was single or double click.
        /// </summary>
        private bool blnWasDoubleClick = false;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private Container components = null;

        /// <summary>
        ///     Hashtable that contains all selected nodes.
        /// </summary>
        private readonly Hashtable htblSelectedNodes = new Hashtable();

        /// <summary>
        ///     Hashtable to preserve Node's original colors (colors can be set on the TreeView, or individual nodes)
        ///     (GKM)
        /// </summary>
        private readonly Hashtable htblSelectedNodesOrigColors = new Hashtable();

        /// <summary>
        ///     Keeps track of the number of mouse clicks.
        /// </summary>
        private int intMouseClicks = 0;

        /// <summary>
        ///     Backcolor for selected nodes.
        /// </summary>
        private Color selectionBackColor = SystemColors.Highlight;

        /// <summary>
        ///     Selection mode.
        /// </summary>
        private TreeViewSelectionMode selectionMode = TreeViewSelectionMode.SingleSelect;

        /// <summary>
        ///     Keeps track of the first selected node when selection has begun with the keyboard.
        /// </summary>
        private TreeNode tnKeysStartNode = null;

        /// <summary>
        ///     Keeps track of most recent selected node.
        /// </summary>
        private TreeNode tnMostRecentSelectedNode = null;

        /// <summary>
        ///     Keeps track of node that has to be pu in edit mode.
        /// </summary>
        private TreeNode tnNodeToStartEditOn = null;

        /// <summary>
        ///     Keeps track of the selection mirror point; this is the last selected node without SHIFT key pressed.
        ///     It is used as the mirror node during SHIFT selection.
        /// </summary>
        private TreeNode tnSelectionMirrorPoint = null;

        /// <summary>
        ///     Holds node that needs to be flashed.
        /// </summary>
        private TreeNode tnToFlash = null;

        #endregion

        #region Public Events

        /// <summary>
        /// The after deselect.
        /// </summary>
        public event TreeViewEventHandler AfterDeselect;

        /// <summary>
        /// The before deselect.
        /// </summary>
        public event TreeViewEventHandler BeforeDeselect;

        /// <summary>
        /// The selections changed.
        /// </summary>
        public event EventHandler SelectionsChanged;

        #endregion

        #region Properties

        /// <summary>
        ///     This property is for internal use only. Use SelectedNodes instead.
        /// </summary>
        public new TreeNode SelectedNode
        {
            get
            {
                if (!this.blnInternalCall)
                {
                    throw new NotSupportedException("Use SelectedNodes instead of SelectedNode.");
                }
                else
                {
                    return base.SelectedNode;
                }
            }

            set
            {
                if (!this.blnInternalCall)
                {
                    throw new NotSupportedException("Use SelectedNodes instead of SelectedNode.");
                }
                else
                {
                    base.SelectedNode = value;
                }
            }
        }

        /// <summary>
        ///     Gets selected nodes.
        /// </summary>
        public NodesCollection SelectedNodes
        {
            get
            {
                // Create a SelectedNodesCollection to return, and add event handlers to catch actions on it
                NodesCollection selectedNodesCollection = new NodesCollection();
                foreach (TreeNode tn in this.htblSelectedNodes.Values)
                {
                    selectedNodesCollection.Add(tn);
                }

                selectedNodesCollection.TreeNodeAdded += new TreeNodeEventHandler(this.SelectedNodes_TreeNodeAdded);
                selectedNodesCollection.TreeNodeInserted += new TreeNodeEventHandler(
                    this.SelectedNodes_TreeNodeInserted);
                selectedNodesCollection.TreeNodeRemoved += new TreeNodeEventHandler(this.SelectedNodes_TreeNodeRemoved);
                selectedNodesCollection.SelectedNodesCleared += new EventHandler(
                    this.SelectedNodes_SelectedNodesCleared);

                return selectedNodesCollection;
            }
        }

        /// <summary>
        ///     Gets/sets backcolor for selected nodes.
        /// </summary>
        public Color SelectionBackColor
        {
            get
            {
                return this.selectionBackColor;
            }

            set
            {
                this.selectionBackColor = value;
            }
        }

        /// <summary>
        ///     Gets/sets selection mode.
        /// </summary>
        public TreeViewSelectionMode SelectionMode
        {
            get
            {
                return this.selectionMode;
            }

            set
            {
                this.selectionMode = value;
            }
        }

        #endregion

        #region Public methods and operators

        /// <summary>
        /// Gets level of specified node.
        /// </summary>
        /// <param name="node">
        /// Node.
        /// </param>
        /// <returns>
        /// Level of node.
        /// </returns>
        public int GetNodeLevel(TreeNode node)
        {
            int level = 0;
            while ((node = node.Parent) != null) level++;
            return level;
        }

        /// <summary>
        /// Gets root parent of specified node.
        /// </summary>
        /// <param name="child">
        /// Node.
        /// </param>
        /// <returns>
        /// Root parent of specified node.
        /// </returns>
        public TreeNode GetRootParent(TreeNode child)
        {
            TreeNode tnParent = child;

            while (tnParent.Parent != null)
            {
                tnParent = tnParent.Parent;
            }

            return tnParent;
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// The disposing.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.components != null)
                {
                    this.components.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Occurs after a node is collapsed.
        /// </summary>
        /// <param name="e">
        /// </param>
        protected override void OnAfterCollapse(TreeViewEventArgs e)
        {
            this.blnSelectionChanged = false;

            // All child nodes should be deselected
            bool blnChildSelected = false;
            foreach (TreeNode tn in e.Node.Nodes)
            {
                if (this.IsNodeSelected(tn))
                {
                    blnChildSelected = true;
                }

                this.UnselectNodesRecursively(tn, TreeViewAction.Collapse);
            }

            if (blnChildSelected)
            {
                this.SelectNode(e.Node, true, TreeViewAction.Collapse);
            }

            this.OnSelectionsChanged();

            base.OnAfterCollapse(e);
        }

        /// <summary>
        /// The on after deselect.
        /// </summary>
        /// <param name="tn">
        /// The tn.
        /// </param>
        protected void OnAfterDeselect(TreeNode tn)
        {
            if (this.AfterDeselect != null)
            {
                this.AfterDeselect(this, new TreeViewEventArgs(tn));
            }
        }

        /// <summary>
        /// The on before deselect.
        /// </summary>
        /// <param name="tn">
        /// The tn.
        /// </param>
        protected void OnBeforeDeselect(TreeNode tn)
        {
            if (this.BeforeDeselect != null)
            {
                this.BeforeDeselect(this, new TreeViewEventArgs(tn));
            }
        }

        /// <summary>
        /// Occurs before node goes into edit mode.
        /// </summary>
        /// <param name="e">
        /// </param>
        protected override void OnBeforeLabelEdit(NodeLabelEditEventArgs e)
        {
            this.blnSelectionChanged = false; // prepare for OnSelectionsChanged

            // Make sure that it's the only selected node
            this.SelectNode(e.Node, true, TreeViewAction.ByMouse);
            this.UnselectAllNodesExceptNode(e.Node, TreeViewAction.ByMouse);

            this.OnSelectionsChanged();

            base.OnBeforeLabelEdit(e);
        }

        /// <summary>
        /// occurs when a node is about to be selected.
        /// </summary>
        /// <param name="e">
        /// TreeViewCancelEventArgs.
        /// </param>
        protected override void OnBeforeSelect(TreeViewCancelEventArgs e)
        {
            // We don't want the base TreeView to handle the selection, because it can only handle single selection. 
            // Instead, we'll handle the selection ourselves by keeping track of the selected nodes and drawing the 
            // selection ourselves.
            e.Cancel = true;
        }

        /// <summary>
        /// Occurs when an item is being dragged.
        /// </summary>
        /// <param name="e">
        /// </param>
        protected override void OnItemDrag(ItemDragEventArgs e)
        {
            e = new ItemDragEventArgs(MouseButtons.Left, this.SelectedNodes);
            base.OnItemDrag(e);
        }

        /// <summary>
        /// occurs when a key is down.
        /// </summary>
        /// <param name="e">
        /// </param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            Keys kMod = Keys.None;
            switch (e.Modifiers)
            {
                case Keys.Shift:
                case Keys.Control:
                case Keys.Control | Keys.Shift:
                    kMod = Keys.Shift;
                    if (this.tnKeysStartNode == null) this.tnKeysStartNode = this.tnMostRecentSelectedNode;
                    break;
                default:
                    this.tnKeysStartNode = null;
                    break;
            }

            int intNumber = 0;

            TreeNode tnNewlySelectedNodeWithKeys = null;
            switch (e.KeyCode)
            {
                case Keys.Down:
                    tnNewlySelectedNodeWithKeys = this.tnMostRecentSelectedNode.NextVisibleNode;
                    break;

                case Keys.Up:
                    tnNewlySelectedNodeWithKeys = this.tnMostRecentSelectedNode.PrevVisibleNode;
                    break;

                case Keys.Left:
                    if (this.tnMostRecentSelectedNode.IsExpanded) this.tnMostRecentSelectedNode.Collapse();
                    else tnNewlySelectedNodeWithKeys = this.tnMostRecentSelectedNode.Parent;
                    break;

                case Keys.Right:
                    if (!this.tnMostRecentSelectedNode.IsExpanded) this.tnMostRecentSelectedNode.Expand();
                    else if (this.tnMostRecentSelectedNode.Nodes != null) tnNewlySelectedNodeWithKeys = this.tnMostRecentSelectedNode.Nodes[0];
                    break;

                case Keys.Home:
                    tnNewlySelectedNodeWithKeys = this.Nodes[0];
                    break;

                case Keys.End:
                    tnNewlySelectedNodeWithKeys = this.GetLastVisibleNode();
                    break;

                case Keys.PageDown:

                    intNumber = this.GetNumberOfVisibleNodes();
                    tnNewlySelectedNodeWithKeys = this.GetNextTreeNode(this.tnMostRecentSelectedNode, true, intNumber);
                    break;

                case Keys.PageUp:

                    intNumber = this.GetNumberOfVisibleNodes();
                    tnNewlySelectedNodeWithKeys = this.GetNextTreeNode(this.tnMostRecentSelectedNode, false, intNumber);
                    break;

                default:
                    base.OnKeyDown(e); // GKM
                    return;
            }

            if (tnNewlySelectedNodeWithKeys != null)
            {
                this.SetFocusToNode(this.tnMostRecentSelectedNode, false);
                this.ProcessNodeRange(
                    this.tnKeysStartNode,
                    tnNewlySelectedNodeWithKeys,
                    new MouseEventArgs(MouseButtons.Left, 1, Cursor.Position.X, Cursor.Position.Y, 0),
                    kMod,
                    TreeViewAction.ByKeyboard,
                    false);
                this.tnMostRecentSelectedNode = tnNewlySelectedNodeWithKeys;
                this.SetFocusToNode(this.tnMostRecentSelectedNode, true);
            }

            // Ensure visibility
            if (this.tnMostRecentSelectedNode != null)
            {
                TreeNode tnToMakeVisible = null;
                switch (e.KeyCode)
                {
                    case Keys.Down:
                    case Keys.Right:
                        tnToMakeVisible = this.GetNextTreeNode(this.tnMostRecentSelectedNode, true, 5);
                        break;

                    case Keys.Up:
                    case Keys.Left:
                        tnToMakeVisible = this.GetNextTreeNode(this.tnMostRecentSelectedNode, false, 5);
                        break;

                    case Keys.Home:
                    case Keys.End:
                        tnToMakeVisible = this.tnMostRecentSelectedNode;
                        break;

                    case Keys.PageDown:
                        tnToMakeVisible = this.GetNextTreeNode(this.tnMostRecentSelectedNode, true, intNumber - 2);
                        break;

                    case Keys.PageUp:
                        tnToMakeVisible = this.GetNextTreeNode(this.tnMostRecentSelectedNode, false, intNumber - 2);
                        break;
                }

                if (tnToMakeVisible != null) tnToMakeVisible.EnsureVisible();
            }

            base.OnKeyDown(e);
        }

        /// <summary>
        /// Occurs when mouse is down.
        /// </summary>
        /// <param name="e">
        /// </param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.tnKeysStartNode = null;

            // Store number of mouse clicks in OnMouseDown event, because here we also get e.Clicks = 2 when an item was doubleclicked
            // in OnMouseUp we seem to get always e.Clicks = 1, also when item is doubleclicked
            this.intMouseClicks = e.Clicks;

            TreeNode tn = this.GetNodeAt(e.X, e.Y);

            if (tn == null) return;

            // Preserve colors here, because if you do it later then it will already have selected colors 
            // Don't know why...!
            this.PreserveNodeColors(tn);

            // If +/- was clicked, we should not process the node.
            if (!this.IsPlusMinusClicked(tn, e))
            {
                // If mouse down on a node that is already selected, then we should process this node in the mouse up event, because we
                // might want to drag it and it should not be put in edit mode.
                // Also, only process node if click was in node's bounds.
                if ((tn != null) && this.IsClickOnNode(tn, e) && !this.IsNodeSelected(tn))
                {
                    // Flash node. In case the node selection is cancelled by the user, this gives the effect that it
                    // was selected and unselected again.
                    this.tnToFlash = tn;
                    Thread t = new Thread(new ThreadStart(this.FlashNode));
                    t.Start();

                    this.blnNodeProcessedOnMouseDown = true;

                    Debug.WriteLine("*** " + tn.BackColor);
                    this.ProcessNodeRange(
                        this.tnMostRecentSelectedNode,
                        tn,
                        e,
                        ModifierKeys,
                        TreeViewAction.ByMouse,
                        true);
                }
            }

            base.OnMouseDown(e);
        }

        /// <summary>
        /// Occurs when mouse button is up after a click.
        /// </summary>
        /// <param name="e">
        /// </param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
#if DEBUG
            try
            {
#endif
                if (!this.blnNodeProcessedOnMouseDown)
                {
                    TreeNode tn = this.GetNodeAt(e.X, e.Y);

                    // Mouse click has not been handled by the mouse down event, so do it here. This is the case when
                    // a selected node was clicked again; in that case we handle that click here because in case the
                    // user is dragging the node, we should not put it in edit mode.					
                    if (this.IsClickOnNode(tn, e))
                    {
                        this.ProcessNodeRange(
                            this.tnMostRecentSelectedNode,
                            tn,
                            e,
                            ModifierKeys,
                            TreeViewAction.ByMouse,
                            true);
                    }
                }

                this.blnNodeProcessedOnMouseDown = false;

                base.OnMouseUp(e);
#if DEBUG
            }
            catch (Exception ex)
            {
                // GKM - Untrapped exceptions were killing me for debugging purposes.
                // It probably shouldn't be here permanently, but it was causing real trouble for me.
                MessageBox.Show(this, ex.ToString());
            }

#endif
        }

        /// <summary>
        /// The on selections changed.
        /// </summary>
        protected void OnSelectionsChanged()
        {
            if (this.blnSelectionChanged)
                if (this.SelectionsChanged != null)
                {
                    this.SelectionsChanged(this, new EventArgs());
                }
        }

        /// <summary>
        ///     Flashes node.
        /// </summary>
        private void FlashNode()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { this.FlashNode(); }));
                return;
            }

            TreeNode tn = this.tnToFlash;

            // Only flash node is it's not yet selected
            if (!this.IsNodeSelected(tn))
            {
                tn.BackColor = this.SelectionBackColor;
                tn.ForeColor = this.BackColor;
                this.Invalidate();
                this.Refresh();
                Application.DoEvents();
                Thread.Sleep(200);
            }

            // If node is not selected yet, restore default colors to end flashing
            if (!this.IsNodeSelected(tn))
            {
                tn.BackColor = this.BackColor;
                tn.ForeColor = this.ForeColor;
            }
        }

        /// <summary>
        ///     Gets last visible node.
        /// </summary>
        /// <returns>Last visible node.</returns>
        private TreeNode GetLastVisibleNode()
        {
            TreeNode tnTemp = this.Nodes[0];

            while (tnTemp.NextVisibleNode != null)
            {
                tnTemp = tnTemp.NextVisibleNode;
            }

            return tnTemp;
        }

        /// <summary>
        /// Gets next tree node(s), starting from the specified node and direction.
        /// </summary>
        /// <param name="start">
        /// Node to start from.
        /// </param>
        /// <param name="down">
        /// True to go down, false to go up.
        /// </param>
        /// <param name="intNumber">
        /// Number of nodes to go down or up.
        /// </param>
        /// <returns>
        /// Next node.
        /// </returns>
        private TreeNode GetNextTreeNode(TreeNode start, bool down, int intNumber)
        {
            int intCounter = 0;
            TreeNode tnTemp = start;
            while (intCounter < intNumber)
            {
                if (down)
                {
                    if (tnTemp.NextVisibleNode != null) tnTemp = tnTemp.NextVisibleNode;
                    else break;
                }
                else
                {
                    if (tnTemp.PrevVisibleNode != null) tnTemp = tnTemp.PrevVisibleNode;
                    else break;
                }

                intCounter++;
            }

            return tnTemp;
        }

        /// <summary>
        ///     Gets number of visible nodes.
        /// </summary>
        /// <returns>Number of visible nodes.</returns>
        private int GetNumberOfVisibleNodes()
        {
            int intCounter = 0;

            TreeNode tnTemp = this.Nodes[0];

            while (tnTemp != null)
            {
                if (tnTemp.IsVisible)
                {
                    intCounter++;
                }

                tnTemp = tnTemp.NextVisibleNode;
            }

            return intCounter;
        }

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new Container();
        }

        /// <summary>
        /// Determines whether the specified node is a child (indirect or direct) of the specified parent.
        /// </summary>
        /// <param name="child">
        /// Node to check.
        /// </param>
        /// <param name="parent">
        /// Parent node.
        /// </param>
        /// <returns>
        /// True if specified node is a direct or indirect child of parent node, false if not.
        /// </returns>
        private bool IsChildOf(TreeNode child, TreeNode parent)
        {
            bool blnChild = false;

            TreeNode tnTemp = child;
            while (tnTemp != null)
            {
                if (tnTemp == parent)
                {
                    blnChild = true;
                    break;
                }
                else
                {
                    tnTemp = tnTemp.Parent;
                }
            }

            return blnChild;
        }

        /// <summary>
        /// Determines whether a mouse click was inside the node bounds or outside the node bounds..
        /// </summary>
        /// <param name="tn">
        /// TreeNode to check.
        /// </param>
        /// <param name="e">
        /// MouseEventArgs.
        /// </param>
        /// <returns>
        /// True is mouse was clicked inside the node bounds, false if it was clicked ouside the node bounds.
        /// </returns>
        private bool IsClickOnNode(TreeNode tn, MouseEventArgs e)
        {
            if (tn == null) return false;

            // GKM
            // Determine the rightmost position we'll process clicks (so that the click has to be on the node's bounds, 
            // like the .NET treeview
            int rightMostX = tn.Bounds.X + tn.Bounds.Width;
            return tn != null && e.X < rightMostX; // GKM
        }

        /// <summary>
        /// Determines whether the specified node is selected or not.
        /// </summary>
        /// <param name="tn">
        /// Node to check.
        /// </param>
        /// <returns>
        /// True if specified node is selected, false if not.
        /// </returns>
        private bool IsNodeSelected(TreeNode tn)
        {
            if (tn != null) return this.htblSelectedNodes.ContainsKey(tn.GetHashCode());
            return false;
        }

        /// <summary>
        /// The is plus minus clicked.
        /// </summary>
        /// <param name="tn">
        /// The tn.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private bool IsPlusMinusClicked(TreeNode tn, MouseEventArgs e)
        {
            int intNodeLevel = this.GetNodeLevel(tn);
            bool blnPlusMinusClicked = false;
            if (e.X < 20 + intNodeLevel * 20) blnPlusMinusClicked = true;

            return blnPlusMinusClicked;
        }

        /// <summary>
        /// The preserve node colors.
        /// </summary>
        /// <param name="tn">
        /// The tn.
        /// </param>
        private void PreserveNodeColors(TreeNode tn)
        {
            if (tn == null) return;

            Debug.WriteLine(tn.BackColor.ToString());

            if (this.htblSelectedNodesOrigColors.ContainsKey(tn.GetHashCode()))
            {
                // 				Color[] color = (Color[])htblSelectedNodesOrigColors[tn.GetHashCode()];
                // 				color[0]=tn.BackColor;
                // 				color[1]=tn.ForeColor;
            }
            else
            {
                this.htblSelectedNodesOrigColors.Add(tn.GetHashCode(), new[] { tn.BackColor, tn.ForeColor });
            }
        }

        /// <summary>
        /// Processes a node range.
        /// </summary>
        /// <param name="startNode">
        /// Start node of range.
        /// </param>
        /// <param name="endNode">
        /// End node of range.
        /// </param>
        /// <param name="e">
        /// MouseEventArgs.
        /// </param>
        /// <param name="keys">
        /// Keys.
        /// </param>
        /// <param name="tva">
        /// TreeViewAction.
        /// </param>
        /// <param name="allowStartEdit">
        /// True if node can go to edit mode, false if not.
        /// </param>
        private void ProcessNodeRange(
            TreeNode startNode,
            TreeNode endNode,
            MouseEventArgs e,
            Keys keys,
            TreeViewAction tva,
            bool allowStartEdit)
        {
            this.blnSelectionChanged = false; // prepare for OnSelectionsChanged

            if (e.Button == MouseButtons.Left)
            {
                this.blnWasDoubleClick = this.intMouseClicks == 2;

                TreeNode tnTemp = null;
                int intNodeLevelStart;

                if (((keys & Keys.Control) == 0) && ((keys & Keys.Shift) == 0))
                {
                    // CTRL and SHIFT not held down							
                    this.tnSelectionMirrorPoint = endNode;
                    int intNumberOfSelectedNodes = this.SelectedNodes.Count;

                    // If it was a double click, select node and suspend further processing					
                    if (this.blnWasDoubleClick)
                    {
                        base.OnMouseDown(e);
                        return;
                    }

                    if (!this.IsPlusMinusClicked(endNode, e))
                    {
                        bool blnNodeWasSelected = false;
                        if (this.IsNodeSelected(endNode)) blnNodeWasSelected = true;

                        this.UnselectAllNodesExceptNode(endNode, tva);
                        this.SelectNode(endNode, true, tva);

                        if (blnNodeWasSelected && this.LabelEdit && allowStartEdit && !this.blnWasDoubleClick
                            && (intNumberOfSelectedNodes <= 1))
                        {
                            // Node should be put in edit mode					
                            this.tnNodeToStartEditOn = endNode;
                            Thread t = new Thread(new ThreadStart(this.StartEdit));
                            t.Start();
                        }
                    }
                }
                else if (((keys & Keys.Control) != 0) && ((keys & Keys.Shift) == 0))
                {
                    // CTRL held down
                    this.tnSelectionMirrorPoint = null;

                    if (!this.IsNodeSelected(endNode))
                    {
                        switch (this.selectionMode)
                        {
                            case TreeViewSelectionMode.SingleSelect:
                                this.UnselectAllNodesExceptNode(endNode, tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameRootBranch:
                                TreeNode tnAbsoluteParent2 = this.GetRootParent(endNode);
                                this.UnselectAllNodesNotBelongingToParent(tnAbsoluteParent2, tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameLevel:
                                this.UnselectAllNodesNotBelongingToLevel(this.GetNodeLevel(endNode), tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameLevelAndRootBranch:
                                TreeNode tnAbsoluteParent = this.GetRootParent(endNode);
                                this.UnselectAllNodesNotBelongingToParent(tnAbsoluteParent, tva);
                                this.UnselectAllNodesNotBelongingToLevel(this.GetNodeLevel(endNode), tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameParent:
                                TreeNode tnParent = endNode.Parent;
                                this.UnselectAllNodesNotBelongingDirectlyToParent(tnParent, tva);
                                break;
                        }

                        this.SelectNode(endNode, true, tva);
                    }
                    else
                    {
                        this.SelectNode(endNode, false, tva);
                    }
                }
                else if (((keys & Keys.Control) == 0) && ((keys & Keys.Shift) != 0))
                {
                    // SHIFT pressed  

                    // if startNode is null, we can't select a range, must act as if selection mode is singleSelect
                    if (startNode == null)
                    {
                        this.UnselectAllNodesExceptNode(endNode, tva);
                        this.SelectNode(endNode, true, tva);
                    }
                    else
                    {
                        if (this.tnSelectionMirrorPoint == null)
                        {
                            this.tnSelectionMirrorPoint = startNode;
                        }

                        switch (this.selectionMode)
                        {
                            case TreeViewSelectionMode.SingleSelect:
                                this.UnselectAllNodesExceptNode(endNode, tva);
                                this.SelectNode(endNode, true, tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameRootBranch:
                                TreeNode tnAbsoluteParentStartNode = this.GetRootParent(startNode);
                                tnTemp = startNode;

                                // Check each visible node from startNode to endNode and select it if needed
                                while ((tnTemp != null) && (tnTemp != endNode))
                                {
                                    if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                    else tnTemp = tnTemp.NextVisibleNode;
                                    if (tnTemp != null)
                                    {
                                        TreeNode tnAbsoluteParent = this.GetRootParent(tnTemp);
                                        if (tnAbsoluteParent == tnAbsoluteParentStartNode)
                                        {
                                            this.SelectNode(tnTemp, true, tva);
                                        }
                                    }
                                }

                                this.UnselectAllNodesNotBelongingToParent(tnAbsoluteParentStartNode, tva);
                                this.UnselectNodesOutsideRange(this.tnSelectionMirrorPoint, endNode, tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameLevel:
                                intNodeLevelStart = this.GetNodeLevel(startNode);
                                tnTemp = startNode;

                                // Check each visible node from startNode to endNode and select it if needed
                                while ((tnTemp != null) && (tnTemp != endNode))
                                {
                                    if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                    else tnTemp = tnTemp.NextVisibleNode;
                                    if (tnTemp != null)
                                    {
                                        int intNodeLevel = this.GetNodeLevel(tnTemp);
                                        if (intNodeLevel == intNodeLevelStart)
                                        {
                                            this.SelectNode(tnTemp, true, tva);
                                        }
                                    }
                                }

                                this.UnselectAllNodesNotBelongingToLevel(intNodeLevelStart, tva);
                                this.UnselectNodesOutsideRange(this.tnSelectionMirrorPoint, endNode, tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameLevelAndRootBranch:
                                TreeNode tnAbsoluteParentStart = this.GetRootParent(startNode);
                                intNodeLevelStart = this.GetNodeLevel(startNode);
                                tnTemp = startNode;

                                // Check each visible node from startNode to endNode and select it if needed
                                while ((tnTemp != null) && (tnTemp != endNode))
                                {
                                    if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                    else tnTemp = tnTemp.NextVisibleNode;
                                    if (tnTemp != null)
                                    {
                                        int intNodeLevel = this.GetNodeLevel(tnTemp);
                                        TreeNode tnAbsoluteParent = this.GetRootParent(tnTemp);
                                        if ((intNodeLevel == intNodeLevelStart)
                                            && (tnAbsoluteParent == tnAbsoluteParentStart))
                                        {
                                            this.SelectNode(tnTemp, true, tva);
                                        }
                                    }
                                }

                                this.UnselectAllNodesNotBelongingToParent(tnAbsoluteParentStart, tva);
                                this.UnselectAllNodesNotBelongingToLevel(intNodeLevelStart, tva);
                                this.UnselectNodesOutsideRange(this.tnSelectionMirrorPoint, endNode, tva);
                                break;

                            case TreeViewSelectionMode.MultiSelect:
                                this.SelectNodesInsideRange(this.tnSelectionMirrorPoint, endNode, tva);
                                this.UnselectNodesOutsideRange(this.tnSelectionMirrorPoint, endNode, tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameParent:
                                TreeNode tnParentStartNode = startNode.Parent;
                                tnTemp = startNode;

                                // Check each visible node from startNode to endNode and select it if needed
                                while ((tnTemp != null) && (tnTemp != endNode))
                                {
                                    if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                    else tnTemp = tnTemp.NextVisibleNode;
                                    if (tnTemp != null)
                                    {
                                        TreeNode tnParent = tnTemp.Parent;
                                        if (tnParent == tnParentStartNode)
                                        {
                                            this.SelectNode(tnTemp, true, tva);
                                        }
                                    }
                                }

                                this.UnselectAllNodesNotBelongingDirectlyToParent(tnParentStartNode, tva);
                                this.UnselectNodesOutsideRange(this.tnSelectionMirrorPoint, endNode, tva);

                                break;
                        }
                    }
                }
                else if (((keys & Keys.Control) != 0) && ((keys & Keys.Shift) != 0))
                {
                    // SHIFT AND CTRL pressed
                    switch (this.selectionMode)
                    {
                        case TreeViewSelectionMode.SingleSelect:
                            this.UnselectAllNodesExceptNode(endNode, tva);
                            this.SelectNode(endNode, true, tva);
                            break;

                        case TreeViewSelectionMode.MultiSelectSameRootBranch:
                            TreeNode tnAbsoluteParentStartNode = this.GetRootParent(startNode);
                            tnTemp = startNode;

                            // Check each visible node from startNode to endNode and select it if needed
                            while ((tnTemp != null) && (tnTemp != endNode))
                            {
                                if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                else tnTemp = tnTemp.NextVisibleNode;
                                if (tnTemp != null)
                                {
                                    TreeNode tnAbsoluteParent = this.GetRootParent(tnTemp);
                                    if (tnAbsoluteParent == tnAbsoluteParentStartNode)
                                    {
                                        this.SelectNode(tnTemp, true, tva);
                                    }
                                }
                            }

                            this.UnselectAllNodesNotBelongingToParent(tnAbsoluteParentStartNode, tva);
                            break;

                        case TreeViewSelectionMode.MultiSelectSameLevel:
                            intNodeLevelStart = this.GetNodeLevel(startNode);
                            tnTemp = startNode;

                            // Check each visible node from startNode to endNode and select it if needed
                            while ((tnTemp != null) && (tnTemp != endNode))
                            {
                                if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                else tnTemp = tnTemp.NextVisibleNode;
                                if (tnTemp != null)
                                {
                                    int intNodeLevel = this.GetNodeLevel(tnTemp);
                                    if (intNodeLevel == intNodeLevelStart)
                                    {
                                        this.SelectNode(tnTemp, true, tva);
                                    }
                                }
                            }

                            this.UnselectAllNodesNotBelongingToLevel(intNodeLevelStart, tva);
                            break;

                        case TreeViewSelectionMode.MultiSelectSameLevelAndRootBranch:
                            TreeNode tnAbsoluteParentStart = this.GetRootParent(startNode);
                            intNodeLevelStart = this.GetNodeLevel(startNode);
                            tnTemp = startNode;

                            // Check each visible node from startNode to endNode and select it if needed
                            while ((tnTemp != null) && (tnTemp != endNode))
                            {
                                if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                else tnTemp = tnTemp.NextVisibleNode;
                                if (tnTemp != null)
                                {
                                    int intNodeLevel = this.GetNodeLevel(tnTemp);
                                    TreeNode tnAbsoluteParent = this.GetRootParent(tnTemp);
                                    if ((intNodeLevel == intNodeLevelStart)
                                        && (tnAbsoluteParent == tnAbsoluteParentStart))
                                    {
                                        this.SelectNode(tnTemp, true, tva);
                                    }
                                }
                            }

                            this.UnselectAllNodesNotBelongingToParent(tnAbsoluteParentStart, tva);
                            this.UnselectAllNodesNotBelongingToLevel(intNodeLevelStart, tva);
                            break;

                        case TreeViewSelectionMode.MultiSelect:
                            tnTemp = startNode;

                            // Check each visible node from startNode to endNode and select it if needed
                            while ((tnTemp != null) && (tnTemp != endNode))
                            {
                                if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                else tnTemp = tnTemp.NextVisibleNode;
                                if (tnTemp != null)
                                {
                                    this.SelectNode(tnTemp, true, tva);
                                }
                            }

                            break;

                        case TreeViewSelectionMode.MultiSelectSameParent:
                            TreeNode tnParentStartNode = startNode.Parent;
                            tnTemp = startNode;

                            // Check each visible node from startNode to endNode and select it if needed
                            while ((tnTemp != null) && (tnTemp != endNode))
                            {
                                if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                else tnTemp = tnTemp.NextVisibleNode;
                                if (tnTemp != null)
                                {
                                    TreeNode tnParent = tnTemp.Parent;
                                    if (tnParent == tnParentStartNode)
                                    {
                                        this.SelectNode(tnTemp, true, tva);
                                    }
                                }
                            }

                            this.UnselectAllNodesNotBelongingDirectlyToParent(tnParentStartNode, tva);
                            break;
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                // if right mouse button clicked, clear selection and select right-clicked node
                if (!this.IsNodeSelected(endNode))
                {
                    this.UnselectAllNodes(tva);
                    this.SelectNode(endNode, true, tva);
                }
            }

            this.OnSelectionsChanged();
        }

        /// <summary>
        /// Occurs when the SelectedNodes collection was cleared.
        /// </summary>
        /// <param name="sender">
        /// </param>
        /// <param name="e">
        /// </param>
        private void SelectedNodes_SelectedNodesCleared(object sender, EventArgs e)
        {
            this.blnSelectionChanged = false;

            this.UnselectAllNodes(TreeViewAction.Unknown);

            this.OnSelectionsChanged();
        }

        /// <summary>
        /// Occurs when a tree node is added to the SelectedNodes collection.
        /// </summary>
        /// <param name="tn">
        /// Tree node that was added.
        /// </param>
        private void SelectedNodes_TreeNodeAdded(TreeNode tn)
        {
            this.blnSelectionChanged = false;

            this.SelectNode(tn, true, TreeViewAction.Unknown);

            // ProcessNodeRange(null, tn, new MouseEventArgs(MouseButtons.Left, 1, Cursor.Position.X,  Cursor.Position.Y, 0), Keys.None, TreeViewAction.ByKeyboard, false); 
            this.OnSelectionsChanged();
        }

        /// <summary>
        /// Occurs when a tree node is inserted to the SelectedNodes collection.
        /// </summary>
        /// <param name="tn">
        /// tree node that was inserted.
        /// </param>
        private void SelectedNodes_TreeNodeInserted(TreeNode tn)
        {
            this.blnSelectionChanged = false;

            this.SelectNode(tn, true, TreeViewAction.Unknown);

            this.OnSelectionsChanged();
        }

        /// <summary>
        /// Occurs when a tree node is removed from the SelectedNodes collection.
        /// </summary>
        /// <param name="tn">
        /// Tree node that was removed.
        /// </param>
        private void SelectedNodes_TreeNodeRemoved(TreeNode tn)
        {
            this.blnSelectionChanged = false;

            this.SelectNode(tn, false, TreeViewAction.Unknown);

            this.OnSelectionsChanged();

            if (this.tnSelectionMirrorPoint == tn) this.tnSelectionMirrorPoint = null;
        }

        /// <summary>
        /// (Un)selects the specified node.
        /// </summary>
        /// <param name="tn">
        /// Node to (un)select.
        /// </param>
        /// <param name="select">
        /// True to select node, false to unselect node.
        /// </param>
        /// <param name="tva">
        /// Specifies the action that caused the selection change.
        /// </param>
        /// <returns>
        /// True if node was selected, false if not.
        /// </returns>
        private bool SelectNode(TreeNode tn, bool select, TreeViewAction tva)
        {
            bool blnSelected = false;

            if (tn == null) return false;

            if (select)
            {
                // Only try to select node if it was not already selected																		
                if (!this.IsNodeSelected(tn))
                {
                    // Check if node selection is cancelled
                    TreeViewCancelEventArgs tvcea = new TreeViewCancelEventArgs(tn, false, tva);
                    base.OnBeforeSelect(tvcea);
                    if (tvcea.Cancel)
                    {
                        // This node selection was cancelled!						
                        return false;
                    }

                    this.PreserveNodeColors(tn);

                    tn.BackColor = this.SelectionBackColor; // GKM moved from above
                    tn.ForeColor = this.BackColor; // GKM moved from above									

                    this.htblSelectedNodes.Add(tn.GetHashCode(), tn);
                    blnSelected = true;
                    this.blnSelectionChanged = true;

                    this.OnAfterSelect(new TreeViewEventArgs(tn, tva));
                }

                this.tnMostRecentSelectedNode = tn;
            }
            else
            {
                // Only unselect node if it was selected
                if (this.IsNodeSelected(tn))
                {
                    this.OnBeforeDeselect(tn);

                    Color[] originalColors = (Color[])this.htblSelectedNodesOrigColors[tn.GetHashCode()];
                    if (originalColors != null)
                    {
                        this.htblSelectedNodes.Remove(tn.GetHashCode());
                        this.blnSelectionChanged = true;
                        this.htblSelectedNodesOrigColors.Remove(tn.GetHashCode());

                        // GKM - Restore original node colors
                        tn.BackColor = originalColors[0]; // GKM - was BackColor;
                        tn.ForeColor = originalColors[1]; // GKM - was ForeColor;
                    }

                    this.OnAfterDeselect(tn);
                }
            }

            return blnSelected;
        }

        /// <summary>
        /// Selects nodes within the specified range.
        /// </summary>
        /// <param name="startNode">
        /// Start node.
        /// </param>
        /// <param name="endNode">
        /// End Node.
        /// </param>
        /// <param name="tva">
        /// Specifies the action that caused the selection change.
        /// </param>
        private void SelectNodesInsideRange(TreeNode startNode, TreeNode endNode, TreeViewAction tva)
        {
            // Calculate start node and end node
            TreeNode firstNode = null;
            TreeNode lastNode = null;
            if (startNode.Bounds.Y < endNode.Bounds.Y)
            {
                firstNode = startNode;
                lastNode = endNode;
            }
            else
            {
                firstNode = endNode;
                lastNode = startNode;
            }

            // Select each node in range
            this.SelectNode(firstNode, true, tva);
            TreeNode tnTemp = firstNode;
            while (tnTemp != lastNode)
            {
                tnTemp = tnTemp.NextVisibleNode;
                if (tnTemp != null)
                {
                    this.SelectNode(tnTemp, true, tva);
                }
            }

            this.SelectNode(lastNode, true, tva);
        }

        /// <summary>
        /// makes focus rectangle visible or hides it.
        /// </summary>
        /// <param name="tn">
        /// Node to make focus rectangle (in)visible for.
        /// </param>
        /// <param name="visible">
        /// True to make focus rectangle visible, false to hide it.
        /// </param>
        private void SetFocusToNode(TreeNode tn, bool visible)
        {
            Graphics g = this.CreateGraphics();
            Rectangle rect = new Rectangle(tn.Bounds.X, tn.Bounds.Y, tn.Bounds.Width, tn.Bounds.Height);
            if (visible)
            {
                this.Invalidate(rect, false);
                this.Update();
                if (tn.BackColor != this.SelectionBackColor)
                {
                    g.DrawRectangle(new Pen(new SolidBrush(this.SelectionBackColor), 1), rect);
                }
            }
            else
            {
                if (tn.BackColor != this.SelectionBackColor)
                {
                    g.DrawRectangle(
                        new Pen(new SolidBrush(this.BackColor), 1),
                        this.tnMostRecentSelectedNode.Bounds.X,
                        this.tnMostRecentSelectedNode.Bounds.Y,
                        this.tnMostRecentSelectedNode.Bounds.Width,
                        this.tnMostRecentSelectedNode.Bounds.Height);
                }

                this.Invalidate(rect, false);
                this.Update();
            }
        }

        /// <summary>
        ///     Starts edit on a node.
        /// </summary>
        private void StartEdit()
        {
            Thread.Sleep(200);
            if (!this.blnWasDoubleClick)
            {
                this.blnInternalCall = true;
                this.SelectedNode = this.tnNodeToStartEditOn;
                this.blnInternalCall = false;
                this.tnNodeToStartEditOn.BeginEdit();
            }
            else
            {
                this.blnWasDoubleClick = false;
            }
        }

        /// <summary>
        /// Unselects all selected nodes.
        /// </summary>
        /// <param name="tva">
        /// Specifies the action that caused the selection change.
        /// </param>
        private void UnselectAllNodes(TreeViewAction tva)
        {
            this.UnselectAllNodesExceptNode(null, tva);
        }

        /// <summary>
        /// Unselects all selected nodes, except for the specified node which should not be touched.
        /// </summary>
        /// <param name="nodeKeepSelected">
        /// Node not to touch.
        /// </param>
        /// <param name="tva">
        /// Specifies the action that caused the selection change.
        /// </param>
        private void UnselectAllNodesExceptNode(TreeNode nodeKeepSelected, TreeViewAction tva)
        {
            // First, build list of nodes that need to be unselected
            ArrayList arrNodesToDeselect = new ArrayList();
            foreach (TreeNode selectedTreeNode in this.htblSelectedNodes.Values)
            {
                if (nodeKeepSelected == null)
                {
                    arrNodesToDeselect.Add(selectedTreeNode);
                }
                else if ((nodeKeepSelected != null) && (selectedTreeNode != nodeKeepSelected))
                {
                    arrNodesToDeselect.Add(selectedTreeNode);
                }
            }

            // Do the actual unselect
            foreach (TreeNode tnToDeselect in arrNodesToDeselect)
            {
                this.SelectNode(tnToDeselect, false, tva);
            }
        }

        /// <summary>
        /// Unselects all selected nodes that don't belong directly to the specified parent.
        /// </summary>
        /// <param name="parent">
        /// Parent node.
        /// </param>
        /// <param name="tva">
        /// Specifies the action that caused the selection change.
        /// </param>
        private void UnselectAllNodesNotBelongingDirectlyToParent(TreeNode parent, TreeViewAction tva)
        {
            // First, build list of nodes that need to be unselected
            ArrayList arrNodesToDeselect = new ArrayList();
            foreach (TreeNode selectedTreeNode in this.htblSelectedNodes.Values)
            {
                if (selectedTreeNode.Parent != parent)
                {
                    arrNodesToDeselect.Add(selectedTreeNode);
                }
            }

            // Do the actual unselect
            foreach (TreeNode tnToDeselect in arrNodesToDeselect)
            {
                this.SelectNode(tnToDeselect, false, tva);
            }
        }

        /// <summary>
        /// Unselects all selected nodes that don't belong to the specified level.
        /// </summary>
        /// <param name="level">
        /// Node level.
        /// </param>
        /// <param name="tva">
        /// Specifies the action that caused the selection change.
        /// </param>
        private void UnselectAllNodesNotBelongingToLevel(int level, TreeViewAction tva)
        {
            // First, build list of nodes that need to be unselected
            ArrayList arrNodesToDeselect = new ArrayList();
            foreach (TreeNode selectedTreeNode in this.htblSelectedNodes.Values)
            {
                if (this.GetNodeLevel(selectedTreeNode) != level)
                {
                    arrNodesToDeselect.Add(selectedTreeNode);
                }
            }

            // Do the actual unselect
            foreach (TreeNode tnToDeselect in arrNodesToDeselect)
            {
                this.SelectNode(tnToDeselect, false, tva);
            }
        }

        /// <summary>
        /// Unselects all selected nodes that don't belong directly or indirectly to the specified parent.
        /// </summary>
        /// <param name="parent">
        /// Parent node.
        /// </param>
        /// <param name="tva">
        /// Specifies the action that caused the selection change.
        /// </param>
        private void UnselectAllNodesNotBelongingToParent(TreeNode parent, TreeViewAction tva)
        {
            // First, build list of nodes that need to be unselected
            ArrayList arrNodesToDeselect = new ArrayList();
            foreach (TreeNode selectedTreeNode in this.htblSelectedNodes.Values)
            {
                if (!this.IsChildOf(selectedTreeNode, parent))
                {
                    arrNodesToDeselect.Add(selectedTreeNode);
                }
            }

            // Do the actual unselect
            foreach (TreeNode tnToDeselect in arrNodesToDeselect)
            {
                this.SelectNode(tnToDeselect, false, tva);
            }
        }

        /// <summary>
        /// Unselects nodes outside the specified range.
        /// </summary>
        /// <param name="startNode">
        /// Start node.
        /// </param>
        /// <param name="endNode">
        /// End node.
        /// </param>
        /// <param name="tva">
        /// Specifies the action that caused the selection change.
        /// </param>
        private void UnselectNodesOutsideRange(TreeNode startNode, TreeNode endNode, TreeViewAction tva)
        {
            // Calculate start node and end node
            TreeNode firstNode = null;
            TreeNode lastNode = null;
            if (startNode.Bounds.Y < endNode.Bounds.Y)
            {
                firstNode = startNode;
                lastNode = endNode;
            }
            else
            {
                firstNode = endNode;
                lastNode = startNode;
            }

            // Unselect each node outside range
            TreeNode tnTemp = firstNode;
            while (tnTemp != null)
            {
                tnTemp = tnTemp.PrevVisibleNode;
                if (tnTemp != null)
                {
                    this.SelectNode(tnTemp, false, tva);
                }
            }

            tnTemp = lastNode;
            while (tnTemp != null)
            {
                tnTemp = tnTemp.NextVisibleNode;
                if (tnTemp != null)
                {
                    this.SelectNode(tnTemp, false, tva);
                }
            }
        }

        /// <summary>
        /// Recursively unselect node.
        /// </summary>
        /// <param name="tn">
        /// Node to recursively unselect.
        /// </param>
        /// <param name="tva">
        /// Specifies the action that caused the selection change.
        /// </param>
        private void UnselectNodesRecursively(TreeNode tn, TreeViewAction tva)
        {
            this.SelectNode(tn, false, tva);
            foreach (TreeNode child in tn.Nodes)
            {
                this.UnselectNodesRecursively(child, tva);
            }
        }

        #endregion
    }

    #region SelectedNodesCollection

    #endregion
}