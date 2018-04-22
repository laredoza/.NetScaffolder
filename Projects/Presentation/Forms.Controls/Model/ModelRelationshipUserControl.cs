// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelRelationshipUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls.Model
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using Common.Logging;

    using DotNetScaffolder.Core.Common;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    ///     The relationship user control.
    /// </summary>
    public partial class ModelRelationshipUserControl : UserControl
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Fields

        /// <summary>
        ///     The data source.
        /// </summary>
        private Relationship dataSource;

        /// <summary>
        /// The data source loaded.
        /// </summary>
        private bool dataSourceLoaded;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ModelRelationshipUserControl" /> class.
        /// </summary>
        public ModelRelationshipUserControl()
        {
            this.InitializeComponent();
            this.InitComboBoxDataType();
        }

        #endregion

        #region Public Properties

        public DomainDefinition Domain { get; set; }

        /// <summary>
        /// Gets or sets the column name.
        /// </summary>
        public string ColumnName
        {
            get
            {
                return this.ComboBoxColumn.SelectedText;
            }

            set
            {
                if (this.DataSource != null && this.DataSource.ColumnName != value)
                {
                    this.DataSource.ColumnName = value;
                }

                if (this.ComboBoxColumn.SelectedValue != value)
                {
                    this.ComboBoxColumn.SelectedValue = value;
                }
            }
        }

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public Relationship DataSource
        {
            get
            {
                return this.dataSource;
            }

            set
            {
                this.dataSource = value;
                this.UpdateDataSource();
            }
        }

        /// <summary>
        ///     Gets or sets the dependency relation ship.
        /// </summary>
        public RelationshipType DependencyRelationShip
        {
            get
            {
                ComboboxItem item = this.ComboBoxRelationshipType.SelectedItem as ComboboxItem;
                int index = Convert.ToInt32(item.Value);
                return (RelationshipType)index;
            }

            set
            {
                if ((this.DataSource != null) && this.DataSource.DependencyRelationShip != value)
                {
                    this.DataSource.DependencyRelationShip = value;
                }

                if (this.ComboBoxRelationshipType.SelectedIndex != value.GetHashCode())
                {
                    this.ComboBoxRelationshipType.SelectedIndex = value.GetHashCode();
                }
            }
        }

        /// <summary>
        ///     Gets or sets the relationship name.
        /// </summary>
        public string RelationshipName
        {
            get
            {
                return this.LblRelationship.Text;
            }

            set
            {
                if (this.DataSource.RelationshipName != value)
                {
                    this.DataSource.RelationshipName = value;
                }

                if (this.LblRelationship.Text != value)
                {
                    this.LblRelationship.Text = value;
                }
            }
        }

        /// <summary>
        ///     Gets or sets the schema name.
        /// </summary>
        public string SchemaName
        {
            get
            {
                return this.LblSecurity.Text;
            }

            set
            {
                if (this.DataSource.SchemaName != value)
                {
                    this.DataSource.SchemaName = value;
                }

                if (this.LblSecurity.Text != value)
                {
                    this.LblSecurity.Text = value;
                }
            }
        }

        public string RelatedTableName
        {
            get
            {
                return this.ComboBoxRelatedTable.SelectedValue.ToString();
            }

            set
            {
                if (this.DataSource != null && this.DataSource.TableName != value)
                {
                    this.DataSource.TableName = value;
                }

                if (this.ComboBoxRelatedTable.SelectedValue != value)
                {
                    this.ComboBoxRelatedTable.SelectedValue = value;
                }
            }
        }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The init combo box column.
        /// </summary>
        public void InitComboBoxColumn()
        {
            if (this.DataSource != null)
            {
                List<ComboboxItem> items = new List<ComboboxItem>();

                items.Add(new ComboboxItem { Text = "None" });
                foreach (var column in this.DataSource.Table.Columns)
                {
                    items.Add(new ComboboxItem { Text = column.ColumnName, Value = column.ColumnName });
                }

                this.ComboBoxColumn.DisplayMember = "Text";
                this.ComboBoxColumn.ValueMember = "Value";
                this.ComboBoxColumn.DataSource = items;
            }
        }

        public void InitComboBoxRelatedTable()
        {
            if (this.DataSource != null && this.Domain != null)
            {
                List<ComboboxItem> items = new List<ComboboxItem>();

                items.Add(new ComboboxItem { Text = "None" });
                foreach (var table in this.Domain.Tables)
                {
                    items.Add(new ComboboxItem { Text = table.TableName, Value = table.TableName});
                }

                this.ComboBoxRelatedTable.DisplayMember = "Text";
                this.ComboBoxRelatedTable.ValueMember = "Value";
                this.ComboBoxRelatedTable.DataSource = items;
            }
        }

        /// <summary>
        ///     Init relationship type combo box
        /// </summary>
        public void InitComboBoxDataType()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();

            foreach (RelationshipType p in Enum.GetValues(typeof(RelationshipType)))
            {
                items.Add(new ComboboxItem { Text = p.ToString(), Value = p.GetHashCode() });
            }

            this.ComboBoxRelationshipType.DisplayMember = "Text";
            this.ComboBoxRelationshipType.ValueMember = "Value";
            this.ComboBoxRelationshipType.DataSource = items;
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The combo box column_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ComboBoxColumn.SelectedValue != null)
            {
                this.DataSource.ColumnName = this.ComboBoxColumn.SelectedValue.ToString();
            }
        }

        /// <summary>
        /// The combo box relationship type_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxRelationshipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ComboBoxRelationshipType.SelectedItem != null)
            {
                this.DependencyRelationShip =
                    (RelationshipType)(this.ComboBoxRelationshipType.SelectedItem as ComboboxItem).Value;
            }
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (this.DataSource != null)
            {
                this.dataSourceLoaded = true;
                this.InitComboBoxColumn();
                this.InitComboBoxRelatedTable();
                this.RelationshipName = this.DataSource.RelationshipName;
                this.DependencyRelationShip = this.DataSource.DependencyRelationShip;
                this.SchemaName = this.DataSource.SchemaName;
                this.RelatedTableName = this.DataSource.TableName;
                this.ColumnName = this.DataSource.ColumnName;
            }
            else
            {
                Logger.Trace("Data Source not updated as domain is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        #endregion

        private void ComboBoxRelatedTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ComboBoxRelatedTable.SelectedValue != null)
            {
                this.RelatedTableName = this.ComboBoxRelatedTable.SelectedValue.ToString();
            }
        }
    }
}