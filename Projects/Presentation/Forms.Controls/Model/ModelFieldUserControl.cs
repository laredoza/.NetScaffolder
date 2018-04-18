// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelFieldUserControl.cs" company="DotnetScaffolder">
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

    using DotNetScaffolder.Mapping.MetaData.Model;

    using System.Linq;

    using DotNetScaffolder.Core.Common;

    #region Usings

    #endregion

    #endregion

    /// <summary>
    ///     The field user control.
    /// </summary>
    public partial class ModelFieldUserControl : UserControl
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
        private Column dataSource;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ModelFieldUserControl" /> class.
        /// </summary>
        public ModelFieldUserControl()
        {
            this.InitializeComponent();
            this.InitComboBoxDataType();
        }

        #endregion

        public void InitComboBoxDataType()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();

            foreach (DomainDataType p in Enum.GetValues(typeof(DomainDataType)))
            {
                items.Add(new ComboboxItem { Text = p.ToString(), Value = p.GetHashCode() });
            }

            this.ComboBoxDataType.DisplayMember = "Text";
            this.ComboBoxDataType.ValueMember = "Value";
            this.ComboBoxDataType.DataSource = items;
        }

        #region Public Properties

        /// <summary>
        /// Gets or sets the column name.
        /// </summary>
        public string ColumnName
        {
            get
            {
                return this.LblName.Text;
            }

            set
            {
                if (this.DataSource.ColumnName != value)
                {
                    this.DataSource.ColumnName = value;
                }

                if (this.LblName.Text != value)
                {
                    this.LblName.Text = value;
                }
            }
        }

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public Column DataSource
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
        /// Gets or sets the description.
        /// </summary>
        public string Description
        {
            get
            {
                return this.TxtDescription.Text;
            }

            set
            {
                if (this.DataSource.Description != value)
                {
                    this.DataSource.Description = value;
                }

                if (this.TxtDescription.Text != value)
                {
                    this.TxtDescription.Text = value;
                }
            }
        }

        public int Order 
        {
            get
            {
                return Convert.ToInt32(this.LblOrder.Text);
            }

            set
            {
                if (this.DataSource.ColumnOrder != value)
                {
                    this.DataSource.ColumnOrder = value;
                }

                if (this.TxtDescription.Text != value.ToString())
                {
                    this.LblOrder.Text = value.ToString();
                }
            }
        }

        public int Length
        {
            get
            {
                return Convert.ToInt32(this.TxtBoxLength.Text);
            }

            set
            {
                if (this.DataSource.Length != value)
                {
                    this.DataSource.Length = value;
                }

                if (this.TxtBoxLength.Text != value.ToString())
                {
                    this.TxtBoxLength.Text = value.ToString();
                }
            }
        }

        public int Precision
        {
            get
            {
                return Convert.ToInt32(this.TxtBoxPrecision.Text);
            }

            set
            {
                if (this.DataSource.Precision != value)
                {
                    this.DataSource.Precision = value;
                }

                if (this.TxtBoxPrecision.Text != value.ToString())
                {
                    this.TxtBoxPrecision.Text = value.ToString();
                }
            }
        }

        public int Scale 
        {
            get
            {
                return Convert.ToInt32(this.TxtBoxScale.Text);
            }

            set
            {
                if (this.DataSource.Scale != value)
                {
                    this.DataSource.Scale = value;
                }

                if (this.TxtBoxScale.Text != value.ToString())
                {
                    this.TxtBoxScale.Text = value.ToString();
                }
            }
        }

        public DomainDataType DataType
        {
            get
            {
                ComboboxItem item = this.ComboBoxDataType.SelectedItem as ComboboxItem;
                int index = Convert.ToInt32(item.Value);
                return (DomainDataType)index;
            }

            set
            {
                if (this.DataSource.CSharpDataType != value)
                {
                    this.DataSource.CSharpDataType = value;
                }

                if (this.ComboBoxDataType.SelectedIndex != value.GetHashCode())
                {
                    this.ComboBoxDataType.SelectedIndex = value.GetHashCode();
                }
            }
        }

        public string DefaultValue
        {
            get
            {
                return this.TxtBoxDefault.Text;
            }

            set
            {
                if (this.DataSource.DefaultFieldValue != value)
                {
                    this.DataSource.DefaultFieldValue = value;
                }

                if (this.TxtBoxDefault.Text != value)
                {
                    this.TxtBoxDefault.Text = value;
                }
            }
        }

        public bool IsRequired
        {
            get
            {
                return this.CheckBoxRequired.Checked;
            }

            set
            {
                if (this.DataSource.IsRequired != value)
                {
                    this.DataSource.IsRequired = value;
                }

                if (this.CheckBoxRequired.Checked != value)
                {
                    this.CheckBoxRequired.Checked = value;
                }
            }
        }

        public bool IsPrimaryKey
        {
            get
            {
                return this.CheckBoxPrimaryKey.Checked;
            }

            set
            {
                if (this.DataSource.IsPrimaryKey != value)
                {
                    this.DataSource.IsPrimaryKey = value;
                }

                if (this.CheckBoxPrimaryKey.Checked != value)
                {
                    this.CheckBoxPrimaryKey.Checked = value;
                }
            }
        }

        #endregion

        #region Other Methods

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (this.DataSource != null)
            {
                this.ColumnName = this.DataSource.ColumnName;
                this.Description = this.DataSource.Description;
                this.Order = this.DataSource.ColumnOrder;
                this.DataType = this.DataSource.CSharpDataType;
                this.Length = this.DataSource.Length;
                this.Precision = this.DataSource.Precision;
                this.Scale = this.DataSource.Scale;
                this.DefaultValue = this.DataSource.DefaultFieldValue;
                this.IsRequired = this.DataSource.IsRequired;
                this.IsPrimaryKey = this.DataSource.IsPrimaryKey;
                // this.SchemaName = this.DataSource.SchemaName;
                // this.ModelName = this.DataSource.TableName;
                // this.Description = this.Description;
            }
            else
            {
                Logger.Trace("Data Source not updated as domain is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        #endregion
    }
}