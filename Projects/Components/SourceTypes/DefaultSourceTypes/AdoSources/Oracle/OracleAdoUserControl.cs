// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SqlServerAdoUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources.Oracle
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.Contract.UI;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources.MySql;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Core.Common.Validation;

    using global::Common.Logging;

    #endregion

    /// <summary>
    ///     The ado user control.
    /// </summary>
    public partial class OracleAdoUserControl : UserControl, IDataSourceUI
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        private AdoSourceUi AdoSourceUi;

        #endregion

        #region Fields

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SqlServerAdoUserControl" /> class.
        /// </summary>
        public OracleAdoUserControl()
        {
            Logger.Trace("Started SqlServerAdoUserControl()");
            this.InitializeComponent();
            this.AdoSourceUi = new AdoSourceUi(this.TxtConnection, this.ListViewDrivers);

            Logger.Trace("Completed SqlServerAdoUserControl()");
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the parameters.
        /// </summary>
        public object Parameters { get; set; }

        public ISourceType SourceType
        {
            get
            {
                return this.AdoSourceUi.SourceType;
            }

            set
            {
                if (this.AdoSourceUi.SourceType != value)
                {
                    this.AdoSourceUi.SourceType = value;
                }
            }
        }

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
            this.AdoSourceUi.LoadData(parameters);
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
            this.AdoSourceUi.SaveData(parameters);
        }

        /// <summary>
        /// The test data.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void TestData(object parameters, bool displayMessageOnSucceed)
        {
            this.AdoSourceUi.TestData(parameters, displayMessageOnSucceed);
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
            this.AdoSourceUi.Options.ConnectionString = this.TxtConnection.Text;
        }

    }
}