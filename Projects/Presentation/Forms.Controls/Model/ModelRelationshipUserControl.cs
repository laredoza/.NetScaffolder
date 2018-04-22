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

        #endregion

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
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (this.DataSource != null)
            {
                this.RelationshipName = this.DataSource.RelationshipName;
                this.DependencyRelationShip = this.DataSource.DependencyRelationShip;
                //                this.ColumnName = this.DataSource.ColumnName;
                //                this.Description = this.DataSource.Description;
                //                this.Order = this.DataSource.ColumnOrder;
                //                this.DataType = this.DataSource.DomainDataType;
                //                this.Length = this.DataSource.Length;
                //                this.Precision = this.DataSource.Precision;
                //                this.Scale = this.DataSource.Scale;
                //                this.DefaultValue = this.DataSource.DefaultFieldValue;
                //                this.IsRequired = this.DataSource.IsRequired;
                //                this.IsPrimaryKey = this.DataSource.IsPrimaryKey;
            }
            else
            {
                Logger.Trace("Data Source not updated as domain is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

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
        /// Init relationship type combo box
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

        private void ComboBoxRelationshipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ComboBoxRelationshipType.SelectedItem != null)
            {
                this.DependencyRelationShip =
                    (RelationshipType)(this.ComboBoxRelationshipType.SelectedItem as ComboboxItem).Value;
            }
        }
    }
}