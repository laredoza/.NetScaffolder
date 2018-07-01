// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdoSourceUi.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.Contract.UI;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Core.Common.Validation;

    using global::Common.Logging;

    #endregion

    /// <summary>
    /// The ado source ui.
    /// </summary>
    public class AdoSourceUi : IDataSourceUI
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AdoSourceUi"/> class.
        /// </summary>
        /// <param name="textBox">
        /// The text box.
        /// </param>
        /// <param name="listViewDrivers">
        /// The list view drivers.
        /// </param>
        public AdoSourceUi(TextBox textBox, ListView listViewDrivers)
        {
            this.TxtConnection = textBox;
            this.ListViewDrivers = listViewDrivers;
            this.Options = new AdoSourceOptions();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the list view drivers.
        /// </summary>
        public ListView ListViewDrivers { get; set; }

        /// <summary>
        ///     The options.
        /// </summary>
        public AdoSourceOptions Options { get; set; }

        /// <summary>
        ///     Gets or sets the parameters.
        /// </summary>
        public object Parameters { get; set; }

        /// <summary>
        ///     Gets or sets the source type.
        /// </summary>
        public ISourceType SourceType { get; set; }

        /// <summary>
        /// Gets or sets the txt connection.
        /// </summary>
        public TextBox TxtConnection { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        public List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The load data.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool LoadData(object parameters)
        {
            Logger.Trace("Started LoadData()");
            bool result = false;

            this.Options = this.SourceType.Load(parameters) as AdoSourceOptions;

            if (this.Options != null)
            {
                this.TxtConnection.Text = this.Options.ConnectionString;

                result = this.TestData(this.Options, false);
            }
            else
            {
                this.TxtConnection.Text = string.Empty;
            }

            Logger.Trace("Completed LoadData()");

            return result;
        }

        /// <inheritdoc />
        /// <summary>
        ///     The save data.
        /// </summary>
        /// <param name="parameters">
        ///     The parameters.
        /// </param>
        /// <exception cref="T:System.NotImplementedException">
        /// </exception>
        public void SaveData(object parameters)
        {
            Logger.Trace("Started SaveData()");
            List<object> saveParameters = new List<object> { parameters, this.Options };
            this.Options.Schemas.Clear();
            this.Options.Schemas.AddRange(this.ReturnSelectedSchemas());
            this.SourceType.Save(saveParameters);

            Logger.Trace("Completed SaveData()");
        }

        /// <summary>
        /// The test data.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <param name="displayMessageOnSucceed">
        /// The display Message On Succeed.
        /// </param>
        public bool TestData(object parameters, bool displayMessageOnSucceed)
        {
            bool result = false;

            Logger.Trace("Started TestData()");
            this.ListViewDrivers.Items.Clear();

            if (this.SourceType.Test(this.Options))
            {
                this.SourceType.ReturnSchemas(this.Options);
                this.ListViewDrivers.Items.AddRange(this.ReturnSchemasSchemaListViewItems().ToArray());

                foreach (var schema in this.Options.Schemas)
                {
                    ListViewItem item = this.ListViewDrivers.FindItemWithText(schema);

                    // items = this.ListViewDrivers.Items.Find(schema, false);
                    if (item != null)
                    {
                        item.Checked = true;
                    }
                }

                result = true;
            }
            else
            {
                result = false;
            }

            Logger.Trace("Completed TestData()");
            return result;
        }

        /// <summary>
        ///     The validate.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<Validation> Validate()
        {
            Logger.Trace("Started Validation()");

            List<Validation> result = new List<Validation>();

            return result;
        }

        #endregion

        #region Other Methods

        /// <summary>
        ///     The return driver types.
        /// </summary>
        /// <returns>
        ///     The <see cref="object[]" />.
        /// </returns>
        private ListViewItem[] ReturnSchemasSchemaListViewItems()
        {
            var items = new List<ListViewItem>();
            ListViewItem item;

            foreach (var schema in this.SourceType.Schemas)
            {
                items.Add(new ListViewItem { Text = schema, Tag = schema });
            }

            return items.OrderBy(i => i.Text).ToArray();
        }

        /// <summary>
        /// The return selected schemas.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        private List<string> ReturnSelectedSchemas()
        {
            List<string> result = new List<string>();

            foreach (ListViewItem schema in this.ListViewDrivers.Items)
            {
                if (schema.Checked)
                {
                    result.Add(schema.Text);
                }
            }

            return result;
        }

        #endregion
    }
}