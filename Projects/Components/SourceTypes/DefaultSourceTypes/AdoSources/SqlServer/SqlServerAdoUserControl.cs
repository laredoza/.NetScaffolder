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
            this.SourceType.Save(saveParameters);

            Logger.Trace("Completed SaveData()");
        }

        /// <summary>
        /// The test data.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void TestData(object parameters)
        {
            Logger.Trace("Started TestData()");

            if (this.SourceType.Test(this.options))
            {
                MessageBox.Show("Connected to Sql Server", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unable to Connected to Sql Server", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}