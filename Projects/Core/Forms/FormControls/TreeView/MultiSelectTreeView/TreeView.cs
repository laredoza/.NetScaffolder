// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TreeView.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace FormControls.TreeView.MultiSelectTreeView
{
    #region Usings

    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

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
        ///     Hashtable that contains all selected nodes.
        /// </summary>
        private readonly Hashtable htblSelectedNodes = new Hashtable();

        /// <summary>
        ///     Hashtable to preserve Node's original colors (colors can be set on the TreeView, or individual nodes)
        ///     (GKM)
        /// </summary>
        private readonly Hashtable htblSelectedNodesOrigColors = new Hashtable();

        /// <summary>
        ///     Used to make sure that SelectedNode can only be used from within this class.
        /// </summary>
        private bool blnInternalCall;

        /// <summary>
        ///     Keeps track whether a node click has been handled by the mouse down event. This is almost always the
        ///     case, except when a selected node has been clicked again. Then, it will not be handled in the mouse
        ///     down event because we might want to drag the node and if that's the case, node should not go in edit
        ///     mode.
        /// </summary>
        private bool blnNodeProcessedOnMouseDown;

        /// <summary>
        ///     Track whether the total SelectedNodes changed across multiple operations
        ///     for SelectionsChanged event
        /// </summary>
        private bool blnSelectionChanged;

        /// <summary>
        ///     Remembers whether mouse click on a node was single or double click.
        /// </summary>
        private bool blnWasDoubleClick;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private Container components;

        /// <summary>
        ///     Keeps track of the number of mouse clicks.
        /// </summary>
        private int intMouseClicks;

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
        private TreeNode tnKeysStartNode;

        /// <summary>
        ///     Keeps track of most recent selected node.
        /// </summary>
        private TreeNode tnMostRecentSelectedNode;

        /// <summary>
        ///     Keeps track of node that has to be pu in edit mode.
        /// </summary>
        private TreeNode tnNodeToStartEditOn;

        /// <summary>
        ///     Keeps track of the selection mirror point; this is the last selected node without SHIFT key pressed.
        ///     It is used as the mirror node during SHIFT selection.
        /// </summary>
        private TreeNode tnSelectionMirrorPoint;

        /// <summary>
        ///     Holds node that needs to be flashed.
        /// </summary>
        private TreeNode tnToFlash;

        #endregion

        #region Public Events

        /// <summary>
        ///     The after deselect.
        /// </summary>
        public event TreeViewEventHandler AfterDeselect;

        /// <summary>
        ///     The before deselect.
        /// </summary>
        public event TreeViewEventHandler BeforeDeselect;

        /// <summary>
        ///     The selections changed.
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
                if (!blnInternalCall)
                {
                    throw new NotSupportedException("Use SelectedNodes instead of SelectedNode.");
                }

                return base.SelectedNode;
            }

            set
            {
                if (!blnInternalCall)
                {
                    throw new NotSupportedException("Use SelectedNodes instead of SelectedNode.");
                }

                base.SelectedNode = value;
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
                foreach (TreeNode tn in htblSelectedNodes.Values)
                {
                    selectedNodesCollection.Add(tn);
                }

                selectedNodesCollection.TreeNodeAdded += SelectedNodes_TreeNodeAdded;
                selectedNodesCollection.TreeNodeInserted += SelectedNodes_TreeNodeInserted;
                selectedNodesCollection.TreeNodeRemoved += SelectedNodes_TreeNodeRemoved;
                selectedNodesCollection.SelectedNodesCleared += SelectedNodes_SelectedNodesCleared;

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
                return selectionBackColor;
            }

            set
            {
                selectionBackColor = value;
            }
        }

        /// <summary>
        ///     Gets/sets selection mode.
        /// </summary>
        public TreeViewSelectionMode SelectionMode
        {
            get
            {
                return selectionMode;
            }

            set
            {
                selectionMode = value;
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
                if (components != null)
                {
                    components.Dispose();
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
            blnSelectionChanged = false;

            // All child nodes should be deselected
            bool blnChildSelected = false;
            foreach (TreeNode tn in e.Node.Nodes)
            {
                if (IsNodeSelected(tn))
                {
                    blnChildSelected = true;
                }

                UnselectNodesRecursively(tn, TreeViewAction.Collapse);
            }

            if (blnChildSelected)
            {
                SelectNode(e.Node, true, TreeViewAction.Collapse);
            }

            OnSelectionsChanged();

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
            if (AfterDeselect != null)
            {
                AfterDeselect(this, new TreeViewEventArgs(tn));
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
            if (BeforeDeselect != null)
            {
                BeforeDeselect(this, new TreeViewEventArgs(tn));
            }
        }

        /// <summary>
        /// Occurs before node goes into edit mode.
        /// </summary>
        /// <param name="e">
        /// </param>
        protected override void OnBeforeLabelEdit(NodeLabelEditEventArgs e)
        {
            blnSelectionChanged = false; // prepare for OnSelectionsChanged

            // Make sure that it's the only selected node
            SelectNode(e.Node, true, TreeViewAction.ByMouse);
            UnselectAllNodesExceptNode(e.Node, TreeViewAction.ByMouse);

            OnSelectionsChanged();

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
            e = new ItemDragEventArgs(MouseButtons.Left, SelectedNodes);
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
                    if (tnKeysStartNode == null) tnKeysStartNode = tnMostRecentSelectedNode;
                    break;
                default:
                    tnKeysStartNode = null;
                    break;
            }

            int intNumber = 0;

            TreeNode tnNewlySelectedNodeWithKeys = null;
            switch (e.KeyCode)
            {
                case Keys.Down:
                    tnNewlySelectedNodeWithKeys = tnMostRecentSelectedNode.NextVisibleNode;
                    break;

                case Keys.Up:
                    tnNewlySelectedNodeWithKeys = tnMostRecentSelectedNode.PrevVisibleNode;
                    break;

                case Keys.Left:
                    if (tnMostRecentSelectedNode.IsExpanded) tnMostRecentSelectedNode.Collapse();
                    else tnNewlySelectedNodeWithKeys = tnMostRecentSelectedNode.Parent;
                    break;

                case Keys.Right:
                    if (!tnMostRecentSelectedNode.IsExpanded) tnMostRecentSelectedNode.Expand();
                    else if (tnMostRecentSelectedNode.Nodes != null) tnNewlySelectedNodeWithKeys = tnMostRecentSelectedNode.Nodes[0];
                    break;

                case Keys.Home:
                    tnNewlySelectedNodeWithKeys = Nodes[0];
                    break;

                case Keys.End:
                    tnNewlySelectedNodeWithKeys = GetLastVisibleNode();
                    break;

                case Keys.PageDown:

                    intNumber = GetNumberOfVisibleNodes();
                    tnNewlySelectedNodeWithKeys = GetNextTreeNode(tnMostRecentSelectedNode, true, intNumber);
                    break;

                case Keys.PageUp:

                    intNumber = GetNumberOfVisibleNodes();
                    tnNewlySelectedNodeWithKeys = GetNextTreeNode(tnMostRecentSelectedNode, false, intNumber);
                    break;

                default:
                    base.OnKeyDown(e); // GKM
                    return;
            }

            if (tnNewlySelectedNodeWithKeys != null)
            {
                SetFocusToNode(tnMostRecentSelectedNode, false);
                ProcessNodeRange(
                    tnKeysStartNode,
                    tnNewlySelectedNodeWithKeys,
                    new MouseEventArgs(MouseButtons.Left, 1, Cursor.Position.X, Cursor.Position.Y, 0),
                    kMod,
                    TreeViewAction.ByKeyboard,
                    false);
                tnMostRecentSelectedNode = tnNewlySelectedNodeWithKeys;
                SetFocusToNode(tnMostRecentSelectedNode, true);
            }

            // Ensure visibility
            if (tnMostRecentSelectedNode != null)
            {
                TreeNode tnToMakeVisible = null;
                switch (e.KeyCode)
                {
                    case Keys.Down:
                    case Keys.Right:
                        tnToMakeVisible = GetNextTreeNode(tnMostRecentSelectedNode, true, 5);
                        break;

                    case Keys.Up:
                    case Keys.Left:
                        tnToMakeVisible = GetNextTreeNode(tnMostRecentSelectedNode, false, 5);
                        break;

                    case Keys.Home:
                    case Keys.End:
                        tnToMakeVisible = tnMostRecentSelectedNode;
                        break;

                    case Keys.PageDown:
                        tnToMakeVisible = GetNextTreeNode(tnMostRecentSelectedNode, true, intNumber - 2);
                        break;

                    case Keys.PageUp:
                        tnToMakeVisible = GetNextTreeNode(tnMostRecentSelectedNode, false, intNumber - 2);
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
            tnKeysStartNode = null;

            // Store number of mouse clicks in OnMouseDown event, because here we also get e.Clicks = 2 when an item was doubleclicked
            // in OnMouseUp we seem to get always e.Clicks = 1, also when item is doubleclicked
            intMouseClicks = e.Clicks;

            TreeNode tn = GetNodeAt(e.X, e.Y);

            if (tn == null) return;

            // Preserve colors here, because if you do it later then it will already have selected colors 
            // Don't know why...!
            PreserveNodeColors(tn);

            // If +/- was clicked, we should not process the node.
            if (!IsPlusMinusClicked(tn, e))
            {
                // If mouse down on a node that is already selected, then we should process this node in the mouse up event, because we
                // might want to drag it and it should not be put in edit mode.
                // Also, only process node if click was in node's bounds.
                if ((tn != null) && IsClickOnNode(tn, e) && !IsNodeSelected(tn))
                {
                    // Flash node. In case the node selection is cancelled by the user, this gives the effect that it
                    // was selected and unselected again.
                    tnToFlash = tn;
                    Thread t = new Thread(FlashNode);
                    t.Start();

                    blnNodeProcessedOnMouseDown = true;

                    Debug.WriteLine("*** " + tn.BackColor);
                    ProcessNodeRange(
                        tnMostRecentSelectedNode,
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
                if (!blnNodeProcessedOnMouseDown)
                {
                    TreeNode tn = GetNodeAt(e.X, e.Y);

                    // Mouse click has not been handled by the mouse down event, so do it here. This is the case when
                    // a selected node was clicked again; in that case we handle that click here because in case the
                    // user is dragging the node, we should not put it in edit mode.					
                    if (IsClickOnNode(tn, e))
                    {
                        ProcessNodeRange(
                            tnMostRecentSelectedNode,
                            tn,
                            e,
                            ModifierKeys,
                            TreeViewAction.ByMouse,
                            true);
                    }
                }

                blnNodeProcessedOnMouseDown = false;

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
        ///     The on selections changed.
        /// </summary>
        protected void OnSelectionsChanged()
        {
            if (blnSelectionChanged)
                if (SelectionsChanged != null)
                {
                    SelectionsChanged(this, new EventArgs());
                }
        }

        /// <summary>
        ///     Flashes node.
        /// </summary>
        private void FlashNode()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { FlashNode(); }));
                return;
            }

            TreeNode tn = tnToFlash;

            // Only flash node is it's not yet selected
            if (!IsNodeSelected(tn))
            {
                tn.BackColor = SelectionBackColor;
                tn.ForeColor = BackColor;
                Invalidate();
                Refresh();
                Application.DoEvents();
                Thread.Sleep(200);
            }

            // If node is not selected yet, restore default colors to end flashing
            if (!IsNodeSelected(tn))
            {
                tn.BackColor = BackColor;
                tn.ForeColor = ForeColor;
            }
        }

        /// <summary>
        ///     Gets last visible node.
        /// </summary>
        /// <returns>Last visible node.</returns>
        private TreeNode GetLastVisibleNode()
        {
            TreeNode tnTemp = Nodes[0];

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

            TreeNode tnTemp = Nodes[0];

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
            components = new Container();
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

                tnTemp = tnTemp.Parent;
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
            if (tn != null) return htblSelectedNodes.ContainsKey(tn.GetHashCode());
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
            int intNodeLevel = GetNodeLevel(tn);
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

            if (htblSelectedNodesOrigColors.ContainsKey(tn.GetHashCode()))
            {
                // 				Color[] color = (Color[])htblSelectedNodesOrigColors[tn.GetHashCode()];
                // 				color[0]=tn.BackColor;
                // 				color[1]=tn.ForeColor;
            }
            else
            {
                htblSelectedNodesOrigColors.Add(tn.GetHashCode(), new[] { tn.BackColor, tn.ForeColor });
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
            blnSelectionChanged = false; // prepare for OnSelectionsChanged

            if (e.Button == MouseButtons.Left)
            {
                blnWasDoubleClick = intMouseClicks == 2;

                TreeNode tnTemp = null;
                int intNodeLevelStart;

                if (((keys & Keys.Control) == 0) && ((keys & Keys.Shift) == 0))
                {
                    // CTRL and SHIFT not held down							
                    tnSelectionMirrorPoint = endNode;
                    int intNumberOfSelectedNodes = SelectedNodes.Count;

                    // If it was a double click, select node and suspend further processing					
                    if (blnWasDoubleClick)
                    {
                        base.OnMouseDown(e);
                        return;
                    }

                    if (!IsPlusMinusClicked(endNode, e))
                    {
                        bool blnNodeWasSelected = false;
                        if (IsNodeSelected(endNode)) blnNodeWasSelected = true;

                        UnselectAllNodesExceptNode(endNode, tva);
                        SelectNode(endNode, true, tva);

                        if (blnNodeWasSelected && LabelEdit && allowStartEdit && !blnWasDoubleClick
                            && (intNumberOfSelectedNodes <= 1))
                        {
                            // Node should be put in edit mode					
                            tnNodeToStartEditOn = endNode;
                            Thread t = new Thread(StartEdit);
                            t.Start();
                        }
                    }
                }
                else if (((keys & Keys.Control) != 0) && ((keys & Keys.Shift) == 0))
                {
                    // CTRL held down
                    tnSelectionMirrorPoint = null;

                    if (!IsNodeSelected(endNode))
                    {
                        switch (selectionMode)
                        {
                            case TreeViewSelectionMode.SingleSelect:
                                UnselectAllNodesExceptNode(endNode, tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameRootBranch:
                                TreeNode tnAbsoluteParent2 = GetRootParent(endNode);
                                UnselectAllNodesNotBelongingToParent(tnAbsoluteParent2, tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameLevel:
                                UnselectAllNodesNotBelongingToLevel(GetNodeLevel(endNode), tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameLevelAndRootBranch:
                                TreeNode tnAbsoluteParent = GetRootParent(endNode);
                                UnselectAllNodesNotBelongingToParent(tnAbsoluteParent, tva);
                                UnselectAllNodesNotBelongingToLevel(GetNodeLevel(endNode), tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameParent:
                                TreeNode tnParent = endNode.Parent;
                                UnselectAllNodesNotBelongingDirectlyToParent(tnParent, tva);
                                break;
                        }

                        SelectNode(endNode, true, tva);
                    }
                    else
                    {
                        SelectNode(endNode, false, tva);
                    }
                }
                else if (((keys & Keys.Control) == 0) && ((keys & Keys.Shift) != 0))
                {
                    // SHIFT pressed  

                    // if startNode is null, we can't select a range, must act as if selection mode is singleSelect
                    if (startNode == null)
                    {
                        UnselectAllNodesExceptNode(endNode, tva);
                        SelectNode(endNode, true, tva);
                    }
                    else
                    {
                        if (tnSelectionMirrorPoint == null)
                        {
                            tnSelectionMirrorPoint = startNode;
                        }

                        switch (selectionMode)
                        {
                            case TreeViewSelectionMode.SingleSelect:
                                UnselectAllNodesExceptNode(endNode, tva);
                                SelectNode(endNode, true, tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameRootBranch:
                                TreeNode tnAbsoluteParentStartNode = GetRootParent(startNode);
                                tnTemp = startNode;

                                // Check each visible node from startNode to endNode and select it if needed
                                while ((tnTemp != null) && (tnTemp != endNode))
                                {
                                    if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                    else tnTemp = tnTemp.NextVisibleNode;
                                    if (tnTemp != null)
                                    {
                                        TreeNode tnAbsoluteParent = GetRootParent(tnTemp);
                                        if (tnAbsoluteParent == tnAbsoluteParentStartNode)
                                        {
                                            SelectNode(tnTemp, true, tva);
                                        }
                                    }
                                }

                                UnselectAllNodesNotBelongingToParent(tnAbsoluteParentStartNode, tva);
                                UnselectNodesOutsideRange(tnSelectionMirrorPoint, endNode, tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameLevel:
                                intNodeLevelStart = GetNodeLevel(startNode);
                                tnTemp = startNode;

                                // Check each visible node from startNode to endNode and select it if needed
                                while ((tnTemp != null) && (tnTemp != endNode))
                                {
                                    if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                    else tnTemp = tnTemp.NextVisibleNode;
                                    if (tnTemp != null)
                                    {
                                        int intNodeLevel = GetNodeLevel(tnTemp);
                                        if (intNodeLevel == intNodeLevelStart)
                                        {
                                            SelectNode(tnTemp, true, tva);
                                        }
                                    }
                                }

                                UnselectAllNodesNotBelongingToLevel(intNodeLevelStart, tva);
                                UnselectNodesOutsideRange(tnSelectionMirrorPoint, endNode, tva);
                                break;

                            case TreeViewSelectionMode.MultiSelectSameLevelAndRootBranch:
                                TreeNode tnAbsoluteParentStart = GetRootParent(startNode);
                                intNodeLevelStart = GetNodeLevel(startNode);
                                tnTemp = startNode;

                                // Check each visible node from startNode to endNode and select it if needed
                                while ((tnTemp != null) && (tnTemp != endNode))
                                {
                                    if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                    else tnTemp = tnTemp.NextVisibleNode;
                                    if (tnTemp != null)
                                    {
                                        int intNodeLevel = GetNodeLevel(tnTemp);
                                        TreeNode tnAbsoluteParent = GetRootParent(tnTemp);
                                        if ((intNodeLevel == intNodeLevelStart)
                                            && (tnAbsoluteParent == tnAbsoluteParentStart))
                                        {
                                            SelectNode(tnTemp, true, tva);
                                        }
                                    }
                                }

                                UnselectAllNodesNotBelongingToParent(tnAbsoluteParentStart, tva);
                                UnselectAllNodesNotBelongingToLevel(intNodeLevelStart, tva);
                                UnselectNodesOutsideRange(tnSelectionMirrorPoint, endNode, tva);
                                break;

                            case TreeViewSelectionMode.MultiSelect:
                                SelectNodesInsideRange(tnSelectionMirrorPoint, endNode, tva);
                                UnselectNodesOutsideRange(tnSelectionMirrorPoint, endNode, tva);
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
                                            SelectNode(tnTemp, true, tva);
                                        }
                                    }
                                }

                                UnselectAllNodesNotBelongingDirectlyToParent(tnParentStartNode, tva);
                                UnselectNodesOutsideRange(tnSelectionMirrorPoint, endNode, tva);

                                break;
                        }
                    }
                }
                else if (((keys & Keys.Control) != 0) && ((keys & Keys.Shift) != 0))
                {
                    // SHIFT AND CTRL pressed
                    switch (selectionMode)
                    {
                        case TreeViewSelectionMode.SingleSelect:
                            UnselectAllNodesExceptNode(endNode, tva);
                            SelectNode(endNode, true, tva);
                            break;

                        case TreeViewSelectionMode.MultiSelectSameRootBranch:
                            TreeNode tnAbsoluteParentStartNode = GetRootParent(startNode);
                            tnTemp = startNode;

                            // Check each visible node from startNode to endNode and select it if needed
                            while ((tnTemp != null) && (tnTemp != endNode))
                            {
                                if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                else tnTemp = tnTemp.NextVisibleNode;
                                if (tnTemp != null)
                                {
                                    TreeNode tnAbsoluteParent = GetRootParent(tnTemp);
                                    if (tnAbsoluteParent == tnAbsoluteParentStartNode)
                                    {
                                        SelectNode(tnTemp, true, tva);
                                    }
                                }
                            }

                            UnselectAllNodesNotBelongingToParent(tnAbsoluteParentStartNode, tva);
                            break;

                        case TreeViewSelectionMode.MultiSelectSameLevel:
                            intNodeLevelStart = GetNodeLevel(startNode);
                            tnTemp = startNode;

                            // Check each visible node from startNode to endNode and select it if needed
                            while ((tnTemp != null) && (tnTemp != endNode))
                            {
                                if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                else tnTemp = tnTemp.NextVisibleNode;
                                if (tnTemp != null)
                                {
                                    int intNodeLevel = GetNodeLevel(tnTemp);
                                    if (intNodeLevel == intNodeLevelStart)
                                    {
                                        SelectNode(tnTemp, true, tva);
                                    }
                                }
                            }

                            UnselectAllNodesNotBelongingToLevel(intNodeLevelStart, tva);
                            break;

                        case TreeViewSelectionMode.MultiSelectSameLevelAndRootBranch:
                            TreeNode tnAbsoluteParentStart = GetRootParent(startNode);
                            intNodeLevelStart = GetNodeLevel(startNode);
                            tnTemp = startNode;

                            // Check each visible node from startNode to endNode and select it if needed
                            while ((tnTemp != null) && (tnTemp != endNode))
                            {
                                if (startNode.Bounds.Y > endNode.Bounds.Y) tnTemp = tnTemp.PrevVisibleNode;
                                else tnTemp = tnTemp.NextVisibleNode;
                                if (tnTemp != null)
                                {
                                    int intNodeLevel = GetNodeLevel(tnTemp);
                                    TreeNode tnAbsoluteParent = GetRootParent(tnTemp);
                                    if ((intNodeLevel == intNodeLevelStart)
                                        && (tnAbsoluteParent == tnAbsoluteParentStart))
                                    {
                                        SelectNode(tnTemp, true, tva);
                                    }
                                }
                            }

                            UnselectAllNodesNotBelongingToParent(tnAbsoluteParentStart, tva);
                            UnselectAllNodesNotBelongingToLevel(intNodeLevelStart, tva);
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
                                    SelectNode(tnTemp, true, tva);
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
                                        SelectNode(tnTemp, true, tva);
                                    }
                                }
                            }

                            UnselectAllNodesNotBelongingDirectlyToParent(tnParentStartNode, tva);
                            break;
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                // if right mouse button clicked, clear selection and select right-clicked node
                if (!IsNodeSelected(endNode))
                {
                    UnselectAllNodes(tva);
                    SelectNode(endNode, true, tva);
                }
            }

            OnSelectionsChanged();
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
            blnSelectionChanged = false;

            UnselectAllNodes(TreeViewAction.Unknown);

            OnSelectionsChanged();
        }

        /// <summary>
        /// Occurs when a tree node is added to the SelectedNodes collection.
        /// </summary>
        /// <param name="tn">
        /// Tree node that was added.
        /// </param>
        private void SelectedNodes_TreeNodeAdded(TreeNode tn)
        {
            blnSelectionChanged = false;

            SelectNode(tn, true, TreeViewAction.Unknown);

            // ProcessNodeRange(null, tn, new MouseEventArgs(MouseButtons.Left, 1, Cursor.Position.X,  Cursor.Position.Y, 0), Keys.None, TreeViewAction.ByKeyboard, false); 
            OnSelectionsChanged();
        }

        /// <summary>
        /// Occurs when a tree node is inserted to the SelectedNodes collection.
        /// </summary>
        /// <param name="tn">
        /// tree node that was inserted.
        /// </param>
        private void SelectedNodes_TreeNodeInserted(TreeNode tn)
        {
            blnSelectionChanged = false;

            SelectNode(tn, true, TreeViewAction.Unknown);

            OnSelectionsChanged();
        }

        /// <summary>
        /// Occurs when a tree node is removed from the SelectedNodes collection.
        /// </summary>
        /// <param name="tn">
        /// Tree node that was removed.
        /// </param>
        private void SelectedNodes_TreeNodeRemoved(TreeNode tn)
        {
            blnSelectionChanged = false;

            SelectNode(tn, false, TreeViewAction.Unknown);

            OnSelectionsChanged();

            if (tnSelectionMirrorPoint == tn) tnSelectionMirrorPoint = null;
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
                if (!IsNodeSelected(tn))
                {
                    // Check if node selection is cancelled
                    TreeViewCancelEventArgs tvcea = new TreeViewCancelEventArgs(tn, false, tva);
                    base.OnBeforeSelect(tvcea);
                    if (tvcea.Cancel)
                    {
                        // This node selection was cancelled!						
                        return false;
                    }

                    PreserveNodeColors(tn);

                    tn.BackColor = SelectionBackColor; // GKM moved from above
                    tn.ForeColor = BackColor; // GKM moved from above									

                    htblSelectedNodes.Add(tn.GetHashCode(), tn);
                    blnSelected = true;
                    blnSelectionChanged = true;

                    OnAfterSelect(new TreeViewEventArgs(tn, tva));
                }

                tnMostRecentSelectedNode = tn;
            }
            else
            {
                // Only unselect node if it was selected
                if (IsNodeSelected(tn))
                {
                    OnBeforeDeselect(tn);

                    Color[] originalColors = (Color[])htblSelectedNodesOrigColors[tn.GetHashCode()];
                    if (originalColors != null)
                    {
                        htblSelectedNodes.Remove(tn.GetHashCode());
                        blnSelectionChanged = true;
                        htblSelectedNodesOrigColors.Remove(tn.GetHashCode());

                        // GKM - Restore original node colors
                        tn.BackColor = originalColors[0]; // GKM - was BackColor;
                        tn.ForeColor = originalColors[1]; // GKM - was ForeColor;
                    }

                    OnAfterDeselect(tn);
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
            SelectNode(firstNode, true, tva);
            TreeNode tnTemp = firstNode;
            while (tnTemp != lastNode)
            {
                tnTemp = tnTemp.NextVisibleNode;
                if (tnTemp != null)
                {
                    SelectNode(tnTemp, true, tva);
                }
            }

            SelectNode(lastNode, true, tva);
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
            Graphics g = CreateGraphics();
            Rectangle rect = new Rectangle(tn.Bounds.X, tn.Bounds.Y, tn.Bounds.Width, tn.Bounds.Height);
            if (visible)
            {
                Invalidate(rect, false);
                Update();
                if (tn.BackColor != SelectionBackColor)
                {
                    g.DrawRectangle(new Pen(new SolidBrush(SelectionBackColor), 1), rect);
                }
            }
            else
            {
                if (tn.BackColor != SelectionBackColor)
                {
                    g.DrawRectangle(
                        new Pen(new SolidBrush(BackColor), 1),
                        tnMostRecentSelectedNode.Bounds.X,
                        tnMostRecentSelectedNode.Bounds.Y,
                        tnMostRecentSelectedNode.Bounds.Width,
                        tnMostRecentSelectedNode.Bounds.Height);
                }

                Invalidate(rect, false);
                Update();
            }
        }

        /// <summary>
        ///     Starts edit on a node.
        /// </summary>
        private void StartEdit()
        {
            Thread.Sleep(200);
            if (!blnWasDoubleClick)
            {
                blnInternalCall = true;
                SelectedNode = tnNodeToStartEditOn;
                blnInternalCall = false;
                tnNodeToStartEditOn.BeginEdit();
            }
            else
            {
                blnWasDoubleClick = false;
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
            UnselectAllNodesExceptNode(null, tva);
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
            foreach (TreeNode selectedTreeNode in htblSelectedNodes.Values)
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
                SelectNode(tnToDeselect, false, tva);
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
            foreach (TreeNode selectedTreeNode in htblSelectedNodes.Values)
            {
                if (selectedTreeNode.Parent != parent)
                {
                    arrNodesToDeselect.Add(selectedTreeNode);
                }
            }

            // Do the actual unselect
            foreach (TreeNode tnToDeselect in arrNodesToDeselect)
            {
                SelectNode(tnToDeselect, false, tva);
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
            foreach (TreeNode selectedTreeNode in htblSelectedNodes.Values)
            {
                if (GetNodeLevel(selectedTreeNode) != level)
                {
                    arrNodesToDeselect.Add(selectedTreeNode);
                }
            }

            // Do the actual unselect
            foreach (TreeNode tnToDeselect in arrNodesToDeselect)
            {
                SelectNode(tnToDeselect, false, tva);
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
            foreach (TreeNode selectedTreeNode in htblSelectedNodes.Values)
            {
                if (!IsChildOf(selectedTreeNode, parent))
                {
                    arrNodesToDeselect.Add(selectedTreeNode);
                }
            }

            // Do the actual unselect
            foreach (TreeNode tnToDeselect in arrNodesToDeselect)
            {
                SelectNode(tnToDeselect, false, tva);
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
                    SelectNode(tnTemp, false, tva);
                }
            }

            tnTemp = lastNode;
            while (tnTemp != null)
            {
                tnTemp = tnTemp.NextVisibleNode;
                if (tnTemp != null)
                {
                    SelectNode(tnTemp, false, tva);
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
            SelectNode(tn, false, tva);
            foreach (TreeNode child in tn.Nodes)
            {
                UnselectNodesRecursively(child, tva);
            }
        }

        #endregion
    }

    #region SelectedNodesCollection

    #endregion
}