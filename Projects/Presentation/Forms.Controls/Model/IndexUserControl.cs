// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IndexUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls.Model
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using DotNetScaffolder.Core.Common;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    ///     The index user control.
    /// </summary>
    public partial class IndexUserControl : UserControl, IValidate
    {
        #region Fields

        /// <summary>
        ///     The data source.
        /// </summary>
        private Index dataSource;

        /// <summary>
        ///     The loading.
        /// </summary>
        private bool loading;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="IndexUserControl" /> class.
        /// </summary>
        public IndexUserControl()
        {
            this.InitializeComponent();
            this.InitComboBoxIndexTypes();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the columns.
        /// </summary>
        public List<string> Columns
        {
            get
            {
                List<string> result = new List<string>();

                foreach (ListViewItem item in this.ListViewColumns.Items)
                {
                    if (item.Checked)
                    {
                        result.Add(item.Text);
                    }
                }

                return result;
            }

            set
            {
                if (this.DataSource != null)
                {
                    this.DataSource.Columns = value;

                    foreach (string column in value)
                    {
                        foreach (ListViewItem item in this.ListViewColumns.Items)
                        {
                            if (item.Text.ToUpper() == column.ToUpper())
                            {
                                // if (!item.Checked)
                                // {
                                item.Checked = true;

                                // }
                                break;
                            }

                            // else
                            // {
                            // item.Checked = false;
                            // }
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public Index DataSource
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
        ///     Gets or sets the index name.
        /// </summary>
        public string IndexName
        {
            get
            {
                return this.TextBoxIndexName.Text;
            }

            set
            {
                if (this.DataSource != null && this.DataSource.Name != value)
                {
                    this.DataSource.Name = value;
                }

                if (this.TextBoxIndexName.Text != value)
                {
                    this.TextBoxIndexName.Text = value;
                }
            }
        }

        /// <summary>
        ///     Gets or sets the index type.
        /// </summary>
        public IndexType IndexType
        {
            get
            {
                var item = this.ComboBoxRelationshipType.SelectedItem as ComboboxItem;
                var index = Convert.ToInt32(item.Value);
                return (IndexType)index;
            }

            set
            {
                if (this.DataSource != null && this.DataSource.IndexType != value)
                {
                    this.DataSource.IndexType = value;
                }

                if (this.ComboBoxRelationshipType.SelectedValue.ToString() != value.GetHashCode().ToString())
                {
                    this.ComboBoxRelationshipType.SelectedValue = value.GetHashCode();
                }
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether is unique.
        /// </summary>
        public bool IsUnique
        {
            get
            {
                return this.CheckBoxIsUnique.Checked;
            }

            set
            {
                if (this.DataSource != null && this.DataSource.IsUnique != value)
                {
                    this.DataSource.IsUnique = value;
                }

                if (this.CheckBoxIsUnique.Checked != value)
                {
                    this.CheckBoxIsUnique.Checked = value;
                }
            }
        }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        public List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     The init combo box relationship type.
        /// </summary>
        public void InitComboBoxIndexTypes()
        {
            var items = new List<ComboboxItem>();

            foreach (IndexType p in Enum.GetValues(typeof(IndexType)))
            {
                items.Add(new ComboboxItem { Text = p.ToString(), Value = p.GetHashCode() });
            }

            this.ComboBoxRelationshipType.DisplayMember = "Text";
            this.ComboBoxRelationshipType.ValueMember = "Value";
            this.ComboBoxRelationshipType.DataSource = items.OrderBy(i => i.Text).ToList();
        }

        /// <summary>
        ///     The validate.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<Validation> Validate()
        {
            return new List<Validation>();
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The check box is unique_ checked changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CheckBoxIsUnique_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.loading)
            {
                this.IsUnique = this.CheckBoxIsUnique.Checked;
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
            if (!this.loading)
            {
                this.IndexType = (IndexType)this.ComboBoxRelationshipType.SelectedValue;
            }
        }

        /// <summary>
        /// The list view columns_ item checked.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ListViewColumns_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!this.loading)
            {
                if (e.Item.Checked)
                {
                    this.Columns.Add(e.Item.Text);
                }
                else
                {
                    this.Columns.Remove(e.Item.Text);
                }

                this.Columns = this.Columns;
            }
        }

        /// <summary>
        /// The list view columns_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ListViewColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.loading)
            {
                List<string> result = new List<string>();

                foreach (ListViewItem item in this.ListViewColumns.Items)
                {
                    if (item.Checked)
                    {
                        result.Add(item.Text);
                    }
                }

                this.Columns = result;
            }
        }

        /// <summary>
        ///     The return column names.
        /// </summary>
        /// <returns>
        ///     The <see cref="ListViewItem[]" />.
        /// </returns>
        private ListViewItem[] ReturnColumnNames()
        {
            var items = new List<ListViewItem>();
            ListViewItem item;

            foreach (Column column in this.DataSource.Table.Columns)
            {
                items.Add(new ListViewItem { Text = column.ColumnName, Tag = column });
            }

            return items.OrderBy(i => i.Text).ToArray();
        }

        /// <summary>
        /// The text box index name_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TextBoxIndexName_TextChanged(object sender, EventArgs e)
        {
            if (!this.loading)
            {
                this.IndexName = this.TextBoxIndexName.Text;
            }
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            if (this.DataSource != null)
            {
                this.loading = true;

                this.IndexName = this.DataSource.Name;
                this.IsUnique = this.DataSource.IsUnique;
                this.IndexType = this.DataSource.IndexType;
                this.ListViewColumns.Items.Clear();
                this.ListViewColumns.Items.AddRange(this.ReturnColumnNames().ToArray());
                this.Columns = this.DataSource.Columns;
                this.loading = false;
            }
        }

        #endregion
    }
}