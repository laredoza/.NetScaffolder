// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SqlServerAdoUserControl.cs" company="DotnetScaffolder">
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
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources.Oracle;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Core.Common.Validation;

    using global::Common.Logging;

    #endregion

    /// <summary>
    ///     The ado user control.
    /// </summary>
    public partial class SqlServerAdoUserControl : UserControl, IDataSourceUI
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Fields

        /// <summary>
        /// The options.
        /// </summary>
        private AdoSourceOptions options;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SqlServerAdoUserControl" /> class.
        /// </summary>
        public SqlServerAdoUserControl()
        {
            Logger.Trace("Started SqlServerAdoUserControl()");
            this.InitializeComponent();
            this.options = new AdoSourceOptions();

            Logger.Trace("Completed SqlServerAdoUserControl()");
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the parameters.
        /// </summary>
        public object Parameters { get; set; }

        /// <summary>
        /// Gets or sets the source type.
        /// </summary>
        public ISourceType SourceType { get; set; }

        /// <summary>
        /// Gets or sets the validation result.
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
        public void LoadData(object parameters)
        {
            Logger.Trace("Started LoadData()");

            this.options = this.SourceType.Load(parameters) as AdoSourceOptions;

            if (this.options != null)
            {
                this.TxtConnection.Text = this.options.ConnectionString;

                this.TestData(this.options, false);
            }
            else
            {
                this.TxtConnection.Text = string.Empty;
            }

            Logger.Trace("Completed LoadData()");
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
            List<object> saveParameters = new List<object> { parameters, this.options };
            this.options.Schemas.Clear();
            this.options.Schemas.AddRange(this.ReturnSelectedSchemas());
            this.SourceType.Save(saveParameters);

            Logger.Trace("Completed SaveData()");
        }

        /// <summary>
        /// The test data.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void TestData(object parameters, bool displayMessageOnSucceed)
        {
            Logger.Trace("Started TestData()");

            if (this.SourceType.Test(this.options))
            {
                if (displayMessageOnSucceed)
                {
                    MessageBox.Show("Connected to Sql Server", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.SourceType.ReturnSchemas(this.options);
                this.ListViewDrivers.Items.AddRange(this.ReturnSchemasSchemaListViewItems().ToArray());
                
                foreach (var schema in this.options.Schemas)
                {
                    ListViewItem item = this.ListViewDrivers.FindItemWithText(schema);
                    //items = this.ListViewDrivers.Items.Find(schema, false);

                    if (item != null)
                    {
                        item.Checked = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Unable to Connect to Sql Server", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Logger.Trace("Completed TestData()");
        }

        /// <summary>
        /// The validate.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Validation> Validate()
        {
            Logger.Trace("Started Validation()");

            List<Validation> result = new List<Validation>();

            if (string.IsNullOrEmpty(this.TxtConnection.Text))
            {
                Validation validation = new Validation(ValidationType.SourceTypeId, "The Edmx Path may not be empty");
                result.Add(validation);
                this.ErrorProvider1.SetError(this.TxtConnection, validation.Description);
            }

            Logger.Trace("Completed Validation()");
            return result;
        }

        #endregion

        private void TxtConnection_TextChanged(object sender, EventArgs e)
        {
            this.options.ConnectionString = this.TxtConnection.Text;
        }

        private void ListViewDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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
                items.Add(new ListViewItem { Text = schema, Tag = schema});
            }

            return items.OrderBy(i => i.Text).ToArray();
        }

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
    }
}