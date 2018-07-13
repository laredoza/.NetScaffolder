// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OracleAdoUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources.Oracle
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.Contract.UI;
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

        #endregion

        #region Fields

        /// <summary>
        /// The ado source ui.
        /// </summary>
        private readonly AdoSourceUi AdoSourceUi;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OracleAdoUserControl"/> class. 
        ///     Initializes a new instance of the <see cref="SqlServerAdoUserControl"/> class.
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

        /// <summary>
        /// Gets or sets the source type.
        /// </summary>
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
            return this.AdoSourceUi.LoadData(parameters);
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
        /// <param name="displayMessageOnSucceed">
        /// The display Message On Succeed.
        /// </param>
        public bool TestData(object parameters, bool displayMessageOnSucceed)
        {
            return this.AdoSourceUi.TestData(parameters, displayMessageOnSucceed);
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

        #region Other Methods

        /// <summary>
        /// The txt connection_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtConnection_TextChanged(object sender, EventArgs e)
        {
            this.AdoSourceUi.Options.ConnectionString = this.TxtConnection.Text;
            this.ListViewDrivers.Items.Clear();
        }

        #endregion
    }
}