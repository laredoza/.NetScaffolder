// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DomainMenuUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Usings

    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    using Common.Logging;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Core.Configuration;
    using DotNetScaffolder.Mapping.MetaData.Domain;

    #endregion

    /// <summary>
    ///     The domain menu user control.
    /// </summary>
    public partial class DomainMenuUserControl : UserControl
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Fields

        /// <summary>
        ///     The active control.
        /// </summary>
        private Control activeControl;

        /// <summary>
        ///     The data source.
        /// </summary>
        private DomainDefinition dataSource;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DomainMenuUserControl" /> class.
        /// </summary>
        public DomainMenuUserControl()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource
        {
            get => this.dataSource;
            set
            {
                if (this.dataSource != value)
                {
                    this.dataSource = value;
                    this.UpdateDataSource();
                }
            }
        }

        /// <summary>
        ///     Gets or sets the output path.
        /// </summary>
        public string OutputPath { get; set; }

        /// <summary>
        ///     Gets or sets the parent config control.
        /// </summary>
        public Control ParentConfigControl { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     The save.
        /// </summary>
        public void Save()
        {
            Logger.Trace("Started Save()");
            List<Validation> validationResult;

            if (this.DataSource != null)
            {
                var parameters = new Dictionary<string, string> { { "basePath", this.OutputPath } };
                foreach (TreeNode node in this.DomainTreeView.Nodes)
                {
                    validationResult = (node.Tag as IDataTypeUI)?.Validate();

                    if (validationResult.Count == 0)
                    {
                        (node.Tag as IDataTypeUI)?.SaveConfig(parameters);
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        validationResult = (node.Tag as IDataTypeUI)?.Validate();

                        foreach (var validation in validationResult)
                        {
                            sb.AppendLine(validation.Description);
                        }

                        MessageBox.Show(
                            sb.ToString(),
                            "Error Saving DataType",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                // TODO: Replace with something less annoying
                MessageBox.Show("Save complete", "Success");
            }
            else
            {
                MessageBox.Show(
                    "The DataSource may not be empty",
                    "Error Saving DataType",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Logger.Trace("Data Source is null ");
            }

            Logger.Trace("Completed Save()");
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        public void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (this.DataSource != null)
            {
                foreach (var hierarchy in this.DataSource.Package.Templates)
                {
                    var parameters = new Dictionary<string, string> { { "basePath", this.OutputPath } };

                    var template = hierarchy;
                    var dataType = ScaffoldConfig.ReturnDataType(template.DataType);
                    dataType.Load(parameters);
                    var navigation = dataType.ReturnNavigation();

                    var configControl = ScaffoldConfig.ReturnDataTypeUI(template.DataType, DisplayType.WinForm);
                    configControl.DataType = dataType;

                    configControl.DataSource = this.DataSource;
                    var control = configControl as Control;

                    if (control == null) continue;

                    configControl.OnNavigationChanged += this.ConfigControlOnOnNavigationChanged;

                    control.Visible = false;
                    this.ParentConfigControl.Controls.Add(control);

                    var node = new TreeNode
                                   {
                                       Tag = configControl,
                                       Text = navigation.Name,
                                       Name = navigation.Id.ToString()
                                   };

                    if (navigation.Children.Any())
                    {
                        foreach (var child in navigation.Children)
                        {
                            node.Nodes.Add(
                                new TreeNode { Tag = configControl, Text = child.Name, Name = child.Id.ToString() });
                        }
                    }
                    else
                    {
                        node.Tag = configControl;
                    }

                    this.DomainTreeView.Nodes.Add(node);
                }
            }
            else
            {
                Logger.Trace("Data Source not updated as project is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The config control on on navigation changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="type">
        /// The type.
        /// </param>
        private void ConfigControlOnOnNavigationChanged(object sender, IDataType<IDictionary<string, string>> type)
        {
            var navigation = type.ReturnNavigation();
            var node = this.DomainTreeView.Nodes.Find(navigation.Id.ToString(), false).FirstOrDefault();

            if (node != null)
            {
                foreach (var nav in navigation.Children)
                {
                    var childNode = node.Nodes.Find(nav.Id.ToString(), true).FirstOrDefault();

                    if (childNode != null)
                    {
                        childNode.Text = nav.Name;
                    }
                    else
                    {
                        childNode = new TreeNode { Tag = node.Tag, Text = nav.Name, Name = nav.Id.ToString() };
                        node.Nodes.Add(childNode);
                        node.Expand();
                    }
                }

                foreach (TreeNode child in node.Nodes)
                {
                    if (child == null) continue;

                    var nav = navigation.Children.FirstOrDefault(o => o.Id.ToString() == child.Name);

                    if (nav == null)
                    {
                        node.Nodes.RemoveByKey(child.Name);
                    }
                }
            }
        }

        /// <summary>
        /// The domain tree view_ after select.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void DomainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.activeControl != null)
            {
                this.activeControl.Visible = false;
            }

            if (e.Node.Tag is IDataTypeUI configControl)
            {
                var parameters =
                    new Dictionary<string, string> { { "basePath", this.OutputPath }, { "name", e.Node.Name } };

                configControl.LoadConfig(parameters);

                if (e.Node.Tag is Control control)
                {
                    this.activeControl = control;
                    this.activeControl.Visible = true;
                    this.activeControl.BringToFront();
                }
            }
        }

        #endregion
    }
}